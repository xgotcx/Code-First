namespace NewHuman
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using HumanStructure;

    public class HumanModelContext : DbContext
    {
       
        public HumanModelContext()
            : base("name=HumanModel")
        {
        }
      
        public virtual DbSet<Human> Humans { get; set; }
        public virtual DbSet<TheFirm> TheFirms { get; set; }
        public virtual DbSet<TruckInfo> TruckInfos { get; set; }
        public virtual DbSet<Country> Countries { get; set; }


    }
   
}