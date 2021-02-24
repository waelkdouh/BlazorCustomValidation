using DynamicFormsValidation.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DynamicFormsValidation.Model
{
    public class User
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SecondName { get; set; }

        private string _contactType = "-1";
        public string ContactType
        {
            get
            {
                return _contactType;
            }
            set
            {
                _contactType = value;
            }
        }

        [DynamicContactValidationAttribute(ParentFieldName: "ContactType", FieldType: "Email", ValidationTypes: new string[] { "required","email" })]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
