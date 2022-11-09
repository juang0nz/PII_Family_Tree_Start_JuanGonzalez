using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node <T>
    {
        private int number;
        private string name;
        private int age;


        private List<T> children = new List<T>();

        public int Number {
            get
            {
                return this.number;
            }
        }
        public string Nombre {
            get
            {
                return this.name;
            }
        }

        public int Edad {
            get
            {
                return this.age;
            }
        }

        public ReadOnlyCollection<T> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number)
        {
            this.number = number;
        }

        public void AddChildren(T n)
        {
            this.children.Add(n);
        }
        
    }
}
