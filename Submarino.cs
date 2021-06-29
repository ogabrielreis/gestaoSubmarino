using System;

namespace Sub {


    public class Submarino {
        private int IdSubmarino;
        private string NomeSubmarino;
        private string MissaoSubmarino;
        private string DataUltimaMissao;
        private int DiaMissao;
        private int MesMissao;
        private int AnoMissao;

        public int getIdSubmarino() {
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

        public void setIdSubmarino(int idSubmarino) {
            IdSubmarino = idSubmarino;
        }
        public void setNomeSubmarino(string nomeSubmarino) {
            NomeSubmarino = nomeSubmarino;
        }

        public void setMissaoSubmarino(string missaoAtual) {
            MissaoSubmarino = missaoAtual;
        }

        public void setDataUltimaMissao(int d, int m, int a) {
            DataUltimaMissao = d+"/"+m+"/"+a;
        }

    }
}