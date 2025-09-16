// This imports the System namespace, which includes basic C# functionality.
using System;

public class Reference
// Defines a new class called "Reference".
// A class is like a blueprint that can hold data (fields) and behaviors (methods).
{
    // These are private fields that store the information about the reference:
    // - _book: name of the book (e.g., "John")
    private string _book;
    // - _chapter: chapter number (e.g., 3)
    private int _chapter;
    // - _verse: starting verse number (e.g., 16)
    private int _verse;
 // - _endVerse: ending verse number (optional, for when the reference covers multiple verses)
    private int _endVerse;

        public Reference(string book, int chapter, int verse)
    {
        // This constructor is used when you want to create a reference with ONE verse.
        // Example: new Reference("John", 3, 16) will store "John 3:16".
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

        public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        // This constructor is used when the reference covers MULTIPLE verses.
        // Example: new Reference("John", 3, 16, 17) will store "John 3:16–17".
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    

        public string GetDisplayText()
    {
        // This method returns the reference in a human-readable format.
        string text;
        if (_endVerse == 0)
        {
            // - If _endVerse == 0, it means we only have one verse. Example: "John 3:16".
            text = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
             // - Otherwise, it means we have a range of verses. Example: "John 3:16-17".
            text = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return text;
    }
    
    // public string getBook()
    // {
    //     return _book;
    // }
    // public int getChapter()
    // {
    //     return _chapter;
    // }
    // public int getVerse()
    // {
    //     return _verse;
    // }
    // public int getEndVerse()
    // {
    //     return _endVerse;
    // }
}