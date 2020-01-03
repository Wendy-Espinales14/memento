using System;
using System.Collections.Generic;
using System.Text;

namespace memento2.clases
{
    public class caretaker
    {
        private List<Memento> Estados = new List<Memento>();
        public void addMemento(Memento m)
        {
            Estados.Add(m);
        }
        public Memento getMemento(int index) {
            return Estados[index];

        }


    }
}
