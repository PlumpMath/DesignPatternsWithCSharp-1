using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.FactoryMethod.Product
{
  internal class GoogleAuthenticator : Authenticator
  {
    public override void DoAuthentication()
    {
      Console.WriteLine("Authenticated on Google");
    }
  }
}