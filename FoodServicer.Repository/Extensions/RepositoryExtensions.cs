using FoodServicer.Data.Entities;
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

                //if(!isSummary && domain.Orders != null && domain.Orders.Any())
                //{
                //    model.Orders = domain.Orders.Select(x => x.ToModel()).ToList();
                //}
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

        //TODO: Add Orders Extensions

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

                //if (model.Orders != null && model.Orders.Any())
                //{
                //    domain.Orders = model.Orders.Select(x => x.ToDomain()).ToList();
                //}
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
                    domain.Type = model.Type.ToDomain(domain.Type);
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
                    domain.Type = model.Type.ToDomain(domain.Type);
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
                    domain.Type = model.Type.ToDomain(domain.Type);
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

        #endregion
    }
}
