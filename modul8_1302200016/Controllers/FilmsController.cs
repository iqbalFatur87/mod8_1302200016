using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul8_1302200016.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Film>> GetFilms()
        {
           return Film.Films.ToList();
        }

		[HttpPost]
		public ActionResult<Film> TambahFilm(Film film)
		{
			Film.Films.Add(film);
			return Ok("Film telah ditambahkan");
		}

		[HttpGet]
		[Route("{id}")]
		public ActionResult<Film> GetFilm(int id)
		{
			Film film = Film.Films[id];
			return Ok(film);
		}

		[HttpDelete]
		[Route("{id}")]
		public ActionResult DeleteMovie(int id)
		{
			Film.Films.Remove(Film.Films[id]);
			return Ok("Film Sukses terhapus");
		}
	}
}
