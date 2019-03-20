using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting;
using System.Text.RegularExpressions;

namespace YodaCoffeeShopData
{
    public class Client : IDbService
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool State { get; set; } = true;

        public IEnumerable<Order> Orders { get; set; }

        public static List<Client> GetAll()
        {
            using (var context = new YodaCoffeeShopContext())
            {
                return context.Clients.ToList();
            }
        }

        public static List<Client> GetByName(string name)
        {
            using (var context = new YodaCoffeeShopContext())
            {
                var rows = context.Clients.Where(cl => cl.Name == name).ToList();
                return rows;
            }
        }

        public static List<Client> GetByEmail(string email)
        {
            using (var context = new YodaCoffeeShopContext())
            {
                var rows = context.Clients.Where(cl => cl.Name == email).ToList();
                return rows;
            }
        }

        public static List<Client> GetByPhoneNumber(string phoneNumber)
        {
            using (var context = new YodaCoffeeShopContext())
            {
                var rows = context.Clients.Where(cl => cl.Name == phoneNumber).ToList();
                return rows;
            }
        }

        public static List<Client> GetByState(bool state)
        {
            using (var context = new YodaCoffeeShopContext())
            {
                var rows = context.Clients.Where(cl => cl.State == state).ToList();
                return rows;
            }
        }

        public void Insert()
        {
            using (var context = new YodaCoffeeShopContext())
            {
                context.Clients.Add(this);
                context.SaveChanges();
            }
        }

        public void Remove()
        {
            using (var context = new YodaCoffeeShopContext())
            {
                var result = (from client in context.Clients
                        where client.Id == Id
                        select client)
                    .SingleOrDefault();
                Debug.Assert(result != null, nameof(result) + " != null");
                result.State = false;
            }
        }

        public static List<Client> SearchByName(string name)
        {
            using (var context = new YodaCoffeeShopContext())
            {
                name = CleanInput(name);
                var query = $@"SELECT * FROM
                                YodaCoffeeShop.dbo.Clients 
                                WHERE Name LIKE '{name}%';";
                var result = context.Clients.SqlQuery(query).ToList();

                return result;
            }
        }

        static string CleanInput(string strIn)
        {
            // Replace invalid characters with empty strings.
            try
            {
                return Regex.Replace(strIn, @"[^\w\.@-]", "",
                    RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            // If we timeout when replacing invalid characters, 
            // we should return Empty.
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }

        public void UpdateName(string name)
        {
            using (var context = new YodaCoffeeShopContext())
            {
                var result = (from client in context.Clients
                        where client.Id == Id
                        select client)
                    .SingleOrDefault();
                Debug.Assert(result != null, nameof(result) + " != null");
                result.Name = name;
            }
        }

        public void UpdateEmail(string email)
        {
            using (var context = new YodaCoffeeShopContext())
            {
                var result = (from client in context.Clients
                        where client.Id == Id
                        select client)
                    .SingleOrDefault();
                Debug.Assert(result != null, nameof(result) + " != null");
                result.Email = email;
            }
        }

        public void UpdatePhoneNumber(string phoneNumber)
        {
            using (var context = new YodaCoffeeShopContext())
            {
                var result = (from client in context.Clients
                        where client.Id == Id
                        select client)
                    .SingleOrDefault();
                Debug.Assert(result != null, nameof(result) + " != null");
                result.PhoneNumber = phoneNumber;
            }
        }
    }
}
