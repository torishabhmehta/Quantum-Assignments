using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace MyApp
{
  class Driver
  {
    static void Main(string[] args)
    {
      using (var qsim = new QuantumSimulator())
      {
        Hgate.Run(qsim).Wait();
      }
    }
  }
}