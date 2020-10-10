using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace DataAccess.Models
{
    [DataContract]
    public class User
    {
        public User()
        {
            Tests = new List<UserTest>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FIO { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public bool IsAdmin { get; set; }
        [DataMember]
        public int LoginId { get; set; }
        public LoginUser Login { get; set; }
        public IEnumerable<UserTest> Tests { get; set; }
    }
}
