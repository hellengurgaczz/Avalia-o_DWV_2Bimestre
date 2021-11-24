using System;
using System.Collections.Generic;

namespace API.Models
{
    public class FormaPagamento
    {
        public FormaPagamento() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Forma { get; set; }
        public string Desconto { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}