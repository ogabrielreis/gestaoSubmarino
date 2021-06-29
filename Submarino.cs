using System;

namespace Submarino {


    public class Submarino {
        private int IdSubmarino;
        private string NomeSubmarino;
        private string MissaoSubmarino;
        private string DataUltimaMissao;
        private int DiaMissao;
        private int MesMissao;
        private int AnoMissao;

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

        public static void IdSubmarino(int idSubmarino) {
            IdSubmarino = idSubmarino;
        }
        public static void NomeSubmarino(string nomeSubmarino) {
            NomeSubmarino = nomeSubmarino;
        }

        public static void MissaoSubmarino(string missaoAtual) {
            MissaoSubmarino = missaoAtual;
        }

        public static void DataUltimaMissao(int d, int m, int a) {
            DataUltimaMissao = d+"/"+m+"/"+a;
        }

    }
}