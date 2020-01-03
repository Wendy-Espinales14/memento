using System;

namespace memento2.clases
{

    class Program
    {
        static void Main(string[] args)
        {
            caretaker caretaker = new caretaker();
            Persona p = new Persona();
            p.setNombre("wendy");
            p.setNombre("jaritza");
            caretaker.addMemento(p.savetoMemento());
            p.setNombre("mishelle");
            caretaker.addMemento(p.savetoMemento());
            p.setNombre("maholy");
            Memento m1 = caretaker.getMemento(0);
            Memento m2 = caretaker.getMemento(1);
            Console.WriteLine(m1.getsavedstate());
            Console.WriteLine(m2.getsavedstate());
            Console.ReadKey();
        }
        
    }
}
