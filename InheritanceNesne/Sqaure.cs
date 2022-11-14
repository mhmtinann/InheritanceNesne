using System;

namespace InheritanceNesne
{
    public class Sqaure : Rectangle  //Multi-Level Inheritance
    {
        public Sqaure()
        {
                
        }
        public Sqaure(int x,int y):base(x,y) //Önce kendi baseclassına yani rectangleye gider ondan sonra shape classına gider.
        {
            
        }

        new public void Calculate() //shape classında aynı functiondan var.Virtual-override ikilisini kullanmazsak functionun başına new yazarsak override etmiş oluruz.
        {
            Console.WriteLine("Calculated by Square");
        }

        //Rectanglede Draw methoduna sealed yazdığımız zaman artık squarede override edemeyiz.
    }

    




}
