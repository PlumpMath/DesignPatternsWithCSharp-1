using CreationalPattern.AbstractFactory.AbstractFactory;
using CreationalPattern.AbstractFactory.AbstractProduct;
using CreationalPattern.AbstractFactory.ConcreteFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern
{
  public class AbstractFactoryClient
  {
    DBFactory DBFactory
    {
      //get { return new SQLFactory(); }
      get { return new OracleFactory(); }
    }
    DBConnection DBConnection
    {
      get { return this.DBFactory.CreateConnection(); }
    }

    public AbstractFactoryClient()
    {      
    }

    public int ExecuteCommand()
    {
      int rowsAffected = 0;

      this.DBConnection.Open();

      DBCommand dbCommand = this.DBFactory.CreateCommand();
      rowsAffected = dbCommand.Execute();

      this.DBConnection.Close();

      return rowsAffected;
    }
  }
}