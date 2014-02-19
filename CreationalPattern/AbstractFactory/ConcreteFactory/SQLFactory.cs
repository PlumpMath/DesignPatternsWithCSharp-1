using CreationalPattern.AbstractFactory.AbstractFactory;
using CreationalPattern.AbstractFactory.AbstractProduct;
using CreationalPattern.AbstractFactory.ConcreteProduct.SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.AbstractFactory.ConcreteFactory
{
  public class SQLFactory : DBFactory
  {
    public override DBConnection CreateConnection()
    {
      return new SQLConnection();
    }

    public override DBCommand CreateCommand()
    {
      return new SQLCommand();
    }
  }
}