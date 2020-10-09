using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.ModelsUI
{
    public class UserTestUI
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserUI User { get; set; }
        public int TestId { get; set; }
        public TestUI Test { get; set; }
        public int Result { get; set; }
    }
}
