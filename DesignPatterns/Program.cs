using DesignPattern.CreationalPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      //RunAbstractFactoryExample();
      //RunBuilderExample();
      //RunFactoryMethodExample();
      RunPrototypeExample();
    }

    #region CreationalPattern

    private static void RunAbstractFactoryExample()
    {
      AbstractFactoryClient abstractFactoryClient = new AbstractFactoryClient();
      abstractFactoryClient.ExecuteCommand();

      Console.ReadKey();
    }

    private static void RunBuilderExample()
    {
      BuilderClient builderClient = new BuilderClient();
      builderClient.CreateCar();
      builderClient.CreateMotorcycle();

      Console.ReadKey();
    }

    private static void RunFactoryMethodExample()
    {
      FactoryMethodClient factoryMethodClient = new FactoryMethodClient();
      factoryMethodClient.DoAuthentication(FactoryMethodClient.AuthenticatorType.Google);
      factoryMethodClient.DoAuthentication(FactoryMethodClient.AuthenticatorType.Facebook);

      Console.ReadKey();
    }

    private static void RunPrototypeExample()
    {
      PrototypeClient prototypeClient = new PrototypeClient();
      prototypeClient.CloneObjects();

      Console.ReadKey();
    }

    #endregion
  }
}