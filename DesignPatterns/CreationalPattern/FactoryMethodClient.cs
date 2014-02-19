using CreationalPattern.FactoryMethod.Creator;
using CreationalPattern.FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern
{
  public class FactoryMethodClient
  {
    public enum AuthenticatorType
    {
      Google,
      Facebook
    }

    public FactoryMethodClient()
    {
    }

    public void DoAuthentication(AuthenticatorType authenticatorType)
    {
      Creator creator = null;

      switch (authenticatorType)
      {
        case AuthenticatorType.Google:
          creator = new GoogleCreator();
          break;
        case AuthenticatorType.Facebook:
          creator = new FacebookCreator();
          break;
      }
      
      Authenticator authenticator = creator.CreateInstance();
      authenticator.DoAuthentication();
    }    
  }
}