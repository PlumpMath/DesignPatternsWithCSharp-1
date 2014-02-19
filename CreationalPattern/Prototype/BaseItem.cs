using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Prototype
{
  public abstract class BaseItem
  {
    public int ID { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public BaseItem(int id, string description, double price)
    {
      this.ID = id;
      this.Description = description;
      this.Price = price;
    }

    public abstract BaseItem Clone();    
  }
}