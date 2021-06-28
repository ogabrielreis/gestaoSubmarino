using System;

class Usuario {
    //Variables
    private int IdUsuario;
    private string NomeUsuario;
    private string EmailUsuario;
    private string PasswordUsuario;

    //Get Variables
    public int IdUsuario() {
        return IdUsuario;
    }
    
    public string NomeUsuario() {
        return NomeUsuario;
    }

    public string EmailUsuario() {
        return EmailUsuario;
    }

    //Set Variables
    public static void setIdUsuario(int idUsuario) {
        IdUsuario = idUsuario; 
    }

    public static void setNomePatente(string nomeUsuario) {
        NomeUsuario = nomeUsuario;
    }

    public static void setEmailUsuario(string emailUsuario) {
        EmailUsuario = emailUsuario;
    }

    public static void setPasswordUsuario(string passwordUsaruio) {
        PasswordUsuario = passwordUsaruio;
    }
}