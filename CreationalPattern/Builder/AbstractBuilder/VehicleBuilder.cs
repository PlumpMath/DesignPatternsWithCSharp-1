using CreationalPattern.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Builder.AbstractBuilder
{
  public abstract class VehicleBuilder
  {
    public Vehicle Vehicle { get; set; }

    public abstract void BuildMotor(string motorName);
    public abstract void BuildPort(string portAmount);
    public abstract void BuildWheel(string wheelAmount);
  }
}