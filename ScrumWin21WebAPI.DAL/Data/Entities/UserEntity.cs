using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.DAL.Data.Entities
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; } = null!;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; } = null!;

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; } = null!;


        public int RoleId { get; set; }
        public RoleEntity Role { get; set; } = null!;

        public int AddressId { get; set; }
        public AddressEntity Address { get; set; } = null!;
    }
}
