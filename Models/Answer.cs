using System;

namespace FormsAPI.Models
{
    public class Answer 
    {
        public Guid Id;
        
        public Guid QuestionId;
        
        public string Key;

        public string Value;
    }
}