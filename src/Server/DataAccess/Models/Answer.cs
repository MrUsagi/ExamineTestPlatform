using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace DataAccess.Models
{
    [DataContract]
    public class Answer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public bool IsCorrect { get; set; }
        [DataMember]
        public bool IsRemove { get; set; }
    }
}
