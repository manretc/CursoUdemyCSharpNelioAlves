using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoVetores {
    class Quarto {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int NumQuarto { get; private set; }

        public Quarto(string nome, string email, int numquarto) {
            Nome = nome;
            Email = email;
            NumQuarto = numquarto;
        }

        public override string ToString() {
            return NumQuarto + ": "
                + Nome + ", "
                + Email;
        }


    }
}
