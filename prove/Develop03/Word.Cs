using System;

public class Word

{
    //ATTRIBUTES
    private string _word;
    bool isHidden = false;


    //METHODS
    
    //Constructor initializing word object with the provided word
    public Word(string _word)
    {
        this._word = _word;
    }

    // Hides the word by setting isHidden to true
    public void Hide()
    {
        isHidden = true;
    }

    // if word is hidden returns _____, but if not hidden,
    // the word is returned
    public string GetWord()
    {
        if (isHidden == true)
        {
            return "_____";
        }
        else
        {
            return _word;
        }
    }
}