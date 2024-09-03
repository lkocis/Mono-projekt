using Microsoft.AspNetCore.Mvc;

namespace Introduction.WebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private static List<Author> authors = new List<Author>()
        {
            new Author("Pero", "Perić", 1234, new DateOnly(2004,2,4)),
            new Author("Ana", "Anić", 2345, new DateOnly(1994,3,3)),
            new Author("Marko", "Marić", 3456, new DateOnly(2000,4,6)),
            new Author("Ivan", "Ivanić", 4567, new DateOnly(1990,5,5))
        };

        [HttpGet]
        [Route("GetAuthorById/{id}")]
        public Author GetAuthorById(int id)
        {
            Author? selected = null;
            foreach (var author in authors)
            {
                if (author.Id == id)
                {
                    selected = author;
                    break;
                }
            }

            if (selected == null)
            {
                throw new Exception("Author not found!");
            }

            return selected;
        }

        [HttpPost]
        [Route("PostAuthor/")]
        public Author PostNewAuthor()
        {
            Author newAuthor = new Author("Mia", "Mijić", 2534, new DateOnly(2000, 7, 12));
            authors.Add(newAuthor);
            return newAuthor;
        }

        [HttpGet]
        [Route("GetAllAuthors/")]
        public List<Author> GetAllAuthors()
        {
            if (authors == null)
            {
                throw new Exception("List empty!");
            }

            return authors;
        }

        [HttpPut]
        [Route("PutAuthorById/{id}")]
        public Author PutAuthorById(int id)
        {
            Author? updated = null;
            foreach (var author in authors)
            {
                if (author.Id == id)
                {
                    author.FirstName = "";
                    updated = author;
                    break;
                }
            }

            if (updated == null)
            {
                throw new Exception("Author not found!");
            }

            return updated;
        }

        [HttpDelete]
        [Route("DeleteAuthorById/{id}")]
        public Author DeleteAuthorById(int id)
        {
            Author? deleted = null;

            foreach (var author in authors)
            {
                if (author.Id == id)
                {
                    deleted = author;
                    authors.Remove(author);
                    break;
                }
            }

            if (deleted == null)
            {
                throw new Exception("Author not found!");
            }

            return deleted;
        }
    }
}