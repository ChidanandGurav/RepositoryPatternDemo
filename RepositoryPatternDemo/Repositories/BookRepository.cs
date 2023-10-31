using RepositoryPatternDemo.Data;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repositories
{
    public class BookRepository : IBookRepository
    {
        ApplicationDbContext db;
        public BookRepository(ApplicationDbContext db) // DI pattern inject dependency in constructor.
        {
            this.db = db;
        }
        int IBookRepository.AddBook(Book book)
        {
            db.Books.Add(book);
            // SaveChages() reflect the changes from Dbset to DB
            int result = db.SaveChanges();
            return result;
        }

        int IBookRepository.DeleteBook(int id)
        {
            int res = 0;
            var result = db.Books.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.Books.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

        Book IBookRepository.GetBookbyId(int id)
        {
            var result = db.Books.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }

        IEnumerable<Book> IBookRepository.GetBooks()
        {
            return db.Books.ToList();
        }

        int IBookRepository.UpdateBook(Book book)
        {
            int res = 0;


            var result = db.Books.Where(x => x.Id == book.Id).FirstOrDefault();

            if (result != null)
            {
                result.Name = book.Name; // book contains new data, result contains old data
                result.Author = book.Author;
                result.Price = book.Price;

                res = db.SaveChanges();// update those changes in DB
            }

            return res;
        }
    }
}
