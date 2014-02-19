using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.AbstractFactory.AbstractProduct
{
  public abstract class DBConnection
  {
    public abstract void Open();
    public abstract void Close();
  }
}