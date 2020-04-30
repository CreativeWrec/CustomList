using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyCustomList<T> : IEnumerable
    {

        private T[] items;
        private int count;

        private int capacity;




        public T this[int index]
        {
            get
            {
                return items[index];
                //if (index < count && index >= 0)
                //{
                    
                //else
                //{
                   
                //}
              
            }
            set
            {
                items[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }

        }

        public MyCustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2;
                T[] size = items;
                items = new T[capacity];
                
                for (int i = 0; i < count; i++)
                {
                    items[i] = size[i];
                }
            }
            items[count] = item;
            count++;
        }



        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(items[i]))
                {
                   for (int r = i; r < count; r++)
                   {
                       if (r == count - 1)
                       {
                          items[r] = default(T);
                          {
                              items[r] = items[r + 1];
                          }
                       }
                   }
                   break;                    
                }
            }
            count--;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }


        //45 78 90
        //"457890"

        //"Sun" "Moon" "Earth"
        //"SunMoonEarth"
        public override string ToString()
        {
            string stringValues = ""; 
            for (int i = 0; i < Count; i++)
            {
                stringValues += items[i].ToString();
            }
            return stringValues;

        }

    }
}
