using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced03
{
    internal  class MyList<T> : IEnumerable
    {
       
        public List<T> list { get; set; }

        public MyList()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public bool Exists(Predicate<T> match)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i]))
                {
                    return true;
                }
                
            }
            return false;
        }
        public T? Find(Predicate<T> match) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i]))
                {
                    return list[i];
                }

            }
            return default;
        }
        public List<T>? FindAll(Predicate<T> match)
        {
            List<T> newList = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i]))
                {
                    newList.Add(list[i]);
                }
            }
            return newList;
        }
        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i]))
                {
                    return i;
                }

            }
            return -1;
        }
        public int FindIndex(int start ,Predicate<T> match)
        {
            for (int i = start; i < list.Count; i++)
            {
                if (match(list[i]))
                {
                    return i;
                }

            }
            return -1;
        }
        public int FindIndex(int start , int count, Predicate<T> match)
        {
            for (int i = start; i < start+count; i++)
            {
                if (match(list[i]))
                {
                    return i;
                }

            }
            return -1;
        }
        public int FindLast(Predicate<T> match)
        {
            for (int i = list.Count-1; i > -1; i--)
            {
                if (match(list[i]))
                {
                    return i;
                }

            }
            return -1;
        }
        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = list.Count - 1; i > -1; i--)
            {
                if (match(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public int FindLastIndex(int start,Predicate<T> match)
        {
            for (int i = list.Count - 1; i >= start; i--)
            {
                if (match(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public int FindLastIndex(int start, int count, Predicate<T> match)
        {
            for (int i = start+count; i >= start; i--)
            {
                if (match(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Foreach(Action<T> action) 
        {

            for (int i = 0; i < list.Count; i++)
            {
                action(list[i]);

            }
        }
        public bool TrueForAll(Predicate<T> match) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (!match(list[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
