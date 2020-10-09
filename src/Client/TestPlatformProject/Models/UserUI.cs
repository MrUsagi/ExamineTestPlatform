using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.ModelsUI
{
    public class UserUI
    {
        public UserUI()
        {
            Tests = new List<UserTestUI>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public int LoginId { get; set; }
        public LoginUserUI Login { get; set; }
        public IEnumerable<UserTestUI> Tests { get; set; }
    }
}
