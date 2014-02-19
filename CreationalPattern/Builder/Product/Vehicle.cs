using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Builder.Product
{
  public class Vehicle
  {
    public enum Type
    {
      Car,
      Motorcycle
    }

    public enum Part
    {      
      MotorName,
      PortAmount,
      WheelAmount
    }

    protected Type VehicleType { get; set; }
    protected Dictionary<Part, string> VehiclePart
    {
      get
      {
        if (this.vehiclePart == null)
        {
          this.vehiclePart = new Dictionary<Part, string>();
        }

        return this.vehiclePart;
      }
      set { this.vehiclePart = value; }
    } private Dictionary<Part, string> vehiclePart;

    public string this[Part key]
    {
      get { return this.VehiclePart[key]; }
      set { this.VehiclePart[key] = value; }
    }

    public Vehicle(Type type)
    {
      this.VehicleType = type;
    }

    public void ShowVehicle()
    {
      Console.WriteLine("Type: {0}", this.VehicleType);
      Console.WriteLine("Motor name: {0}", this.VehiclePart[Part.MotorName]);
      Console.WriteLine("Port amount: {0}", this.VehiclePart[Part.PortAmount]);
      Console.WriteLine("Wheel amount: {0}\n\n", this.VehiclePart[Part.WheelAmount]);
    }
  }
}