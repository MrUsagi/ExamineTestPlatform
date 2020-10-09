using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Question
    {
        public Question()
        {
            Answers = new List<Answer>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Text { get; set; }
        public string ImageURL { get; set; }
        public bool IsManyAnswers { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
    }
}
