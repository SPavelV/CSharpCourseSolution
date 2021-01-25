using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public interface IBaseCollection
    {
        void Add(object obj);
        void Remove(object obj);

    }

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
