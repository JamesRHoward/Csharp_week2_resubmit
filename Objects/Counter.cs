using System;
using Nancy;
using System.Collections.Generic;
using Xunit;

namespace CountWord
{
  public class WordCount
  {
    private string _inputtedWord;
    private string _inputtedSentence;
    private int _inputtedWordCount = 0;

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
      int wordCount = 0;
      string sentence = _inputtedSentence.StringToLower();
      string word = _inputtedWord.StringToLower();
      string[] punctuation = new[] {" ", ",", "!", ".", "?"};
      string[] wordsToCount = sentence.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
      foreach (string inputtedWord in inputtedSentence)
      {
        if (inputtedWord == word)
        {
          wordCount ++;
        }
      }
      return WordCount;
    }
  }
}
