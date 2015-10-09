using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProfNotebook.Business.Models
{
    public class Proffesor
    {
        public int ProffesorID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Ape1 { get; set; }

        [MaxLength(50)]
        public string Ape2 { get; set; }

        [MaxLength(9)]
        public string DNI { get; set; }

        public int Age { get; set; }
    }
}