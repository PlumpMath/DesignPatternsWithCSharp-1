using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPattern.AbstractFactory.AbstractProduct;

namespace CreationalPattern.AbstractFactory.ConcreteProduct.SQLServer
{
  public class SQLConnection : DBConnection
  {
    public override void Open()
    {      
      Console.WriteLine("SQL Connection is open.");
    }

    public override void Close()
    {
      Console.WriteLine("SQL Connection is close.");
    }
  }
}