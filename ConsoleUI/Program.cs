using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //BrandId için 1=Toyota 2=Ford 3=Volkswagen 4=Fiat 5=Mercedes
        //ColorId için 1=Metalik gri 2=Beyaz 3=Siyah
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
                Console.WriteLine("------------");
                Console.WriteLine(car.BrandId);
            }


        }
    }
}
