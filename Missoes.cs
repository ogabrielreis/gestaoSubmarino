using System;

class Missao {
    // Variables
    private int IdMissao;
    private string LocalMissao;
    private string TempoMissao;
    private string DataExpedicao;

    // Get Variables
    public int getIdMissao() {
        return IdMissao;
    }

    public string getLocalMissao() {
        return LocalMissao;
    }

    public string getTempoMissao() {
        return TempoMissao;
    }

    public string getDataExpedicao() {
        return DataExpedicao;
    }

    // Set Variables
    public static void setIdMissao(int idMissao) {
        IdMissao = idMissao;
    }
    
    public static void setLocalMissao(string localMissao) {
        LocalMissao = localMissao;
    }

    public static void setTempoMissao(string tempoMissao) {
        TempoMissao = tempoMissao;
    }

    public static void setDataExpedicao(string dataExpedicao) {
        DataExpedicao = dataExpedicao;
    }
}