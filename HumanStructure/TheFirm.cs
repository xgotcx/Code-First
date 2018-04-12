using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanStructure
{
    public class TheFirm
    {
        [Key]
        public int TheFirmId { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Address { get; set; }

        [ForeignKey("Human")]
        public int HumanId { get; set; }
        public virtual ICollection<Human> Human { get; set; } = new List<Human>();

        [ForeignKey("TruckInfo")]
        public int TruckInfoId { get; set; }
        public virtual ICollection<TruckInfo> TruckInfo { get; set; } = new List<TruckInfo>();

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public virtual ICollection<Country> Country { get; set; } = new List<Country>();
    }
}
