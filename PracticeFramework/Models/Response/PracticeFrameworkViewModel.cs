using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeFramework.Models.Response
{
    public class PracticeFrameworkViewModel
    {
        public int id { get; set; }
        public string description { get; set; }

        public static PracticeFrameworkViewModel From(tblTest tblTestModel)
        {
            if (tblTestModel == null) return null;

            return new PracticeFrameworkViewModel
            {
                id = tblTestModel.Id,
                description = tblTestModel.Description
            };
        }

        public static IEnumerable<PracticeFrameworkViewModel> From(IEnumerable<tblTest> lst)
        {
            return lst?.Distinct().Select(From).ToList();
        }
    }
}