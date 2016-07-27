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
    public int CountRepeats()
    {
      int inputtedWordCount = 0;
      string sentence = _inputtedSentence.ToLower();
      string wordToCount = _inputtedWord.ToLower().Trim();
      string[] punctuation = new[] {" ", ",", "!", ".", "?", ""};
      string[] wordsToCount = sentence.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
      foreach (string countedWord in wordsToCount)
      {
        if (countedWord == wordToCount)
        {
           inputtedWordCount +=1;
        }
      }
      return inputtedWordCount;
    }
  }
}
