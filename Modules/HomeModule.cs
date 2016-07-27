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
        RepeatCounter newRepeateCounter = new RepeatCounter(Request.Form["sentence"],Request.Form["word"]);
        return View["results.cshtml", newRepeateCounter];
      };
    }
  }
}
