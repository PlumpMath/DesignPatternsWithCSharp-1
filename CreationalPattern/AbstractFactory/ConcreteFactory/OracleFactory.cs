using CreationalPattern.AbstractFactory.AbstractFactory;
using CreationalPattern.AbstractFactory.AbstractProduct;
using CreationalPattern.AbstractFactory.ConcreteProduct.Oracle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.AbstractFactory.ConcreteFactory
{
  public class OracleFactory : DBFactory
  {
    public override DBConnection CreateConnection()
    {
      return new OracleConnection();
    }

    public override DBCommand CreateCommand()
    {
      return new OracleCommand();
    }
  }
}