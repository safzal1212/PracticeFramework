using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeFramework.Models.Request
{
    public class HelloWorldViewModel
    {
        public int id { get; set; }
        public string description { get; set; }

        public static HelloWorldViewModel from()
        {
            return new HelloWorldViewModel();
        }

        public IEnumerable<HelloWorldViewModel>from (List<string> lst)
        {
            return new List<HelloWorldViewModel>();
        }
    }
}