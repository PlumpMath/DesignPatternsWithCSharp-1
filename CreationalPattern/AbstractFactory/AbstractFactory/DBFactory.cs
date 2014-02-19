using CreationalPattern.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.AbstractFactory.AbstractFactory
{
  public abstract class DBFactory
  {
    public abstract DBConnection CreateConnection();
    public abstract DBCommand CreateCommand();
  }
}