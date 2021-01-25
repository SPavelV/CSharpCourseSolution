using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public interface IBaseCollection
    {
        void Add(object obj);
        void Remove(object obj);


        // void Clear(); // breaking change
    }

    public static class BaseCollectionExtension
    {
        public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
        {
            foreach(var item in objects)
            {
                collection.Add(item);
            }
        }
    }

    //public abstract class IBaseCollection
    //{
    //    public abstract void add(object obj);
    //    public abstract void remove(object obj);

    //    public virtual void Clear()
    //    {
    //        Console.WriteLine("Defautl Implementation");
    //    }
    //}

    public class BaseList : IBaseCollection
    {
        private object[] items;
        private int count = 0;

        public BaseList(int initialOpacity)
        {
            items = new object[initialOpacity];
        }

        public void Add(object obj)
        {
            items[count] = obj;
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
