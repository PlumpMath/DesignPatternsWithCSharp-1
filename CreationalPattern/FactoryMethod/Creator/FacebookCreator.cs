﻿using CreationalPattern.FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.FactoryMethod.Creator
{
  public class FacebookCreator : Creator
  {
    public override Authenticator CreateInstance()
    {
      return new FacebookAuthenticator();
    }
  }
}