using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.DAL.Data.Entities
{
    [Index(nameof(Email), nameof(Username), IsUnique = true)]
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Username { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }



        [Required]
        public byte[] Security { get; private set; }
        [Required]
        public byte[] SecurityLayer { get; private set; }



        public void EncryptPassword(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                SecurityLayer = hmac.Key;
                Security = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public bool CompareEncryptedPassword(string password)
        {
            using (var hmac = new HMACSHA512(SecurityLayer))
            {
                var _hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < _hash.Length; i++)
                {
                    if (_hash[i] != Security[i])
                        return false;
                }
            }
            return true;
        }
    }
}
