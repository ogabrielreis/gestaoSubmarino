using System;

class Submarino {
    private int IdSubmarino;
    private string NomeSubmarino;
    private string MissaoSubmarino;
    private string DataUltimaMissao;

    public string getIdSubmarino() {
        return IdSubmarino;
    }
    public string getNomeSubmarino() {
        return NomeSubmarino;
    }
    public string getMissaoSubmarino() {
        return MissaoSubmarino;
    }

    public string getDataUltimaMissao() {
        return DataUltimaMissao;
    }

    public static void NomeSubmarino(string nomeSubmarino) {
        NomeSubmarino = nomeSubmarino;
    }

    public static void MissaoSubmarino(string missaoAtual) {
        MissaoSubmarino = missaoAtual;
    }

    public static void DataUltimaMissao(string dataMissaoAtual) {
        DataUltimaMissao = dataMissaoAtual;
    }


}