using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNesne
{
    public class Triangle : Shape   
    {
        public Triangle()
        {

        }

        public Triangle(int x,int y):base(x,y) //Eğer :base yazmasak 0,0 çıktısını alırız
        {
           
        }
        public override void Draw()
        {
            Console.WriteLine("Triangle drawing task.");
            
        }
    }
}
