using System;

namespace Dorm {
    class Dormitorio {
        // Variables
        private int IdDormitorio;
        private int QtdLivreDormitorio;
        private int QtdTotalDormitorio;

        // Get Variables
        public int getIdDormitorio() {
            return IdDormitorio;
        }

        public int getQtdLivreDormitorio() {
            return QtdLivreDormitorio;
        }

        public int getQtdTotalDormitorio() {
            return QtdTotalDormitorio;
        }

        // Set Variables
        public void setIdDormitorio(int idDormitorio) {
            IdDormitorio = idDormitorio; 
        }

        public void setQtdLivreDormitorio(int qtdLivreDormitorio) {
            QtdLivreDormitorio = qtdLivreDormitorio;
        }

        public void setQtdTotalDormitorio(int qtdTotalDormitorio) {
            QtdTotalDormitorio = qtdTotalDormitorio;
        }
    }
}