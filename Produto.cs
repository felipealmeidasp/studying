using System;
using System.Globalization;

namespace Studs
{
    public class Produto
    {
        private int _pQuant = 1;
        private string _pNome = "Televisão";
        private double _pPreco = 1500.00;
        public void SetpNome(string pnome, Produto p)
        {
            
        }
        public double pPreco
        {
            get { return _pPreco; }
            set
            {
                _pPreco = value;
            }
        }

        public int pQuant
        {
            get { return _pQuant; }
            set
            {
                _pQuant = value;
            }
        }

        public string pNome
        {
            get { return pNome;  }
            set
            {
                _pNome = value;
            }
        }

        public double pTotal
        {
            get { return pPreco * pTotal; }
            set { }
        }

    }
    
}
