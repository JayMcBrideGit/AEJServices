using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AEJServices.Models;

namespace AEJServices.Models
{
    public class AejServicesInitializer :System.Data.Entity.DropCreateDatabaseIfModelChanges<AejServicesContext>
    {
        protected override void Seed(AejServicesContext context)
        {
            var employee = new List<Employee>
            {
                new Employee {First_Name="Tom",Last_Name="Alexander",Email="talexander@company.com",Phone="(123)456-7890",PTO=10 },
                new Employee {First_Name="Carson",Last_Name="Olivetto",Email="colivetto@company.com",Phone="(321)987-6541",PTO=8 },
                new Employee {First_Name="Mike ",Last_Name="Jones",Email="mjones@company.com",Phone="(412)789-2546",PTO=8 },
                new Employee {First_Name="Michael",Last_Name="Meyers",Email="mmeyers@company.com",Phone="(666)821-6543",PTO=15 },
                new Employee {First_Name="Jim",Last_Name="Neighbors",Email="jneighbors@company.com",Phone="(214)689-2165",PTO=20 },
                new Employee {First_Name="Jill",Last_Name="Uphillson",Email="juphillson@company.com",Phone="(589)213-2286",PTO=8 },
                new Employee {First_Name="Jane",Last_Name="Jungle",Email="jjungle@company.com",Phone="(432)210-7320",PTO=18 },
                new Employee {First_Name="Bill",Last_Name="Overdue",Email="boverdue@company.com",Phone="(921)987-3867",PTO=4 },
                new Employee {First_Name="Hank",Last_Name="White",Email="hwhite@company.com",Phone="(563)367-9021",PTO=14 },
                new Employee {First_Name="Harry",Last_Name="Henerson",Email="hhenderson@company.com",Phone="(743)987-5387",PTO=7 },
                new Employee {First_Name="Bob",Last_Name="Maloogalooga",Email="bmalooga@company.com",Phone="(394)721-6501",PTO=12 },
                new Employee {First_Name="Kathy",Last_Name="Ackerman",Email="kackerman@company.com",Phone="(472)987-9072",PTO=8 }
            };
            employee.ForEach(e => context.Employee.Add(e));
            context.SaveChanges();

            var customer = new List<Customer>
            {
                new Customer {Company_Name="ABC Industries",Contact_Name="Mike Albertson",Email="malbertson@abc.com",Phone="(987)765-4321" },
                new Customer {Company_Name="Techy Industries",Contact_Name="Jose Flores",Email="jfloresn@techy.com",Phone="(619)765-9821" },
                new Customer {Company_Name="Anderson IT",Contact_Name="Mark Smith",Email="msmith@anderson.com",Phone="(210)421-4901" },
                new Customer {Company_Name="Home Computing",Contact_Name="Jack Sprat",Email="jsprat@hcomputing.com",Phone="(390)621-3957" },
                new Customer {Company_Name="One Stop Solutions",Contact_Name="Mary Jones",Email="mjones@onestop.com",Phone="(619)843-2209" },
                new Customer {Company_Name="None Better",Contact_Name="Gail Fischer",Email="gfischer@nonebetter.com",Phone="(671)765-8824" }
            };
            customer.ForEach(c => context.Customer.Add(c));
            context.SaveChanges();

            var product = new List<Product>
            {
                new Product {ProductId=100,Description="Dell Server",Available=20 },
                new Product {ProductId=101,Description="Cisco Router",Available=50 },
                new Product {ProductId=103,Description="IBM PC",Available=100 },
                new Product {ProductId=200,Description="Netapp Storage",Available=2 },
                new Product {ProductId=105,Description="San Storage",Available=1 }
            };
            product.ForEach(p => context.Product.Add(p));
            context.SaveChanges();

        }
    }
}