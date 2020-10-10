using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace DataAccess.Models
{
    [DataContract]
    public class UserTest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int UserId { get; set; }
        public User User { get; set; }
        [DataMember]
        public int TestId { get; set; }
        public Test Test { get; set; }
        [DataMember]
        public int Result { get; set; }
    }
}
