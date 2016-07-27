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
        RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
        return View["results.cshtml", newRepeatCounter];
      };
    }
  }
}
