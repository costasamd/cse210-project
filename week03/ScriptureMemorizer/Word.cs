using System.Net;
using System.Runtime.InteropServices;

class Word
{

    //member variables for the class
    private string _text;
     private bool _isHiden;

    //getter bool __isHidden
    public bool IsHidden => _isHiden;
    public string OriginalText => _text;

    //constructor 

    public Word(string text)
    {
        _text = text;
        _isHiden = false;
    }
    
    //methods of the class

    public void Hide()
    {
        _isHiden = true;
    }

    public void Show()
    {
        _isHiden = false;
    }


    public string getDisplayText()
    {
        return _isHiden ? new string('_', _text.Length) : _text;
    }

}