using CreationalPattern.Builder.AbstractBuilder;
using CreationalPattern.Builder.ConcreteBuilder;
using CreationalPattern.Builder.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern
{
  public class BuilderClient
  {
    private VehicleDirector VehicleDirector = new VehicleDirector();

    public BuilderClient()
    {
    }

    public void CreateCar()
    {
      VehicleBuilder vehicleBuilder = new CarBuilder();
      VehicleDirector.Construct(vehicleBuilder, "v8", "4", "4");
      vehicleBuilder.Vehicle.ShowVehicle();
    }

    public void CreateMotorcycle()
    {
      VehicleBuilder vehicleBuilder = new MotorcycleBuilder();
      VehicleDirector.Construct(vehicleBuilder, "150cc", "0", "2");
      vehicleBuilder.Vehicle.ShowVehicle();
    }
  }
}