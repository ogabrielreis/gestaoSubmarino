using System;

namespace Patente {
    public class Patente {
        //Variables;
        private int IdPatente;
        private string NomePatente;

        //Get Variables;
        public string getIdPatente() {
            return IdPatente;
        }

        public string getNomePatente() {
            return NomePatente;
        }

        //Set Variables;
        public static void setIdPatente(int idPatente) {
            idPatente = idPatente;
        }

        public static void setNomePatente(string nomePatente) {
            NomePatente = nomePatente;
        }
    }
}