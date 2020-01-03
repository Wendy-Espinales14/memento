using System;
using System.Collections.Generic;
using System.Text;

namespace memento2.clases
{
    class Persona
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Memento savetoMemento()
        {
            Console.WriteLine("originator:guardando memento...");
            return new Memento(nombre);
        }
        public void restoreFromMemento(Memento m)
        {
            nombre = m.getsavedstate();
        }
        public string getnombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

    }
}
