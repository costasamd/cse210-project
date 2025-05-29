class Scripture
{
    //member variabls of the class
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new();

    //constructor of the class

    public Scripture(Reference reference, String text)
    {
        _reference = reference;

        _words = text.Split(' ').Select(word => new Word(word)).ToList();


        // string[] word = text.Split('');

        // foreach (string w in word)
        // {
        //     Word newWord = new(w);

        //     _words.Add(newWord);
        // }

    }

    //methods of the class
    public void HideRandomNumber(int numberToHide)
    {

        var visibleWord = _words.Where(w => !w.IsHidden).ToList();
        int countToHide = numberToHide;
        countToHide = Math.Min(countToHide, visibleWord.Count);

        for (int i = 0; i < countToHide; i++)
        {
            int index = _random.Next(visibleWord.Count);
            visibleWord[index].Hide();
            visibleWord.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden);
    }


    public string GetDisplayText()
    {
        string display;

        display = $"{_reference.getDisplayText()} - {string.Join(" ", _words.Select(w => w.getDisplayText()))}";

        return display;

    }

}