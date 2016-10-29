using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsReview
{
    public class AnimalBuilder
    {
        private string species;
        private int age;
        private List<string> favoriteFoods;

        public int Age
        {
            set { age = value; }
        }

        public string Species
        {
            set { species = value; }
        }
    }
}
