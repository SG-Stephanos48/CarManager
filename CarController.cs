using System;
using System.Collections.Generic;
using System.Text;
using CarManager.View;
using CarManager.Models;
using CarManager.Data;

namespace CarManager.Controllers
{
    public class CarController
    {

        CarRepository repo = new CarRepository();
        CarView view = new CarView();

        public void Run()
        {
            
            int selection = view.GetMenuChoice();

            if (selection == 1)  // Create Car
            {

                CreateCar();

            }
            else if (selection == 2)  // Display All Cars
            {

                DisplayCars();

            }
            else if (selection == 3)  // Seach Cars
            {

                SearchCars();

            }
            else if (selection == 4)  // Edit Car
            {

                EditCar();

            }
            else                     // Remove Car
            {

                RemoveCar();

            }
        }

        private void CreateCar()  
        {

            Car newCar = new Car();
            newCar = view.GetNewCarInfo();

            repo.Create(newCar);

            Run();  

        }
                
        private void DisplayCars()
        {
            
            List<Car> dbnew = new List<Car>();
            dbnew = repo.ReadAll();

            foreach (Car car in dbnew)
            {
                view.DisplayCar(car);
            }

            Run();  

        }
        
        private void SearchCars()
        {

            int carId = view.SearchCar();
            var carObj = repo.ReadById(carId);
            view.DisplayCar(carObj);

            Run();  

        }
         
        private void EditCar()
        {
            
            int editId = view.SearchCar();
            var carObj = repo.ReadById(editId);
            var updatedCar = view.EditCarInfo(carObj);
            repo.Update(editId, updatedCar);

            Run();
        }

        private void RemoveCar()
        {

            int removeCar = view.SearchCar();

            //var car = CarRepository.ReadById(removeCar);
            bool decision = view.ConfirmRemoveCar();

            if (decision == true)
            {
                repo.Delete(removeCar);
            }
            else
            {
                view.GetMenuChoice();
            }

            Run();

        }
        
    }
}
