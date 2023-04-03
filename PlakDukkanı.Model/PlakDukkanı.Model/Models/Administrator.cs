using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkanı.Model.Models
{
    public class Administrator
    {
        public int AdministratorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        [MinLength(8,ErrorMessage = " Lütfen en az 8 karakter giriniz! ")]
        public string Password { get; private set; }

        public void SetPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                Password = Convert.ToBase64String(hashedBytes);
            }
        }

        public bool VerifyPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hash = Convert.ToBase64String(hashedBytes);
                return Password == hash;
            }
        }
    }
}
