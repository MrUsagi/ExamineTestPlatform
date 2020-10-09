using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.ModelsUI
{
    public class TestUI
    {
        public TestUI()
        {
            Users = new List<UserTestUI>();
            Questions = new List<QuestionUI>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TryNumber { get; set; }
        public IEnumerable<UserTestUI> Users { get; set; }
        public IEnumerable<QuestionUI> Questions { get; set; } 
    }
}
