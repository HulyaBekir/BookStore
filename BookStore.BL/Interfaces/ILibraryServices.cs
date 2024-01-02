using BookStore.Models.Models.Requests;
using BookStore.Models.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interfaces
{
    public interface ILibraryServices
    {
        public GetBooksByAuthorResponses? GetBooksByAuthor(GetBookByAuthorRequest request);

    }
}
