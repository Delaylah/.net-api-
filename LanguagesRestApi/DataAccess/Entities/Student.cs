using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    [Table("student")]
    public class Student
    {
        public string AdresaBoravista { get; set; }

        public DateTime DatumRodjenja { get; set; }

        public string EMail { get; set; }

        public int Id { get; set; }

        public string Ime { get; set; }

        public string KorisnickoIme { get; set; }

        public string Jmbg { get; set; }

        public string MjestoRodjenja { get; set; }

        public string Prezime { get; set; }

        public string Sifra { get; set; }
    }
}
