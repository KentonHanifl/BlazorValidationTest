using System.ComponentModel.DataAnnotations;

namespace TestValidation.Models
{
    public class MyTestModelWithValidationAttributes
    {
        [MaxLength(10)]
        public string TestString { get; set; }
    }
}
