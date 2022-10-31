using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        //public NomComplet NomComplet { get; set; }
        public string Street { get; set; }
        public int House_nb { get; set; }
        public string Zip_code { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
