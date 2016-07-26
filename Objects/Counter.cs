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
  }
}
