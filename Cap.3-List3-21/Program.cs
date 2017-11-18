using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Set<List<string>> set = new Set<List<string>>();
            List<string> list = new List<string> { "nome", "sobrenome" };

            set.Insert(list);
            var buckets = set.Contains(list);
        }
    }
}

class Set<T>
{
    private List<T>[] buckets = new List<T>[100];

    public void Insert(T item)
    {
        int bucket = GetBucket(item.GetHashCode());
    }

    public bool Contains(T item)
    {
        return Contains(item, GetBucket(item.GetHashCode()));
    }

    private int GetBucket(int hashcode)
    {
        unchecked
        {
            return (int)((uint)hashcode % (uint)buckets.Length);
        }
    }

    private bool Contains(T item, int bucket)
    {
        if(buckets[bucket] != null)
        {
            foreach(T member in buckets[bucket])
            {
                if (member.Equals(item))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
/*
 * A Set implementation that uses hashing
 * 
 * http://msdn.microsoft.com/en-us/library/system.object.gethashcode(v=vs.110).aspx
 * */
