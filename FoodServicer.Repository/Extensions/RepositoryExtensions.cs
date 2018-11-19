﻿using FoodServicer.Data.Entities;
using FoodServicer.Model;
using System.Linq;

namespace FoodServicer.Repository.Extensions
{
    public static class RepositoryExtensions
    {
        #region ToModels

        public static CustomerModel ToModel(this Customer domain, bool isSummary = false)
        {
            var model = new CustomerModel();

            if(domain != null)
            {
                model.Id = domain.Id;
                model.FirstName = domain.FirstName;
                model.MiddleName = domain.MiddleName;
                model.LastName = domain.LastName;
                model.Suffix = domain.Suffix;

                if(domain.Addresses != null && domain.Addresses.Any())
                {
                    model.Addresses = domain.Addresses.Select(x => x.ToModel()).ToList();
                }

                if (domain.EmailAddresses != null && domain.EmailAddresses.Any())
                {
                    model.EmailAddresses = domain.EmailAddresses.Select(x => x.ToModel()).ToList();
                }

                if (domain.PhoneNumbers != null && domain.PhoneNumbers.Any())
                {
                    model.PhoneNumbers = domain.PhoneNumbers.Select(x => x.ToModel()).ToList();
                }

                if (!isSummary && domain.Orders != null && domain.Orders.Any())
                {
                    model.Orders = domain.Orders.Select(x => x.ToModel()).ToList();
                }
            }

            return model;
        }

        public static AddressModel ToModel(this Address domain)
        {
            var model = new AddressModel();

            if(domain != null)
            {
                model.Id = domain.Id;
                model.Street1 = domain.Street1;
                model.Street2 = domain.Street2;
                model.City = domain.City;
                model.State = domain.State;
                model.PostalCode = domain.PostalCode;
                model.IsPrimary = domain.IsPrimary;

                if(domain.Type != null)
                {
                    model.Type = domain.Type.ToModel();
                }
            }

            return model;
        }

        public static AddressTypeModel ToModel(this AddressType domain)
        {
            var model = new AddressTypeModel();

            if (domain != null)
            {
                model.Id = domain.Id;
                model.Type = domain.Type;
            }

            return model;
        }

        public static EmailAddressModel ToModel(this EmailAddress domain)
        {
            var model = new EmailAddressModel();

            if (domain != null)
            {
                model.Id = domain.Id;
                model.Address = domain.Address;
                model.IsPrimary = domain.IsPrimary;

                if (domain.Type != null)
                {
                    model.Type = domain.Type.ToModel();
                }
            }

            return model;
        }

        public static EmailAddressTypeModel ToModel(this EmailAddressType domain)
        {
            var model = new EmailAddressTypeModel();

            if (domain != null)
            {
                model.Id = domain.Id;
                model.Type = domain.Type;
            }

            return model;
        }

        public static PhoneNumberModel ToModel(this PhoneNumber domain)
        {
            var model = new PhoneNumberModel();

            if (domain != null)
            {
                model.Id = domain.Id;
                model.Number = domain.Number;
                model.IsPrimary = domain.IsPrimary;

                if (domain.Type != null)
                {
                    model.Type = domain.Type.ToModel();
                }
            }

            return model;
        }

        public static PhoneNumberTypeModel ToModel(this PhoneNumberType domain)
        {
            var model = new PhoneNumberTypeModel();

            if (domain != null)
            {
                model.Id = domain.Id;
                model.Type = domain.Type;
            }

            return model;
        }

        public static OrderModel ToModel(this Order domain, bool isSummary = false)
        {
            var model = new OrderModel();

            if(domain != null)
            {
                model.Id = domain.Id;
                model.MenuId = domain.MenuId;
                model.CustomerId = domain.CustomerId;
                model.DeliveryAddressId = domain.DeliveryAddressId;
                model.ContactEmailId = domain.ContactEmailId;
                model.ContactPhoneId = domain.ContactPhoneId;

                if (domain.Status != null)
                {
                    model.Status = domain.Status.ToModel();
                }

                if(!isSummary && domain.OrderItems != null && domain.OrderItems.Any())
                {
                    model.OrderItems = domain.OrderItems
                        .Select(x => x.ToModel())
                        .ToList();
                }
            }

            return model;
        }

        public static OrderStatusModel ToModel(this OrderStatus domain)
        {
            var model = new OrderStatusModel();

            if(domain != null)
            {
                model.Id = domain.Id;
                model.Status = domain.Status;
            }

            return model;
        }

        public static OrderItemModel ToModel(this OrderItem domain)
        {
            var model = new OrderItemModel();

            if(domain != null)
            {
                model.Id = domain.Id;
                model.SpecialInstructions = domain.SpecialInstructions;

                if(domain.MenuItem != null)
                {
                    model.MenuItem = domain.MenuItem.ToModel();
                }
            }

            return model;
        }

        public static MenuItemModel ToModel(this MenuItem domain)
        {
            var model = new MenuItemModel();

            if(domain != null)
            {
                model.Id = domain.Id;
                model.MealId = domain.MealId;
                model.MenuId = domain.MenuId;
                model.Price = domain.Price;
                model.Cost = domain.Cost;
            }

            return model;
        }

        #endregion

        #region ToDomains - Add

        public static Customer ToDomain(this CustomerModel model)
        {
            var domain = new Customer();

            if (model != null)
            {
                domain.Id = model.Id;
                domain.FirstName = model.FirstName;
                domain.MiddleName = model.MiddleName;
                domain.LastName = model.LastName;
                domain.Suffix = model.Suffix;

                if (model.Addresses != null && model.Addresses.Any())
                {
                    domain.Addresses = model.Addresses.Select(x => x.ToDomain()).ToList();
                }

                if (model.EmailAddresses != null && model.EmailAddresses.Any())
                {
                    domain.EmailAddresses = model.EmailAddresses.Select(x => x.ToDomain()).ToList();
                }

                if (model.PhoneNumbers != null && model.PhoneNumbers.Any())
                {
                    domain.PhoneNumbers = model.PhoneNumbers.Select(x => x.ToDomain()).ToList();
                }

                if (model.Orders != null && model.Orders.Any())
                {
                    domain.Orders = model.Orders.Select(x => x.ToDomain()).ToList();
                }
            }

            return domain;
        }

        public static Address ToDomain(this AddressModel model)
        {
            var domain = new Address();

            if (model != null)
            {
                domain.Id = model.Id;
                domain.Street1 = model.Street1;
                domain.Street2 = model.Street2;
                domain.City = model.City;
                domain.State = model.State;
                domain.PostalCode = model.PostalCode;
                domain.IsPrimary = model.IsPrimary;

                if (model.Type != null)
                {
                    domain.Type = model.Type.ToDomain();
                }
            }

            return domain;
        }

        public static AddressType ToDomain(this AddressTypeModel model)
        {
            var domain = new AddressType();

            if (model != null)
            {
                domain.Id = model.Id;
                domain.Type = model.Type;
            }

            return domain;
        }

        public static EmailAddress ToDomain(this EmailAddressModel model)
        {
            var domain = new EmailAddress();

            if (model != null)
            {
                domain.Id = model.Id;
                domain.Address = model.Address;
                domain.IsPrimary = model.IsPrimary;

                if (model.Type != null)
                {
                    domain.Type = model.Type.ToDomain();
                }
            }

            return domain;
        }

        public static EmailAddressType ToDomain(this EmailAddressTypeModel model)
        {
            var domain = new EmailAddressType();

            if (model != null)
            {
                domain.Id = model.Id;
                domain.Type = model.Type;
            }

            return domain;
        }

        public static PhoneNumber ToDomain(this PhoneNumberModel model)
        {
            var domain = new PhoneNumber();

            if (model != null)
            {
                domain.Id = model.Id;
                domain.Number = model.Number;
                domain.IsPrimary = model.IsPrimary;

                if (model.Type != null)
                {
                    domain.Type = model.Type.ToDomain();
                }
            }

            return domain;
        }

        public static PhoneNumberType ToDomain(this PhoneNumberTypeModel model)
        {
            var domain = new PhoneNumberType();

            if (model != null)
            {
                domain.Id = model.Id;
                domain.Type = model.Type;
            }

            return domain;
        }

        public static Order ToDomain(this OrderModel model)
        {
            var domain = new Order();

            if (model != null)
            {
                domain.Id = model.Id;
                domain.MenuId = model.MenuId;
                domain.CustomerId = model.CustomerId;
                domain.DeliveryAddressId = model.DeliveryAddressId;
                domain.ContactEmailId = model.ContactEmailId;
                domain.ContactPhoneId = model.ContactPhoneId;

                if (model.Status != null)
                {
                    domain.Status = model.Status.ToDomain();
                }

                if (model.OrderItems != null && model.OrderItems.Any())
                {
                    domain.OrderItems = model.OrderItems
                        .Select(x => x.ToDomain())
                        .ToList();
                }
            }

            return domain;
        }

        public static OrderStatus ToDomain(this OrderStatusModel model)
        {
            var domain = new OrderStatus();

            if (model != null)
            {
                domain.Id = model.Id;
                domain.Status = model.Status;
            }

            return domain;
        }

        public static OrderItem ToDomain(this OrderItemModel model)
        {
            var domain = new OrderItem();

            if (model != null)
            {
                domain.Id = model.Id;
                domain.SpecialInstructions = model.SpecialInstructions;

                if (model.MenuItem != null)
                {
                    domain.MenuItem = model.MenuItem.ToDomain();
                }
            }

            return domain;
        }

        public static MenuItem ToDomain(this MenuItemModel model)
        {
            var domain = new MenuItem();

            if (model != null)
            {
                domain.Id = model.Id;
                domain.MealId = model.MealId;
                domain.MenuId = model.MenuId;
                domain.Price = model.Price;
                domain.Cost = model.Cost;
            }

            return domain;
        }

        #endregion

        #region ToDomains - Update

        public static Customer ToDomain(this CustomerModel model, Customer domain)
        {
            if (model != null)
            {
                domain.Id = model.Id;
                domain.FirstName = model.FirstName;
                domain.MiddleName = model.MiddleName;
                domain.LastName = model.LastName;
                domain.Suffix = model.Suffix;

                //if (model.Addresses != null && model.Addresses.Any())
                //{
                //    domain.Addresses = model.Addresses.Select(x => x.ToDomain(domain.Addresses)).ToList();
                //}

                //if (model.EmailAddresses != null && model.EmailAddresses.Any())
                //{
                //    domain.EmailAddresses = model.EmailAddresses.Select(x => x.ToDomain(domain.EmailAddresses)).ToList();
                //}

                //if (model.PhoneNumbers != null && model.PhoneNumbers.Any())
                //{
                //    domain.PhoneNumbers = model.PhoneNumbers.Select(x => x.ToDomain(domain.PhoneNumbers)).ToList();
                //}

                //if (model.Orders != null && model.Orders.Any())
                //{
                //    domain.Orders = model.Orders.Select(x => x.ToDomain(domain.Orders)).ToList();
                //}
            }

            return domain;
        }

        public static Address ToDomain(this AddressModel model, Address domain)
        {
            if (model != null)
            {
                domain.Id = model.Id;
                domain.Street1 = model.Street1;
                domain.Street2 = model.Street2;
                domain.City = model.City;
                domain.State = model.State;
                domain.PostalCode = model.PostalCode;
                domain.IsPrimary = model.IsPrimary;
                
                if (model.Type != null)
                {
                    domain.AddressTypeId = model.Type.Id;
                }
            }

            return domain;
        }

        public static AddressType ToDomain(this AddressTypeModel model, AddressType domain)
        {
            if (model != null)
            {
                domain.Id = model.Id;
                domain.Type = model.Type;
            }

            return domain;
        }

        public static EmailAddress ToDomain(this EmailAddressModel model, EmailAddress domain)
        {
            if (model != null)
            {
                domain.Id = model.Id;
                domain.Address = model.Address;
                domain.IsPrimary = model.IsPrimary;

                if (model.Type != null)
                {
                    domain.Type.Id = model.Type.Id;
                }
            }

            return domain;
        }

        public static EmailAddressType ToDomain(this EmailAddressTypeModel model, EmailAddressType domain)
        {
            if (model != null)
            {
                domain.Id = model.Id;
                domain.Type = model.Type;
            }

            return domain;
        }

        public static PhoneNumber ToDomain(this PhoneNumberModel model, PhoneNumber domain)
        {
            if (model != null)
            {
                domain.Id = model.Id;
                domain.Number = model.Number;
                domain.IsPrimary = model.IsPrimary;

                if (model.Type != null)
                {
                    domain.Type.Id = model.Type.Id;
                }
            }

            return domain;
        }

        public static PhoneNumberType ToDomain(this PhoneNumberTypeModel model, PhoneNumberType domain)
        {
            if (model != null)
            {
                domain.Id = model.Id;
                domain.Type = model.Type;
            }

            return domain;
        }

        public static Order ToDomain(this OrderModel model, Order domain)
        {
            if (model != null)
            {
                domain.Id = model.Id;
                domain.MenuId = model.MenuId;
                domain.CustomerId = model.CustomerId;
                domain.DeliveryAddressId = model.DeliveryAddressId;
                domain.ContactEmailId = model.ContactEmailId;
                domain.ContactPhoneId = model.ContactPhoneId;

                if (model.Status != null)
                {
                    domain.Status.Id = model.Status.Id;
                }

                //if (model.OrderItems != null && model.OrderItems.Any())
                //{
                //    domain.OrderItems = model.OrderItems
                //        .Select(x => x.ToDomain())
                //        .ToList();
                //}
            }

            return domain;
        }

        public static OrderStatus ToDomain(this OrderStatusModel model, OrderStatus domain)
        {
            if (model != null)
            {
                domain.Id = model.Id;
                domain.Status = model.Status;
            }

            return domain;
        }

        public static OrderItem ToDomain(this OrderItemModel model, OrderItem domain)
        {
            if (model != null)
            {
                domain.Id = model.Id;
                domain.SpecialInstructions = model.SpecialInstructions;

                if (model.MenuItem != null)
                {
                    domain.MenuItem.Id = model.MenuItem.Id;
                }
            }

            return domain;
        }

        public static MenuItem ToDomain(this MenuItemModel model, MenuItem domain)
        {
            if (model != null)
            {
                domain.Id = model.Id;
                domain.MealId = model.MealId;
                domain.MenuId = model.MenuId;
                domain.Price = model.Price;
                domain.Cost = model.Cost;
            }

            return domain;
        }

        #endregion
    }
}
