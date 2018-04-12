using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HumanStructure
{
    public class TruckInfo
    {
        [Key]
        public int TruckInfoId { get; set; }
        public string TruckNumbers { get; set; }
        public string TruckModel { get; set; }

        [ForeignKey("TheFirm")]
        public int TheFirmId { get; set; }
        public virtual TheFirm TheFirm { get; set; }
        [ForeignKey("Human")]
        public int HumanId { get; set; }
        public virtual ICollection<Human> Human { get; set; } = new List<Human>();
        
    }
}
