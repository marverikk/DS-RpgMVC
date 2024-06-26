using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgMvc.Models
{
    public class PersonagemViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int PontosVida { get; set; }
        public int Disputas { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
    }
}
