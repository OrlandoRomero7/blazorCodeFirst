using BlazorCRUDEFCodeFirst.Models;

namespace BlazorCRUDEFCodeFirst.Data
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBook();
        Task<Book> GetBookDetails(int id);
        Task<int> InsertBook(Book book);
        Task<bool> UpdateBook(Book book);
        Task<bool> DeleteBook(int id);
        Task<int> SaveBook(Book book);
    }
}
