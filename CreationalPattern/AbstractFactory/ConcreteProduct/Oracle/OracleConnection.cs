using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPattern.AbstractFactory.AbstractProduct;

namespace CreationalPattern.AbstractFactory.ConcreteProduct.Oracle
{
  public class OracleConnection : DBConnection
  {
    public override void Open()
    {      
      Console.WriteLine("Oracle Connection is open.");
    }

    public override void Close()
    {
      Console.WriteLine("Oracle Connection is close.");
    }
  }
}
