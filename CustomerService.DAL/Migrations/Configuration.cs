namespace CustomerService.DAL.Migrations
{
    using CustomerService.DAL.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CustomerService.DAL.Data.CustomerServiceWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CustomerService.DAL.Data.CustomerServiceWebContext";
        }

        protected override void Seed(CustomerService.DAL.Data.CustomerServiceWebContext context)
        {
            var customers = GetCustomers();
            customers.ForEach(c => context.Customers.Add(c));
        }

        private static List<Customer> GetCustomers()
        {
            var customers = new List<Customer> {                new Customer                {                    FirstName = "Edward",                    LastName = "Taylor",                    Address = new Address                    {                        Street = "123 Main Way",                        City = "Orlando",                        State = "FL",                        Zip = "32806"                    },                },                 new Customer                {                    FirstName = "Charles",                    LastName = "Kinder",                    Address = new Address                    {                        Street = "390 Monroe Street",                        City = "Houston",                        State = "TX",                        Zip = "77030"                    },                },                 new Customer                {                    FirstName = "Carina",                    LastName = "Mooney",                    Address = new Address                    {                        Street = "1326 Capitol Avenue",                        City = "Lapel",                        State = "IN",                        Zip = "46051"                    },                }            };
            return customers;
        }
    }
}
