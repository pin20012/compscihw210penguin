using System;

public class Scripture
{
    
    // ATTRIBUTES
    private string _scripture;
    private List<Word> _words = new List<Word>();
     private List<Word> _hiddenWords = new List<Word>();


    // METHODS

    // MakeScripture() splits teh word into words and puts them in a list
    public List<Word> MakeScripture()
        {
            _scripture = 
            "Trust in the Lord with all thine heart; and lean not unto thine own" +
            "understanding. " +
            "In all thy ways acknowledge him, and he shall direct thy paths.";

            // splits the scripture up into an array
            string fullScripture = _scripture;
            string[] parts = fullScripture.Split(" ");
            
            //loops through the words and creates a word object for each one 
            // add the word objects to the _words list
            foreach (string part in parts)
            {
                _words.Add(new Word(part));
            }

            return _words;
            
        }

    // Displays the scripture
    public void DisplayScripture()
    {
        // loops throught the words in _words
        foreach (Word word in _words)
        {
            // displays the word using GetWord() method, to either display or hide the word
            Console.Write($"{word.GetWord()} ");
        }
    }

    public bool HideWord()
    {
        // This is comparing if the _words list count is
        // the same as the _hiddenWords count to
        // determine if all the words in the scripture
        // are hidden 
        if (_words.Count == _hiddenWords.Count)
        {
            // if all the words are hidden:
            return true;
        }

         Random random = new Random();

        // Secondly: random index
        int randomIndex = random.Next(_words.Count);

        //Finally Get the random word
        Word randomWord = _words[randomIndex];

        // if a word is already hidden, hide another word
        if (_hiddenWords.Contains(randomWord))
        {
            return HideWord();
        }
        else
        {
            // Hide the random word
            randomWord.Hide();
            // add random word to the _hiddenWords list
            _hiddenWords.Add(randomWord);
        }
        return false;
    }
}