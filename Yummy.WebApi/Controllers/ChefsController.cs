using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using Yummy.WebApi.Context;
using Yummy.WebApi.Entity;

namespace Yummy.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
        private readonly ApiContext _apiContext;

        public ChefsController(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        [HttpGet]
        public IActionResult GetChefList()
        {
            var values = _apiContext.Chefs.ToList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult CreateChef(Chef chef)
        {
            _apiContext.Chefs.Add(chef);
            _apiContext.SaveChanges();
            return Ok("Şef Eklendi...");
        }
        [HttpDelete]
        public IActionResult DeleteChef(int id)
        {
            var values = _apiContext.Chefs.Find(id);
            _apiContext.Chefs.Remove(values);
            _apiContext.SaveChanges();
            return Ok("Şef Silindi...");
        }
        [HttpGet("GetChef")]
        public IActionResult GetChef(int id)
        {
            return Ok(_apiContext.Chefs.Find(id));
        }

        [HttpPut]
        public IActionResult UpdateChef(Chef chef)
        {
            _apiContext.Chefs.Update(chef);
            _apiContext.SaveChanges();
            return Ok("Şef Güncellendi...");
        }
    }
}
