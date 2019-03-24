using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        
        public String Name { get; }
        public String Type { get; }
        private List<function> toCompute;
        public ComposedMission(string v)
        {
            Name = v;
            Type = "Composed";
        }
        
        public double Calculate(double value)
        {
            throw new NotImplementedException();
        }
    }
}
