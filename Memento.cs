using System;
using System.Collections.Generic;
using System.Text;

namespace memento2.clases
{
    public class Memento
    {
        private string  estado;

        public  string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public Memento(string Estado)
        {
            this.Estado = Estado;
        }
        public string getsavedstate()
        {
            return Estado;
        }

    }
}
