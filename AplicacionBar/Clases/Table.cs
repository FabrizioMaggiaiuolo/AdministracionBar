using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Table
    {
        private int number;
        private List<EDrinks> order;
        private bool car;

        public Table(int number) 
        {
            order = new List<EDrinks>();
            this.number = number;
            this.car = false;
        }

        public void AddDrink(EDrinks drink)
        {
            order.Add(drink);
        }

        public bool AddCar()
        {
            if(Bar.AddCar() == true && car == false)
            {
                car = true;
            }
            return car;
        }

        public void Close()
        {
            order.Clear();
            if(car == true)
            {
                Bar.RemoveCar();
            }
            car = false;
        }

        public int Number
        { get { return number; } }

        public bool Car
        { get { return car; } }

        public List<EDrinks> OrderList
        { get { return order; } }

        public decimal Money
        { 
            get 
            {
                decimal total = 0;
                
                foreach (EDrinks drink in order) 
                { 
                    switch(drink)
                    {
                        case EDrinks.fernet:
                            total += 3500;
                            break;
                        case EDrinks.sprite:
                            total += 1500;
                            break;
                        case EDrinks.coke:
                            total += 1700;
                            break;
                        case EDrinks.wine:
                            total += 8000;
                            break;
                        case EDrinks.water:
                            total += 1000;
                            break;
                        case EDrinks.cubaLibre:
                            total += 3200;
                            break;
                        case EDrinks.lemonade:
                            total += 1200;
                            break;
                        case EDrinks.whisky:
                            total += 6000;
                            break;
                    }
                }

                if(car == true) 
                { 
                    total += 1000; 
                }

                return total;
            } 
        }

    }
}
