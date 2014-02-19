using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.FactoryMethod.Product
{
  public abstract class Authenticator
  {
    public abstract void DoAuthentication();
  }
}