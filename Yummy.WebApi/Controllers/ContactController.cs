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

        public IActionResult ContactList()
        {
            var val = _context.Contacts.ToList();
            return Ok(val);
        }
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
            return Ok("Ekleme İşlemi Başarılı");
        }
    }
