using System;
using Library;

namespace Program
{
    class Program<T>
    {
        static void Main(string[] args)
        {
            Person p1 = new Person ("Juan",33);
            Person p2 = new Person ("Pedro",40);
            Person p3 = new Person ("Agustin",50);
            Person p4 = new Person ("Maria",60);
            Person p5 = new Person ("Laura",5);
            Person p6 = new Person ("Facundo",20);
            Person p7 = new Person ("Anthony",20);
            Person p8 = new Person ("Amadeo",20);


            Node<Person> np1 = new Node <Person> (1);
            Node<Person> np2 = new Node <Person> (2);
            Node<Person> np3 = new Node <Person> (3);
            Node<Person> np4 = new Node <Person> (4);
            Node<Person> np5 = new Node <Person> (5);
            Node<Person> np6 = new Node <Person> (6);
            Node<Person> np7 = new Node <Person> (7);
            Node<Person> np8 = new Node <Person> (8);

            //en el nodo de Maria agrego estos dos:
        
            np4.AddChildren(p2); //agrego a pedro como hijo de Maria
            np4.AddChildren(p3); //agrego Agustin como hijo de Maria

            //el segundo:

            np2.AddChildren(p1); //agrego a Juan como hijo de Pedro
            np2.AddChildren(p8); //agrego a Amadeo como hijo de Pedro
            np3.AddChildren(p6); //agrego a Facundo como hijo de Agustin

            //el tercero:

            np6.AddChildren(p5); //agrego a Laura como hija de Facundo


           /* Node<T> n1 = new Node<T>(1);
            Node<T> n2 = new Node<T>(2);
            Node<T> n3 = new Node<T>(3);
            Node<T> n4 = new Node<T>(4);
            Node<T> n5 = new Node<T>(5);
            Node<T> n6 = new Node<T>(6);
            Node<T> n7 = new Node<T>(7);*/

            // visitar el árbol aquí
        }
    }
}
