using System;
using System.Collections.Generic;
using System.Text;
using CarManager.Models;
using CarManager.Data;

namespace CarManager.View
{
    public class CarView
    {

        CarRepository repo = new CarRepository();

        public int GetMenuChoice()
        {
            int selection;
            bool goodchoice = false;

            Console.WriteLine($"Welcome To Car Manager! \n");

            do
            {
                //Display Options for User
                Console.WriteLine("What would you like to do? \n");
                Console.WriteLine("Press 1: Create a new Car: \n");
                Console.WriteLine("Press 2: List all Cars: \n");
                Console.WriteLine("Press 3: Find Car by Id: \n");
                Console.WriteLine("Press 4: Edit a Car: \n");
                Console.WriteLine("Press 5: Remove a Car: \n");

                selection = Convert.ToInt32(Console.ReadLine());
                
                if (selection <= 5 && selection >= 1)
                {
                    goodchoice = true;
                    continue;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 5");
                    goodchoice = false;
                }

            } while (goodchoice == false) ;
            
            Console.WriteLine($"You have selected {selection}, press any key when you are ready to proceed."); 
            Console.ReadKey();

            return selection;
        }
        
        public Car GetNewCarInfo()
        {
            int id;  //auto-generate?
            int year;
            string make;
            string model;
            double price;

            int verify;

            Console.WriteLine("Please enter new car information. ");
            Console.WriteLine("Please enter id");
            id = Convert.ToInt32(Console.ReadLine());  // convert to int
            Console.WriteLine("Please enter car year info. ");
            year = Convert.ToInt32(Console.ReadLine());  // convert to int
            Console.WriteLine("Please enter car make. ");
            make = Console.ReadLine();
            Console.WriteLine("Please enter car model. ");
            model = Console.ReadLine();
            Console.WriteLine("Please enter car price. (Include decimals if needed)");
            price = Convert.ToDouble(Console.ReadLine());  // convert to double

            Car newCar = new Car();

            newCar.Id = id;
            newCar.Year = year;
            newCar.Make = make;
            newCar.Model = model;
            newCar.Price = price;

            Console.WriteLine("Please confirm the new car you want to create is below. Enter 1 if correct or 2 to start over");

            Console.WriteLine($"Your new id is: {newCar.Id}");
            Console.WriteLine($"Your new year is: {newCar.Year}");
            Console.WriteLine($"Your new make is: {newCar.Make}");
            Console.WriteLine($"Your new model is: {newCar.Model}");
            Console.WriteLine($"Your new model is: {newCar.Price}");

            verify = Convert.ToInt32(Console.ReadLine());
            if (verify == 1)
            {
                //create new car in repository
                return newCar;
            }
            else
            {
                return null;  // how do i return to the beginning 
            }

        }

        public void DisplayCar(Car car)
        {

            var displayCar = car;

            Console.WriteLine($"Id: {displayCar.Id }");
            Console.WriteLine($"Year: {displayCar.Year }");
            Console.WriteLine($"Make: {displayCar.Make }");
            Console.WriteLine($"Model: {displayCar.Model }");
            Console.WriteLine($"Price: {displayCar.Price }\n");

        }

        public Car EditCarInfo(Car car)
        {
            var incCar = car;

            int id;  //auto-generate?
            int year;
            string make;
            string model;
            double price;

            int verify;

            Console.WriteLine("Please enter new car information. ");
            Console.WriteLine($"Please update id: {incCar.Id}");
            id = Convert.ToInt32(Console.ReadLine());  // convert to int
            Console.WriteLine($"Please update year: {incCar.Year}");
            year = Convert.ToInt32(Console.ReadLine());  // convert to int
            Console.WriteLine($"Please update make: {incCar.Make}");
            make = Console.ReadLine();
            Console.WriteLine($"Please update model: {incCar.Model}");
            model = Console.ReadLine();
            Console.WriteLine($"Please update price: {incCar.Price}");
            price = Convert.ToDouble(Console.ReadLine());  // convert to double

            Car editCar = new Car();

            editCar.Id = id;
            editCar.Year = year;
            editCar.Make = make;
            editCar.Model = model;
            editCar.Price = price;

            Console.WriteLine("Please confirm your edits are correct. Enter 1 if correct or 2 to start over");

            Console.WriteLine($"Your new id is: {editCar.Id}");
            Console.WriteLine($"Your new year is: {editCar.Year}");
            Console.WriteLine($"Your new make is: {editCar.Make}");
            Console.WriteLine($"Your new model is: {editCar.Model}");
            Console.WriteLine($"Your new model is: {editCar.Price}");

            verify = Convert.ToInt32(Console.ReadLine());
            if (verify == 1)
            {
                //create new car in repository
                return editCar;
            }
            else
            {
                return incCar;         
            }

        }

        public int SearchCar()
        {

            int carId;

            Console.WriteLine("Please enter the id of the car you want to find.");
            carId = Convert.ToInt32(Console.ReadLine());  //convert to int
            // should i check to make sure record exists?
            return carId;
            
        }

        public bool ConfirmRemoveCar()
        {
         
            int reply;

            do 
            {
                Console.WriteLine("Are you sure you want to remove this car? ");
                Console.WriteLine("Press 1 for yes or 2 for no? ");
                reply = Convert.ToInt32(Console.ReadLine());  //convert to int                                             

                if (reply == 1)
                {
                    return true;
                }
                else 
                {
                    return false;
                }

            } while (reply != 1 || reply != 2);        

        }
    }
}
