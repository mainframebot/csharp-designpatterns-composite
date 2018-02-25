using System;

namespace CompositePatternLesson.Interfaces
{
    public interface IComponent<T>
        where T : IEquatable<T>
    {
        T Name { get; set; }

        void Add(IComponent<T> c);

        IComponent<T> Remove(T s);

        IComponent<T> Find(T s);

        string Display(int depth);
    }
}
