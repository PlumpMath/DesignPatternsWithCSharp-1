using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.FactoryMethod.Product
{
  internal class FacebookAuthenticator : Authenticator
  {
    public override void DoAuthentication()
    {
      Console.WriteLine("Authenticated on Facebook");
    }
  }
}