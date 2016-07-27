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
      int expectedResult = 1;
      WordCount testWordCount = new WordCount("dog", "dog");

      int result = testWordCount.RepeateCount();

      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Test_CounterString_DogTo_dog()
    {
      int expectedResult = 1;
      WordCount testWordCount = new WordCount("Dog", "dog");

      int result = testWordCount.RepeateCount();

      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Test_CounterString_PunctuationCharArr()
    {
      int expectedResult = 1;
      WordCount testWordCount = new WordCount(" dog", "dog");

      int result = testWordCount.RepeateCount();

      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Test_CounterString_0()
    {
      int expectedResult = 0;
      WordCount testWordCount = new WordCount("my cat is the best cat", "dog");

      int result = testWordCount.RepeateCount();

      Assert.Equal(expectedResult, result);
      }
      [Fact]
      public void Test_CounterString_TwoDog()
      {
        int expectedResult = 2;
        WordCount testWordCount = new WordCount("dog dog", "dog");

        int result = testWordCount.RepeateCount();

        Assert.Equal(expectedResult, result);
    }
  }
}
