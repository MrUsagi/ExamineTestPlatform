using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Test
    {
        public Test()
        {
            Users = new List<UserTest>();
            Questions = new List<Question>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public IEnumerable<UserTest> Users { get; set; }
        public IEnumerable<Question> Questions { get; set; } 
    }
}
