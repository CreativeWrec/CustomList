using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyCustomList<T> 
    {

        private T[] items;
        private int count;

        private int capacity;




        public T this[int index]
        {
            get
            {
                if(index < count && index >= 0)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
              
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
        }




















       
    }
}
