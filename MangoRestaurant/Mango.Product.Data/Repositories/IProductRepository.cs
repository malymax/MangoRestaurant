namespace Mango.Product.Data.RA
{
    public interface IProductRepository
    {
        public Task AddAsync(Models.Product item);
        public Task UpdateAsync(Models.Product item);
        public Task DeleteAsync(int id);
        public Task<Models.Product> GetAsync(int id);
    }
}
