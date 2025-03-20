using BookapiMinimal.Contracts;

namespace BookapiMinimal.Interfaces;
public interface IBookService
{
    Task<BookResponse> AddBookAsync(CreateBookRequest createBookRequest);
    Task<BookResponse> GetBookByIdAsync(Guid id);
    Task<IEnumerable<BookResponse>> GetBooksAsync();
    Task<BookResponse> UpdateBookAsync(Guid id, UpdateBookRequest updateBookRequest);
    Task<bool> DeleteBookAsync(Guid id);
}