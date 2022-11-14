using System;

namespace InheritanceNesne
{
    public  class Rectangle : Shape //Sealed kullanıldığı zaman kalıtımla bir örnek türetemeyiz.Örneğin Squarenin base classı rectangleydi ancak artık çalıştırıdğımız zaman derleyicide hata verir 
    {
        public Rectangle()
        {

        }

        public Rectangle(int x,int y) :base(x,y) //X=x Y=y yazmaktan kurtulmak için base yazarsak aynısı olur.
        {
            

        }
        public sealed override void Draw() //ctrl+. generate overrides ile veya override yazarak yapabiliriz  //Eğer methodu sealed yaparsak square tarafından override edilemez
        {
            Console.WriteLine("Rectangle drawing task...");
        }

        public  void Calculate()
        {
            Console.WriteLine("Calculated by Rectangle");
        }


    }

    




}
