using CreationalPattern.Builder.AbstractBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Builder.Director
{
  public class VehicleDirector
  {
    public void Construct(VehicleBuilder builder, string motorName, string portAmount, string wheelAmount)
    {
      builder.BuildMotor(motorName);
      builder.BuildPort(portAmount);
      builder.BuildWheel(wheelAmount);
    }
  }
}