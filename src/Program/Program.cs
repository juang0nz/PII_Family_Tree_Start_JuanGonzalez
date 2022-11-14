using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person ("Juan",33);
            Person p2 = new Person ("Pedro",40);
            Person p3 = new Person ("Agustina",50);
            Person p4 = new Person ("Maria",60);
            Person p5 = new Person ("Laura",5);
            Person p6 = new Person ("Facundo",20);
            Person p7 = new Person ("Anthony",20);
            Person p8 = new Person ("Amadeo",20);


            Node<Person> np1 = new Node <Person> (p1);
            Node<Person> np2 = new Node <Person> (p2);
            Node<Person> np3 = new Node <Person> (p3);
            Node<Person> np4 = new Node <Person> (p4);
            Node<Person> np5 = new Node <Person> (p5);
            Node<Person> np6 = new Node <Person> (p6);
            Node<Person> np7 = new Node <Person> (p7);
            Node<Person> np8 = new Node <Person> (p8);

            //en el nodo de Maria agrego estos dos:
        
            np4.AddChildren(np2); //agrego a pedro como hijo de Maria
            np4.AddChildren(np3); //agrego Agustina como hijo de Maria

            //el segundo:

            np2.AddChildren(np1); //agrego a Juan como hijo de Pedro
            np2.AddChildren(np8); //agrego a Amadeo como hijo de Pedro
            np3.AddChildren(np6); //agrego a Facundo como hijo de Agustin

            //el tercero:

            np6.AddChildren(np5); //agrego a Laura como hija de Facundo

            //creo instancia de los visitadores:

            SumVisitor v1 = new SumVisitor();
            VisitorName v2 = new VisitorName();
            VisitorOld v3 = new VisitorOld();

            v1.Visit (np4);
            v2.Visit (np4);
            v3.Visit (np4);
         

            np1.Accept(v1);
            Console.WriteLine($"Suma de edades:{v1.SumaEdades}");

            np1.Accept(v2);
            Console.WriteLine($"Nombre mas largo es {v2.LongestName}");
            
            np1.Accept(v3);
            Console.WriteLine($"El mas viejo es: {v3.OldestKid} y es");

        }
    }
}
