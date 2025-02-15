using System;
using System.ComponentModel.DataAnnotations;

public class Reference
{
    // ATTRIBUTES
    private string _book;
    private string _chapter;
    private int _verse;
    private int _lastVerse;

// METHODS
// THE getRef() METHOD WORKS
//     The method returns the reference
    public string getRef()
    {
        _book = "Provervs";
        _chapter = "3";
        _verse = 5;
        _lastVerse = 6;

        string reference = $"{_book} {_chapter}: {_verse}-{_lastVerse}";
        return reference;
    }
}