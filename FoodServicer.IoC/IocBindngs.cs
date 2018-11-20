using FoodServicer.Library.Implementations.Managers;
using FoodServicer.Library.Implementations.ModelBuilders;
using FoodServicer.Library.Implementations.Processors;
using FoodServicer.Library.Implementations.Validators;
using FoodServicer.Library.Implementations.ViewModelBuilders;
using FoodServicer.Library.Interfaces;
using FoodServicer.Repository.Implementations;
using FoodServicer.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FoodServicer.IoC
{
    public class IocBindngs
    {
        public void Bind(IServiceCollection services)
        {
            #region Library

            //Managers
            services.AddScoped<ICustomerSearchManager, CustomerSearchManager>();

            //ViewModelBuilders
            services.AddScoped<ICustomerTableViewModelBuilder, CustomerTableViewModelBuilder>();

            //ModelBuilders
            services.AddScoped<ICustomerSearchModelBuilder, CustomerSearchModelBuilder>();

            //Validators
            services.AddScoped<ICustomerSearchViewModelValidator, CustomerSearchViewModelValidator>();

            //Processors
            services.AddScoped<ICustomerSearchProcessor, CustomerSearchProcessor>();

            #endregion

            #region Repository

            //Repositories
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            #endregion
        }
    }
}
