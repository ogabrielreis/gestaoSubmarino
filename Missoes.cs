using System;

namespace Mis {

    public class Missao {

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
        public void setIdMissao(int idMissao) {
            IdMissao = idMissao;
        }
    
        public void setLocalMissao(string localMissao) {
            LocalMissao = localMissao;
        }

        public void setTempoMissao(string tempoMissao) {
            TempoMissao = tempoMissao;
        }

        public void setDataExpedicao(int d, int m, int a) {
            DataExpedicao = d+"/"+m+"/"+a;
        }
    }
}