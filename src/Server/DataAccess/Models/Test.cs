using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace DataAccess.Models
{
    [DataContract]
    public class Test
    {
        public Test()
        {
            Users = new List<UserTest>();
            Questions = new List<Question>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int TryNumber { get; set; }
        [DataMember]
        public bool IsRemove { get; set; }
        public IEnumerable<UserTest> Users { get; set; }
        public IEnumerable<Question> Questions { get; set; } 
    }
}
