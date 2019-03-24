using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double function(double val);
    //constructor
    public class FunctionsContainer
    {
        private Dictionary<string, function> dict;
        public FunctionsContainer()
        {
            dict = new Dictionary<string, function>();
        }
        //indexer.in order to use [].
        public function this[String str]
        {
            get
            {
                if (!dict.ContainsKey(str))
                {
                    dict.Add(str, val => val);//if the function is not in the map,return the value(do nothing).
                }
                return dict[str];
            }
            set
            {
                dict[str] = value;
            }
        }
        public List<String> getAllMissions()
        {
            return dict.Keys.ToList();
        }
    }
}
