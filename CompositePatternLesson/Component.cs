using System;
using CompositePatternLesson.Interfaces;

namespace CompositePatternLesson
{
    public class Component<T> : IComponent<T>
        where T : IEquatable<T>
    {
        public T Name { get; set; }

        public Component(T name)
        {
            Name = name;
        }

        public void Add(IComponent<T> c)
        {

        }

        public IComponent<T> Remove(T s)
        {
            return this;
        }

        public IComponent<T> Find(T s)
        {
            if (s.Equals(Name))
            {
                return this;
            }

            return null;
        }

        public string Display(int depth)
        {
            return new string('-', depth) + Name + "\n";
        }
    }
}
