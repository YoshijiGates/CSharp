using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private List<Models.Book> _lst;
        public BooksController()
        {
            _lst = new List<Models.Book>();
            _lst.Add(new Models.Book { id = 1, title = "title1", price = 100, page = 10 });
            _lst.Add(new Models.Book { id = 2, title = "title2", price = 200, page = 20 });
            _lst.Add(new Models.Book { id = 3, title = "title3", price = 300, page = 30 });
            _lst.Add(new Models.Book { id = 4, title = "title4", price = 400, page = 40 });
            _lst.Add(new Models.Book { id = 5, title = "title5", price = 500, page = 50 });
        }

        // GET: api/Books
        [HttpGet]
        public IEnumerable<Models.Book> Get()
        {
            return _lst;
        }


        // GET: api/Books/5
        [HttpGet("{id}", Name = "Get")]
        public Models.Book Get(int id)
        {
            return _lst.FirstOrDefault(x => x.id == id);
        }

        // POST: api/Books
        [HttpPost]
        public string Post([FromBody] Models.Book value)
        {
            return string.Format("post title:{0}", value.title);
        }

        // Put: api/Books/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            // do nothing
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // do nothing
        }
    }
}
