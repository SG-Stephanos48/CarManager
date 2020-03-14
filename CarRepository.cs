using System;
using System.Collections.Generic;
using System.Text;
using CarManager.Data;
using CarManager.Models;

namespace CarManager.Data
{
    public class CarRepository 
    {

        private List<Car> db = new List<Car>();

        public Car Create(Car car)
        {

            db.Add(car);
            return car;

        }

        public List<Car> ReadAll()
        {

            return db; 

        }

        public Car ReadById(int id)  //loop through db list, find specific car object id, return that object 
        {
            foreach (Car car in db)
            {
                if (car.Id == id)
                {
                    return car;
                }
            }
            return null;
        }
        
        public void Update(int id, Car car)  //do updates last.  1. delete existing obj of id 2. insert and create new obj of id 
        {

            Delete(id);
            Create(car);

        }

        public void Delete(int id) // create a new list
        {

            // create a new list tempdb
            List<Car> tempdb = new List<Car>();

            foreach (Car car in db)
            {
                if (car.Id == id)
                {
                    continue;
                }
                tempdb.Add(car);
            }
            db = tempdb;

            // copy over everything from db into tempdb using create method (except the car object with the matching id)
            // replace db with tempdb (db = tempdb)

            //Car car = _context.Cars.Find(id);
            // _context.Cars.Remove(car);

        }

    }
}
