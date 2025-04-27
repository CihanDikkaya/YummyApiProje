using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.WebApi.Context;
using Yummy.WebApi.DTOS.ContactDTO;
using Yummy.WebApi.Entity;

namespace Yummy.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ApiContext _context;

        public ContactController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _context.Contacts.ToList();
            return Ok(values);
        }
        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var va = _context.Contacts.Find(id);
            return Ok(va);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDTO createContactDTO)
        {
            Contact contact = new Contact();
            contact.Email = createContactDTO.Email;
            contact.Address = createContactDTO.Address;
            contact.Phone = createContactDTO.Phone;
            contact.Location = createContactDTO.Location;
            contact.OpenHours = createContactDTO.OpenHours;
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return Ok("Ekleme başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var va = _context.Contacts.Find(id);
            _context.Contacts.Remove(va);
            _context.SaveChanges();
            return Ok("Silme başarılı");
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDTO updateContactDTO)
        {
            Contact contact = new Contact();
            contact.Email = updateContactDTO.Email;
            contact.Address = updateContactDTO.Address;
            contact.Phone = updateContactDTO.Phone;
            contact.Location = updateContactDTO.Location;
            contact.ContactID = updateContactDTO.ContactID;
            contact.OpenHours = updateContactDTO.OpenHours;
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return Ok("Güncelleme başarılı");
        }
    }
}
