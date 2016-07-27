using Nancy;
using System;
using System.Collections.Generic;

namespace CountWord
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        RepeatCounter newCount = new RepeatCounter();
        var NumberOfWords = newCount.CountRepeats(Request.Form["sentence"],Request.Form["word"]);
        return View["results.cshtml", NumberOfWords];
      };
    }
  }
