using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarManager carManager = new ICarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetail()) 
            {
                Console.WriteLine(car.ColorName+"/"+car.DailyPrice);
            }

        }

        
        
        
     
    }
}
