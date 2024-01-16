using BookStore.BL.Services;
using BookStore.DL.Interfaces;
using BookStore.Models;
using Moq;

namespace BookStore.Test
{
    public class BookTest
    {
        public static List<Book> BookData = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Name 1",
                AuthorId = 1,
                ReleaseDate = new DateTime(2011, 11, 05)
            },
             new Book()
            {
                Id = 4,
                Title = "Name 4",
                AuthorId = 1,
                ReleaseDate = new DateTime(2015, 11, 06)
            },
             new Book()
            {
                Id = 2,
                Title = "Name 2",
                AuthorId = 2,
                ReleaseDate = new DateTime(2015, 11, 05)
            },
              new Book()
            {
                Id = 3,
                Title = "Name 3",
                AuthorId= 3,
                ReleaseDate = new DateTime(2020, 12, 05)
            }
        };


        [Fact]
        public void GetAllByAuthorId_Count_Check()
        {
            //setup
            var expectedCount = 2;
            var authorId = 1;

            var mockedBookRepository = new Mock<IBookRepository>();

            mockedBookRepository.Setup(x => x.GetAllByAuthorId(authorId))
                .Returns(BookData.Where(b => b.AuthorId == authorId).ToList());

            //inject
            var service = new BookService(mockedBookRepository.Object);

            //Act
            var result = service.GetAllByAuthorId(authorId);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());




        }

        [Fact]
        public void GetAllByAuthorId_WrongId()
        {
            //setup
            var expectedCount = 0;
            var authorId = 11;

            var mockedBookRepository = new Mock<IBookRepository>();

            mockedBookRepository.Setup(x => x.GetAllByAuthorId(authorId))
                .Returns(BookData.Where(b => b.AuthorId == authorId).ToList());

            //inject
            var service = new BookService(mockedBookRepository.Object);

            //Act
            var result = service.GetAllByAuthorId(authorId);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());




        }
        [Fact]
        public void TestCalculation_Result_Check()
        {
            //setup
            var expectedResult = 14;
            var testNumber = 10;

            var mockedBookRepository = new Mock<IBookRepository>();

            mockedBookRepository.Setup(x => x.GetAll())
                .Returns(BookData);

            //inject
            var service = new BookService(mockedBookRepository.Object);

            //Act
            var result = service.TestCalculation(testNumber);

            //Assert
            
            Assert.Equal(expectedResult, result);




        }
        [Fact]
        public void RemoveBook_Count_Check()
        {
            //setup
            var expectedResult = 3;
            var bookId = 1;
            var bookToRemove = BookData.FirstOrDefault(x => x.Id == bookId);

            var mockedBookRepository = new Mock<IBookRepository>();

            mockedBookRepository.Setup(x => x.Remove(bookId)).Callback( () =>
            {
                BookData.Remove(bookToRemove);
            });
                

            //inject
            var service = new BookService(mockedBookRepository.Object);

            //Act
            service.Remove(bookId);

            //Assert

            Assert.Equal(expectedResult, BookData.Count);




        }
    }
}

