using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class User
    {
        public User()
        {
            Tests = new List<UserTest>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public int LoginId { get; set; }
        public LoginUser Login { get; set; }
        public IEnumerable<UserTest> Tests { get; set; }
    }
}
