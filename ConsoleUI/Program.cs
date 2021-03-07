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
            var result = carManager.GetAll();
            if(result.Success==true)
            {
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine(car.DailyPrice);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

        }

        
        
        
     
    }
}
