using FoodServicer.Model;
using FoodServicer.Repository.Extensions;
using FoodServicer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FoodServicer.Repository.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<CustomerModel> Search(
            string firstName = null, 
            string middleName = null, 
            string lastName = null, 
            string suffix = null)
        {
            var results = new List<CustomerModel>();

            using (var context = ContextContainer.Context)
            {
                var response = context.Customers
                    .Where(x => string.IsNullOrEmpty(firstName) || x.FirstName == firstName)
                    .Where(x => string.IsNullOrEmpty(middleName) || x.MiddleName == middleName)
                    .Where(x => string.IsNullOrEmpty(lastName) || x.LastName == lastName)
                    .Where(x => string.IsNullOrEmpty(suffix) || x.Suffix == suffix)
                    .Include(x => x.Addresses)
                    .Include("Addresses.Type")
                    .Include(x => x.EmailAddresses)
                    .Include("EmailAddresses.Type")
                    .Include(x => x.PhoneNumbers)
                    .Include("PhoneNumbers.Type")
                    .ToList();

                results = response.Select(x => x.ToModel(true)).ToList();
            }

            return results;
        }

        public CustomerModel Get(long id)
        {
            var results = new CustomerModel();

            using (var context = ContextContainer.Context)
            {
                var response = context.Customers
                    .Include(x => x.Addresses)
                    .Include("Addresses.Type")
                    .Include(x => x.EmailAddresses)
                    .Include("EmailAddresses.Type")
                    .Include(x => x.PhoneNumbers)
                    .Include("PhoneNumbers.Type")
                    .Include(x => x.Orders)
                    .Include("Orders.Status")
                    .Include("Orders.OrderItems")
                    .Include("Orders.OrderItems.MenuItem")
                    .FirstOrDefault(x => x.Id == id);

                results = response.ToModel();
            }

            return results;
        }

        public long Add(CustomerModel model)
        {
            long result;

            using(var context = ContextContainer.Context)
            {
                var domain = model.ToDomain();

                context.Customers.Add(domain);
                context.SaveChanges();

                result = domain.Id;
            }

            return result;
        }

        public bool Update(CustomerModel model)
        {
            bool result;

            using (var context = ContextContainer.Context)
            {
                var domain = context
                    .Customers
                    .FirstOrDefault(x => x.Id == model.Id);

                domain = model.ToDomain(domain);

                context.Customers.Add(domain);
                result = context.SaveChanges() > 0;
            }

            return result;
        }
    }

    public class OrderRepository : IOrderRepository
    {
        public List<OrderModel> Search(
            long? menuId = null, 
            long? customerId = null, 
            long? deliveryAddressId = null, 
            long? contactEmailId = null, 
            long? contactPhoneId = null, 
            long? stausId = null)
        {
            var results = new List<OrderModel>();

            using (var context = ContextContainer.Context)
            {
                var response = context.Orders
                    .Where(x => !menuId.HasValue || x.MenuId == menuId)
                    .Where(x => !menuId.HasValue || x.MenuId == menuId)
                    .Where(x => !menuId.HasValue || x.MenuId == menuId)
                    .Where(x => !menuId.HasValue || x.MenuId == menuId)
                    .Where(x => !menuId.HasValue || x.MenuId == menuId)
                    .Where(x => !menuId.HasValue || x.MenuId == menuId)
                    .Include(x => x.Status)
                    .Include(x => x.OrderItems)
                    .Include("OrderItems.MenuItem")
                    .ToList();

                results = response.Select(x => x.ToModel(true)).ToList();
            }

            return results;
        }

        public OrderModel Get(long id)
        {
            var results = new OrderModel();

            using (var context = ContextContainer.Context)
            {
                var response = context.Orders
                    .Include(x => x.Status)
                    .Include(x => x.OrderItems)
                    .Include("OrderItems.MenuItem")
                    .FirstOrDefault(x => x.Id == id);

                results = response.ToModel();
            }

            return results;
        }

        public long Add(OrderModel model)
        {
            long result;

            using (var context = ContextContainer.Context)
            {
                var domain = model.ToDomain();

                context.Orders.Add(domain);
                context.SaveChanges();

                result = domain.Id;
            }

            return result;
        }

        public bool Update(OrderModel model)
        {
            bool result;

            using (var context = ContextContainer.Context)
            {
                var domain = context
                    .Orders
                    .FirstOrDefault(x => x.Id == model.Id);

                domain = model.ToDomain(domain);

                context.Orders.Add(domain);
                result = context.SaveChanges() > 0;
            }

            return result;
        }
    }

    //TODO: Finish below repos
    public class MenuRepository : IMenuRepository
    {
        public List<CustomerModel> Search(string firstName, string middleName, string lastName, string suffix)
        {
            var results = new List<CustomerModel>();

            using (var context = ContextContainer.Context)
            {
                var response = context.Customers
                    .Where(x => string.IsNullOrEmpty(firstName) || x.FirstName == firstName)
                    .Where(x => string.IsNullOrEmpty(middleName) || x.MiddleName == middleName)
                    .Where(x => string.IsNullOrEmpty(lastName) || x.LastName == lastName)
                    .Where(x => string.IsNullOrEmpty(suffix) || x.Suffix == suffix)
                    .Include(x => x.Addresses)
                    .Include("Addresses.Type")
                    .Include(x => x.EmailAddresses)
                    .Include("EmailAddresses.Type")
                    .Include(x => x.PhoneNumbers)
                    .Include("PhoneNumbers.Type")
                    .ToList();

                results = response.Select(x => x.ToModel(true)).ToList();
            }

            return results;
        }

        public CustomerModel Get(long id)
        {
            var results = new CustomerModel();

            using (var context = ContextContainer.Context)
            {
                var response = context.Customers
                    .Include(x => x.Addresses)
                    .Include("Addresses.Type")
                    .Include(x => x.EmailAddresses)
                    .Include("EmailAddresses.Type")
                    .Include(x => x.PhoneNumbers)
                    .Include("PhoneNumbers.Type")
                    .Include(x => x.Orders)
                    .Include("Orders.Status")
                    .Include("Orders.OrderItems")
                    .Include("Orders.OrderItems.MenuItem")
                    .FirstOrDefault(x => x.Id == id);

                results = response.ToModel();
            }

            return results;
        }

        public long Add(CustomerModel model)
        {
            long result;

            using (var context = ContextContainer.Context)
            {
                var domain = model.ToDomain();

                context.Customers.Add(domain);
                context.SaveChanges();

                result = domain.Id;
            }

            return result;
        }

        public bool Update(CustomerModel model)
        {
            bool result;

            using (var context = ContextContainer.Context)
            {
                var domain = context
                    .Customers
                    .FirstOrDefault(x => x.Id == model.Id);

                domain = model.ToDomain(domain);

                context.Customers.Add(domain);
                result = context.SaveChanges() > 0;
            }

            return result;
        }
    }

    public class MealRepository : IMealRepository
    {
        public List<CustomerModel> Search(string firstName, string middleName, string lastName, string suffix)
        {
            var results = new List<CustomerModel>();

            using (var context = ContextContainer.Context)
            {
                var response = context.Customers
                    .Where(x => string.IsNullOrEmpty(firstName) || x.FirstName == firstName)
                    .Where(x => string.IsNullOrEmpty(middleName) || x.MiddleName == middleName)
                    .Where(x => string.IsNullOrEmpty(lastName) || x.LastName == lastName)
                    .Where(x => string.IsNullOrEmpty(suffix) || x.Suffix == suffix)
                    .Include(x => x.Addresses)
                    .Include("Addresses.Type")
                    .Include(x => x.EmailAddresses)
                    .Include("EmailAddresses.Type")
                    .Include(x => x.PhoneNumbers)
                    .Include("PhoneNumbers.Type")
                    .ToList();

                results = response.Select(x => x.ToModel(true)).ToList();
            }

            return results;
        }

        public CustomerModel Get(long id)
        {
            var results = new CustomerModel();

            using (var context = ContextContainer.Context)
            {
                var response = context.Customers
                    .Include(x => x.Addresses)
                    .Include("Addresses.Type")
                    .Include(x => x.EmailAddresses)
                    .Include("EmailAddresses.Type")
                    .Include(x => x.PhoneNumbers)
                    .Include("PhoneNumbers.Type")
                    .Include(x => x.Orders)
                    .Include("Orders.Status")
                    .Include("Orders.OrderItems")
                    .Include("Orders.OrderItems.MenuItem")
                    .FirstOrDefault(x => x.Id == id);

                results = response.ToModel();
            }

            return results;
        }

        public long Add(CustomerModel model)
        {
            long result;

            using (var context = ContextContainer.Context)
            {
                var domain = model.ToDomain();

                context.Customers.Add(domain);
                context.SaveChanges();

                result = domain.Id;
            }

            return result;
        }

        public bool Update(CustomerModel model)
        {
            bool result;

            using (var context = ContextContainer.Context)
            {
                var domain = context
                    .Customers
                    .FirstOrDefault(x => x.Id == model.Id);

                domain = model.ToDomain(domain);

                context.Customers.Add(domain);
                result = context.SaveChanges() > 0;
            }

            return result;
        }
    }
}
