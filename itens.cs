using System;

namespace Item {
    public class Item {
        // Variables
        private int IdItem;
        private string NomeItem;
        private string QtdItem;
        private int VidaUtilItem;
        private int IdadeItem;

        // Get Variables
        public int getIdItem(){
            return IdItem;
        }

        public string getNomeItem(){
            return NomeItem;
        }
        public string getQtdItem(){
            return QtdItem;
        }
        public int getVidaUtilItem(){
            return VidaUtilItem;
        }
        public int getIdadeItem(){
            return IdadeItem;
        }
        
    }
}