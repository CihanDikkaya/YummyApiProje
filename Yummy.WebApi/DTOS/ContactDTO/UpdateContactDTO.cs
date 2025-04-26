namespace Yummy.WebApi.DTOS.ContactDTO
{
    public class UpdateContactDTO
    {
        public int ContactID { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OpenHours { get; set; }
    }
}
