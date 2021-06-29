using System;

namespace It {
    public class Item {
        // Variables
        private int IdItem;
        private string NomeItem;
        private int QtdItem;
        private int VidaUtilItem;
        private int IdadeItem;

        // Get Variables
        public int getIdItem(){
            return IdItem;
        }

        public string getNomeItem(){
            return NomeItem;
        }
        public int getQtdItem(){
            return QtdItem;
        }
        public int getVidaUtilItem(){
            return VidaUtilItem;
        }
        public int getIdadeItem(){
            return IdadeItem;
        }

        public void setIdItem(int idItem) {
            IdItem = idItem;
        }

        public void setNomeItem(string nomeItem) {
            NomeItem = nomeItem;
        }

        public void setQtdItem(int qtdItem) {
            QtdItem = qtdItem;
        }
        
        public void setVidaUtilItem(int vidaUtilItem) {
            VidaUtilItem = vidaUtilItem;
        }

        public void setIdadeItem(int idadeItem) {
            IdadeItem = idadeItem;
        }
    }
}