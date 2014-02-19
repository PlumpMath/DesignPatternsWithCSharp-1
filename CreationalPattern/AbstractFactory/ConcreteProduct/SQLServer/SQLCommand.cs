using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPattern.AbstractFactory.AbstractProduct;

namespace CreationalPattern.AbstractFactory.ConcreteProduct.SQLServer
{
  public class SQLCommand : DBCommand
  {
    public override int Execute()
    {
      int rowsAffected = 0;
      Console.WriteLine("SQLServer: {0} row(s) affected", rowsAffected);

      return rowsAffected;
    }
  }
}