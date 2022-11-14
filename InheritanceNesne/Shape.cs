using System;

namespace InheritanceNesne
{
    public class Shape //baseclass
    {
        public Shape() //boş constructoru program.cs deki listenin newlenmesi için oluşturmak zorundaydık.
        {

        }
        public Shape(int x, int y) //Passing parameter w Constructor
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
        public int Height { get; set; }
        public int Widht { get; set; }
        
        //virtual-keywords
        public virtual void Draw() //ctrl + . generate overridesten değiştirebiliriz. //virtual override edilebilmesi için kullanılır.
        {
            Console.WriteLine("Base class drawing task...");
        }

        public void WorkWithDifferentObject(object o) //tipi obje olarak sakladık(kutulama)  //cast işlemi de denir
        {
            Shape shapeFromParameter = o as Shape;//kutudan çıkarma //Buradaki as in olayı eğer obje Shape türünde gelirse shapeFromParametere aktar değilse null döndürür.
            if (shapeFromParameter!= null) //Null değil ise Draw methodu çalışır eğer null ise çalışmaz ama hata da göndermez.
            {
                shapeFromParameter.Draw();

            }

            if(o is Shape) //True ya da false döner.
            {
                shapeFromParameter.Draw(); //True ise içerideki işlemi yapar
                
            }




        }
        



        
    }


    

}
