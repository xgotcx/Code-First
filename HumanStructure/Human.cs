using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanStructure
{
    public class Human
    {
        [Key]
        public int HumanId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string NameOfFirm { get; set; }

        [ForeignKey("TheFirm")]
        public int TheFirmId { get; set; }
        public virtual TheFirm TheFirm { get; set; }
    }
}
