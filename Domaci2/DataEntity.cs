using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Domaci2
{
    public class DataEntity : DbContext
    {
        // Your context has been configured to use a 'DataEntity' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Domaci2.DataEntity' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DataEntity' 
        // connection string in the application configuration file.
        public DataEntity()
            : base("name=DataEntity")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Klijent> klijenti { get; set; }
        public virtual DbSet<Servis> servisi { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class Klijent
    {

        [Key]
        [Required]
        public int klijentID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unesite ime"), MaxLength(40)]
        public string nazivKlijenta { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unesite registarski broj"), MaxLength(20)]
        public string registarskiBroj { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unesite kontakt"), MaxLength(40)]
        public string Kontakt { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "Unesite dodatni komentar"), MaxLength(200)]
        public string dodatniKomentar { get; set; }

        //public virtual ICollection<Servis> servisi { get; set; }
    }

    public class Servis
    {

        [Key]
        [Required]
        public int servisID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unesite klijenta")]
        public int klijentID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unesite datum")]
        public DateTime datumServisa { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unesite opis usluge"), MaxLength(400)]
        public string opisUsluge { get; set; }

        //public Klijent klijent { get; set; }
    }

}