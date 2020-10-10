using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace DataAccess.Models
{
    [DataContract]
    public class Question
    {
        public Question()
        {
            Answers = new List<Answer>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public string ImageURL { get; set; }
        [DataMember]
        public bool IsManyAnswers { get; set; }
        [DataMember]
        public int Weight { get; set; }
        [DataMember]
        public bool IsRemove { get; set; }
        [DataMember]
        public int TestId { get; set; }
        public Test Test { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
    }
}
