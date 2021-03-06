using Business.Concrete;
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
            ICarManager carManager = new ICarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll()) 
            {
                Console.WriteLine(car.Description);
            }


        }

       
        
        
     
    }
}
