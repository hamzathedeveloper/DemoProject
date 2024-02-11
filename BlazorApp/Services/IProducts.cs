using BlazorApp.Models;
using Refit;

namespace BlazorApp.Services
{
    public interface IProducts
    {
        [Post("/Product/UpdateProduct")]
        Task<IEnumerable<Product>> GetAllProducts(RequestProductDTO Req);
    }
}
