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

      AssertE.Equal(expectedResult, result)
    }
  }
}
