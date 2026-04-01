using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visible = _words.Where(word => !word.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visible.Count > 0; i++)
        {
            int index = _random.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
    }
}