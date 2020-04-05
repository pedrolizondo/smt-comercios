using System;
using System.Collections.Generic;

namespace SMT.Comercios.API.Models
{
    public partial class Store
    {
        public int Id { get; set; }
        public string Cuit { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cellphone { get; set; }
        public string OpeningHours { get; set; }
        public bool AcceptDebit { get; set; }
        public bool AcceptCredit { get; set; }
        public int? CategoryId { get; set; }
    }
}
