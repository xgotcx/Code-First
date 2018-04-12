using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanStructure
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        public string CountryName { get; set; }

        [ForeignKey("TheFirm")]
        public int TheFirmId { get; set; }
        public virtual ICollection<TheFirm> TheFirm { get; set; } = new List<TheFirm>();
    }
}
