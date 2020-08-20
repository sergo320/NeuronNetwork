using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    public class Neuron
    {
        public List<double> Weight { get; }
        public NeuronType Type { get; }
        public double Output { get; private set; }

    }
}
