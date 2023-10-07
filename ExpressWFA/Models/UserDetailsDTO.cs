using ExpressWFA.Shared.Types;
using System;

namespace ExpressWFA.Models
{
    public class UserDetailsDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public bool? IsEmployed { get; set; }
        public MartialStatus? MartialStatus { get; set; }
        public string Birthplace { get; set; }
        public string Username { get; set; }
        public int ApplicationRoleId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}