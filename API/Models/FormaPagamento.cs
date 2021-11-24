using System;
using System.Collections.Generic;

namespace API.Models
{
    public class FormaPagamento
    {
        public FormaPagamento() => CriadoEm = DateTime.Now;
        public int FormaId { get; set; }
        public string Forma { get; set; }
        public string Desconto { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}