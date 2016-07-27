using System;
using Nancy;
using System.Collections.Generic;


namespace CountWord
{
  public class RepeatCounter
  {
    private string _inputtedWord;
    private string _inputtedSentence;

    public RepeatCounter(string inputtedWord, string inputtedSentence)
    {
      _inputtedWord = inputtedWord;
      _inputtedSentence = inputtedSentence;
    }
    public string GetInputtedWord()
    {
      return _inputtedWord;
    }
    public string GetInputtedSentence()
    {
      return _inputtedSentence;
    }
    public void SetInputtedWord(string newInputtedWord)
    {
      _inputtedWord = newInputtedWord;
    }
    public void SetInputtedSentence(string newInputtedSentence)
    {
      _inputtedSentence = newInputtedSentence;
    }
    public int CountRepeats()
    {
      int inputtedWordCount = 0;
      string inputtedSentence = _inputtedSentence.ToLower();
      string wordToCount = _inputtedWord.ToLower().Trim();
      string[] punctuation = new [] {" ", ",", "!", ".", "?", ""};
      string[] wordsToCount = inputtedSentence.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
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
