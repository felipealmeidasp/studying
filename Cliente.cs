using System;
using System.Globalization;

namespace Studs
{
    public class Cliente
    {
        private string _cNome = "João";
        private int _cIdade = 26;
        private string _cSexo = "Masculino";
        private int _cID = 1;
        private string _cCidade = "São Paulo";
       


        public string cNome
        {
            get
            {
                return _cNome;
            }
            set
            {
                _cNome = value;
            }
        }
        public int cIdade
        {
            get
            {
                return _cIdade;
            }
            set
            {
                _cIdade = value;
            }
        }
        public string cSexo
        {
            get
            {
                return _cSexo;
            }
            set
            {
                _cSexo = value;
            }
        }
       public int cID
        {
            get
            {
                return _cID;
            }
            set
            {
                _cID = value;
            }
        }
        public string cCidade
        {
            get
            {
                return cCidade;
            }
            set
            {
                _cCidade = value;
            }
        }
        
    }

}
