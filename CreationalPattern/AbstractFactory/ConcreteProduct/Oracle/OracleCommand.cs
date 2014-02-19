using CreationalPattern.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.AbstractFactory.ConcreteProduct.Oracle
{
  public class OracleCommand : DBCommand
  {
    public override int Execute()
    {
      int rowsAffected = 0;
      Console.WriteLine("Oracle: {0} row(s) affected", rowsAffected);

      return rowsAffected;
    }
  }
}