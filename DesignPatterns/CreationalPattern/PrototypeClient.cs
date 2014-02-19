using CreationalPattern.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern
{
  public class PrototypeClient
  {
    public PrototypeClient()
    {
    }

    public void CloneObjects()
    {
      Book book1 = new Book(1, "A Batalha do Apocalipse", 25.50);
      Book book2 = (Book)book1.Clone();
      Console.WriteLine("Book 1\n" + book1.ToString() + "\n");
      Console.WriteLine("Book 2\n" + book2.ToString() + "\n");      

      Book book3 = new Book(2, "O Espadachim de Carvão", 35.50);
      Book book4 = (Book)book3.Clone();
      Console.WriteLine("Book 3\n" + book3.ToString() + "\n");
      Console.WriteLine("Book 4\n" + book4.ToString() + "\n");
    }
  }
}