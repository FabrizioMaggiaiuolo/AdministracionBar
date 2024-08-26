using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class Bar
    {
        private static List<User> users;
        public static int garage;
        private static List<EDrinks> inventory;
        private static List<Table> tables;
        private static decimal money;

        static Bar()
        {
            garage = 10;
            money = 0;
            users = new List<User>();

            tables = new List<Table>();
            for (int i = 1; i < 21; i++)
            {
                tables.Add(new Table(i));
            }

            inventory = new List<EDrinks>();

            #region Carga de Invetario

            for (int i = 0;i < 20; i++)
            {
                inventory.Add(EDrinks.sprite);
            }

            for (int i = 0; i < 20; i++)
            {
                inventory.Add(EDrinks.whisky);
            }

            for (int i = 0; i < 20; i++)
            {
                inventory.Add(EDrinks.fernet);
            }

            for (int i = 0; i < 20; i++)
            {
                inventory.Add(EDrinks.wine);
            }

            for (int i = 0; i < 20; i++)
            {
                inventory.Add(EDrinks.cubaLibre);
            }

            for (int i = 0; i < 20; i++)
            {
                inventory.Add(EDrinks.coke);
            }

            for (int i = 0; i < 20; i++)
            {
                inventory.Add(EDrinks.water);
            }

            for (int i = 0; i < 20; i++)
            {
                inventory.Add(EDrinks.lemonade);
            }
            #endregion

        }
        public static User User
        { set {users.Add(value);} }

        public static decimal Money
        { set { money += value;} get {return money;} }

        public static List<EDrinks> Inventory
        { get { return inventory; } }

        public static bool AddCar()
        {
            if (garage - 1 > 0)
            {
                garage--;
                return true;
            }
            return false;
        }
        public static void RemoveCar()
        { garage++; }
        public static Table GetTable(int i)
        {
            return tables[i];
        }

        public static string ListString(List<EDrinks> list)
        {
            int fernet = 0;
            int cubaLibre = 0;
            int whisky = 0;
            int wine = 0;
            int water = 0;
            int coke = 0;
            int sprite = 0;
            int lemonade = 0;
            foreach (EDrinks drink in list)
            {
                switch (drink)
                {
                    case EDrinks.fernet:
                        fernet++;
                        break;
                    case EDrinks.cubaLibre:
                        cubaLibre++;
                        break;
                    case EDrinks.whisky:
                        whisky++;
                        break;
                    case EDrinks.wine:
                        wine++;
                        break;
                    case EDrinks.water:
                        water++;
                        break;
                    case EDrinks.coke:
                        coke++;
                        break;
                    case EDrinks.sprite:
                        sprite++;
                        break;
                    case EDrinks.lemonade:
                        lemonade++;
                        break;

                }
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Fernet: " + fernet);
            sb.AppendLine("Cuba libre: " + cubaLibre);
            sb.AppendLine("Whisky: " + whisky);
            sb.AppendLine("Vino: " + wine);
            sb.AppendLine("Agua: " + water);
            sb.AppendLine("Coca cola: " + coke);
            sb.AppendLine("Sprite: " + sprite);
            sb.AppendLine("Limonada: " + lemonade);

            return sb.ToString();
        }
        public static bool RevisarInventario(EDrinks trago)
        {
            bool retorno = false;
            switch(trago) 
            {
                case (EDrinks.fernet):
                    for(int i = 0;i<inventory.Count && retorno == false;i++)
                    {
                        if (inventory[i] == EDrinks.fernet)
                        {
                            inventory.Remove(EDrinks.fernet);
                            retorno = true;
                        }
                    }
                    break;

                case (EDrinks.cubaLibre):
                    for (int i = 0; i < inventory.Count && retorno == false; i++)
                    {
                        if (inventory[i] == EDrinks.cubaLibre)
                        {
                            inventory.Remove(EDrinks.cubaLibre);
                            retorno = true;
                        }
                    }
                    break;

                case (EDrinks.whisky):
                    for (int i = 0; i < inventory.Count && retorno == false; i++)
                    {
                        if (inventory[i] == EDrinks.whisky)
                        {
                            inventory.Remove(EDrinks.whisky);
                            retorno = true;
                        }
                    }
                    break;

                case (EDrinks.wine):
                    for (int i = 0; i < inventory.Count && retorno == false; i++)
                    {
                        if (inventory[i] == EDrinks.wine)
                        {
                            inventory.Remove(EDrinks.wine);
                            retorno = true;
                        }
                    }
                    break;

                case (EDrinks.water):
                    for (int i = 0; i < inventory.Count && retorno == false; i++)
                    {
                        if (inventory[i] == EDrinks.water)
                        {
                            inventory.Remove(EDrinks.water);
                            retorno = true;
                        }
                    }
                    break;

                case (EDrinks.coke):
                    for (int i = 0; i < inventory.Count && retorno == false; i++)
                    {
                        if (inventory[i] == EDrinks.coke)
                        {
                            inventory.Remove(EDrinks.coke);
                            retorno = true;
                        }
                    }
                    break;

                case (EDrinks.sprite):
                    for (int i = 0; i < inventory.Count && retorno == false; i++)
                    {
                        if (inventory[i] == EDrinks.sprite)
                        {
                            inventory.Remove(EDrinks.sprite);
                            retorno = true;
                        }
                    }
                    break;

                case (EDrinks.lemonade):
                    for (int i = 0; i < inventory.Count && retorno == false ; i++)
                    {
                        if (inventory[i] == EDrinks.lemonade)
                        {
                            inventory.Remove(EDrinks.lemonade);
                            retorno = true;
                        }
                    }
                    break;

            }
            return retorno;
        }
    }
}
