using DataAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
            List<Car> _cars;

            public InMemoryCarDal()
        {
            _cars = new List<Car>
             {
                //BrandId için 1=Toyota 2=Ford 3=Volkswagen 4=Fiat 5=Mercedes
                //ColorId için 1=Metalik gri 2=Beyaz 3=Siyah


                 new Car{Id =1,BrandId =1,ColorId =1,ModelYear=2010,DailyPrice=200,Description ="Sedan araba"},
                 new Car{Id =2,BrandId =1,ColorId =2,ModelYear=2000,DailyPrice=150,Description ="Modeli düşük sedan araba"},
                 new Car{Id =3,BrandId =2,ColorId =1,ModelYear=2020,DailyPrice=1000,Description ="Yeni nesil Hatchback"},
                 new Car{Id =4,BrandId =3,ColorId =2,ModelYear=2005,DailyPrice=300,Description ="Aile seyahatlerine uygun"},
                 new Car{Id =5,BrandId =3,ColorId =3,ModelYear=2007,DailyPrice=400,Description ="Otomatik vites Sedan araba"},
                 new Car{Id =6,BrandId =4,ColorId =1,ModelYear=2011,DailyPrice=600,Description ="Pick up"},
                 new Car{Id =7,BrandId =5,ColorId =1,ModelYear=2019,DailyPrice=900,Description ="SUV tipi"},

             };   
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);

            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=>c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
        }
    }
}
