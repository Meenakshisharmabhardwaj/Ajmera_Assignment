using WebApplicationCoreWebApi.Models;
using WebApplicationCoreWebApi.Models.RequestModels;

namespace WebApplicationCoreWebApi.Business_Layer.Interfaces
{
    public interface IBooks_DAL
    {
        Task<List<Books>> Get();
        Task<int> Post(BookModel books);
        Task<Books> GetById(Guid guid);
    }
}
