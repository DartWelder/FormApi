using System;
using System.Collections.Generic;

namespace FormsAPI.Models
{
    public class Field
    {
        public Guid FormId;
        
        public Guid FieldId;

        public List<Answer> Answers;
    }
}