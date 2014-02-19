using CreationalPattern.Builder.AbstractBuilder;
using CreationalPattern.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Builder.ConcreteBuilder
{
  public class CarBuilder : VehicleBuilder
  {
    public CarBuilder()
    {
      this.Vehicle = new Vehicle(Vehicle.Type.Car);
    }

    public override void BuildMotor(string motorName)
    {
      this.Vehicle[Product.Vehicle.Part.MotorName] = motorName;
    }

    public override void BuildPort(string portAmount)
    {
      this.Vehicle[Product.Vehicle.Part.PortAmount] = portAmount;
    }

    public override void BuildWheel(string wheelAmount)
    {
      this.Vehicle[Product.Vehicle.Part.WheelAmount] = wheelAmount;
    }
  }
}