using System;

namespace Pat {
    public class Patente {
        //Variables;
        private int IdPatente;
        private string NomePatente;

        //Get Variables;
        public int getIdPatente() {
            return IdPatente;
        }

        public string getNomePatente() {
            return NomePatente;
        }

        //Set Variables;
        public void setIdPatente(int idPatente) {
            IdPatente = idPatente;
        }

        public void setNomePatente(string nomePatente) {
            NomePatente = nomePatente;
        }
    }
}