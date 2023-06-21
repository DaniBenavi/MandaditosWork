namespace Domain.Customers;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(CustomerId id);
    Task<bool> Update(Customer customer);
    Task Add(Customer customer);
}