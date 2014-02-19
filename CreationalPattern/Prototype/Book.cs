using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Prototype
{
  public class Book : BaseItem
  {
    public Book(int id, string description, double price)
      : base(id, description, price)
    {
    }

    public override BaseItem Clone()
    {
      return (BaseItem)this.MemberwiseClone();
    }

    public override string ToString()
    {
      return string.Format("ID: {0} \nDescription: {1} \nPrice: {2}", this.ID, this.Description, this.Price);
    }
  }
}