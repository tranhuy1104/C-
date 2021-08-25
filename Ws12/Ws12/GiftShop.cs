using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ws12
{
    public delegate void Display(string valueOne, int valueTwo);
    class GiftShop
    {
        private string[] giftItems = { "Greeting Card", "Puzzle Game", "Toy" };
        private float[] pricePerUnit = { 10.20F, 25.12F, 50.78F };
        private int _itemNumber;
        private int _itemName;
        private int _itemSold;
        private double _totalValue;
        private int _availableStock;
        public event Display Print;
        public bool AcceptDetails()
        {
            GiftStock giftStock = new GiftStock();
        }
    }
}
