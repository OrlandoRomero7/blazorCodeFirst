using BlazorCRUDEFCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDEFCodeFirst.Data
{
    public class BookService : IBookService
    {
        private readonly MybooksContext _context;
        public BookService(MybooksContext context) 
        { 
            _context = context; 
        }

        public async Task<bool> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            // la base de datos. la tabla. 
            _context.Books.Remove(book);

            return await _context.SaveChangesAsync() > 0;
                // mayor a 0 por que estamos usaand bool, estoy siguiendo un ejemplo,
                //no creo que see necesario ese tipo de dato
        }

        public async Task<IEnumerable<Book>> GetAllBook()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetBookDetails(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task<int> InsertBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book.BookId;
        }

        public async Task<int> SaveBook(Book book)
        {
            if (book.BookId > 0)
            {
                bool isUpdated = await UpdateBook(book);
                return isUpdated ? book.BookId : 0;
            }
            else
            {
                return await InsertBook(book);
            }
        }

        public async Task<bool> UpdateBook(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
