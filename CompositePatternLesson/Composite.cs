using System;
using System.Collections.Generic;
using CompositePatternLesson.Interfaces;

namespace CompositePatternLesson
{
    public class Composite<T> : IComponent<T>
        where T : IEquatable<T>
    {
        private List<IComponent<T>> _list;

        private IComponent<T> _holder; 

        public T Name { get; set; }

        public Composite(T name)
        {
            Name = name;

            _list = new List<IComponent<T>>();
            _holder = null;
        }

        public void Add(IComponent<T> c)
        {
            _list.Add(c);
        }

        public IComponent<T> Remove(T s)
        {
            _holder = this;

            IComponent<T> current = _holder.Find(s);

            if (_holder != null)
            {
                ((Composite<T>) _holder)._list.Remove(current);
                return _holder;
            }

            return this;
        }

        public IComponent<T> Find(T s)
        {
            _holder = this;

            if(s.Equals(Name))
                return this;

            IComponent<T> current = null;

            foreach (var component in _list)
            {
                current = component.Find(s);
                if (current != null)
                    break;
            }

            return current;
        }

        public string Display(int depth)
        {
            throw new System.NotImplementedException();
        }
    }
}
