using System.Xml;

public class Reference
{
    //member variables of the class
    private string _book;

    private int _chapter;

    private int _verse;

    private int _endVerse;

    //constructor of the class

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _verse = start;
        _endVerse = end;

    }



    //methods of the class

    public string getDisplayText()
    {
        string display = "";

        if (_endVerse == 0)
        {
            display = $"{_book} {_chapter}: {_verse}";
           
        }
        else if (_endVerse > 0)
        {
            display = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            
        }
        return display;
    }
}