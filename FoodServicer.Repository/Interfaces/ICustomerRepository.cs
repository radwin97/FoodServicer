﻿using FoodServicer.Model;
using System.Collections.Generic;

namespace FoodServicer.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        List<CustomerModel> Search(string firstName, string middleName, string lastName, string suffix);
        CustomerModel Get(long id);
        long Add(CustomerModel model);
        bool Update(CustomerModel model);
    }
}
