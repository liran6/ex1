using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        public String Name { get; }
        public String Type { get; }
        private function function;
        public SingleMission(function function, string str)
        {
            this.function = function;
            Name = str;
            Type = "Single";
        }      
        public double Calculate(double value)
        {
            double result = function(value);
            OnCalculate?.Invoke(this, result);
            return result;
        }
    }
}
