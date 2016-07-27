using System;
using Nancy;
using System.Collections.Generic;


namespace CountWord
{
  public class WordCount
  {
    private string _inputtedWord;
    private string _inputtedSentence;
    private int _inputtedWordCount = 0;

    public WordCount(string inputtedWord, string inputtedSentence)
    {
      _inputtedWord = inputtedWord;
      _inputtedSentence = inputtedSentence;
    }
    public int GetInputtedWordCount()
    {
      return _inputtedWordCount;
    }
    public string GetInputtedWord()
    {
      return _inputtedSentence;
    }
    public string GetInputtedSentence()
    {
      return _inputtedSentence;
    }
    public void SetInputtedWord(string inputtedWord)
    {
      _inputtedWord = inputtedWord;
    }
    public void SetInputtedSentence(string inputtedSentence)
    {
      _inputtedSentence = inputtedSentence;
    }
    public int RepeateCount()
    {
      int inputtedWordCount = 0;
      string sentence = _inputtedSentence.ToLower();
      string wordToCount = _inputtedWord.ToLower().Trim();
      string[] punctuation = new[] {" ", ",", "!", ".", "?"};
      string[] wordsToCount = sentence.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
      foreach (string countedWord in wordsToCount)
      {
        if (countedWord == wordToCount)
        {
           inputtedWordCount ++;
        }
      }
      return inputtedWordCount;
    }
  }
}
