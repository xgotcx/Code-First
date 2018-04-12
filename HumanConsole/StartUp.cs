using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HumanStructure;
using NewHuman;

namespace HumanConsole
{
    public class StartUp
    {
        static void Main()
        {

            using (var db = new HumanModelContext())
            {
                var human = new Human();
                human.FirstName = "Strahil";
                human.LastName = "Voivoda";
                human.Age = "30";
                human.Address = "Ruse 7000, Bulgaria";
                human.NameOfFirm = "Trucks";

                var newFirm = new TheFirm();
                newFirm.Name = "Trucks";
                newFirm.Address = "Ruse, Bulgaria";
                newFirm.Info = " Truck Company";

                var trucks = new TruckInfo();
                trucks.TruckModel = "VOLVO";
                trucks.TruckNumbers = "10";

                var country = new Country();
                country.CountryName = "Bulgaria";

                db.Humans.Add(human);
                db.TheFirms.Add(newFirm);
                db.TruckInfos.Add(trucks);
                db.Countries.Add(country);
                db.SaveChanges();
            }

        }
    }
}
