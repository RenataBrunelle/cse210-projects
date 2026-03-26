using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            Word newObjectWord = new Word(wordText);
            _words.Add(newObjectWord);
        }
    }

    public void HiderRandomWords(int numberToHide)
    {
        Random generator = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int indexDrawn = generator.Next(_words.Count);
            _words[indexDrawn].Hide();
        }
    }

    public string GetDisplayText()
    {

        string fullText = _reference.GetDisplayText();
        fullText += " ";

        foreach (Word word in _words)
        {
            string text = word.GetDisplayText();
            fullText += text + " ";
        }
        return fullText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

    public void ShowAllWords()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
    }

}
