﻿using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer?> GetCustomer(int CustomerId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Customer?> CreateCustomer(string name, string email, string phone, string email2);
        Task<Customer?> DeleteCustomer(int customerId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Customer?> UpdateCustomer(int customerId, string name, string email, string phone, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);

        public void SaveChanges();

    }
}
