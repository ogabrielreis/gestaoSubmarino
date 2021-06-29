using System;

namespace User {


    public class Usuario {
        //Variables
        private int IdUsuario;
        private string NomeUsuario;
        private string EmailUsuario;
        private string PasswordUsuario;

        //Get Variables
        public int getIdUsuario() {
            return IdUsuario;
        }
    
        public string getNomeUsuario() {
            return NomeUsuario;
        }

        public string getEmailUsuario() {
            return EmailUsuario;
        }

        //Set Variables
        public void setIdUsuario(int idUsuario) {
            IdUsuario = idUsuario; 
        }

        public void setNomePatente(string nomeUsuario) {
            NomeUsuario = nomeUsuario;
        }

        public void setEmailUsuario(string emailUsuario) {
            EmailUsuario = emailUsuario;
        }

        public void setPasswordUsuario(string passwordUsaruio) {
            PasswordUsuario = passwordUsaruio;
        }
    }

}