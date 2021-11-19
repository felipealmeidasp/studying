using System;
using System.Globalization;

namespace Studs
{
    public class Fornecedor
    {
        private int _fID = 1;
        private string _fNome = "João";
        private string _fTipo = "Limpeza";
        



        public int fID 
        {
            get { return _fID; }
            set { fID = value; }
            
        }
        public string fNome
        {
            get { return _fNome;  }
            set { _fNome = value; }
        }
        public string fTipo
        {
            get { return _fTipo; }
            set { _fTipo = value; }
        }
    }

}
