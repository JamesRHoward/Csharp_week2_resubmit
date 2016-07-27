using System;
using System.Collections.Generic;
using Xunit;

namespace CountWord
{
  public class CountWordTest
  {
    [Fact]
    public void Test_CounterString()
    {
      WordCount testWordCount = new WordCount();
      testWordCount.SetInputtedWord("dog");
      testWordCount.SetInputtedSentence("The dog loves food");
      Assert.Equal(1, testWordCount.RepeateCount());
    }
  }
}
