using BookStore.BL.Interfaces;
using BookStore.BL.Services;
using BookStore.Models.Models.Requests;
using BookStore.Models.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryServices _libraryServices;
        
        public LibraryController(ILibraryServices libraryServices)
        {
            _libraryServices = libraryServices;
        }

        [HttpPost("GetBooksByAuthor")]
        public GetBooksByAuthorResponses? GetBooksByAuthor(GetBookByAuthorRequest request)
        {
            return _libraryServices.GetBooksByAuthor(request);    
         }

            

    }
}
