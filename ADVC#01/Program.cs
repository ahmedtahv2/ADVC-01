using System.Security.Cryptography.X509Certificates;

namespace ADVC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //class can have more than one type ,to code without duplicating the code for the same logic but different data type
            
            
        }
        #region Q2
        //public class Container<T>
        //{
        //    private List<T> _items = new List<T>();
        //    public void Add(T item)
        //    {
        //        _items.Add(item);
        //    }
        //    public T Get(int index)
        //    {
        //        return _items[index];
        //    }

        //} 
        #endregion

        #region Q3
        ////taking more than one type genric for class or method 
        //public class Pair<TKey,TValue>
        //{
        //    public TKey Key { get; set; }
        //    public TValue Value{ get; set; }

        //    public Pair(TKey key, TValue value)
        //    {
        //        Key = key;
        //        Value = value;
        //    }
        //} 
        #endregion

        #region Q4
        ////A method that can take independent genric type 
        //public void Swap<T>(ref T item1 ,ref T item2)
        //{
        //    T box;
        //    box = item1;
        //    item1 = item2;
        //    item2 = box;
        //} 
        #endregion

        #region Q5
        //public T FindMax<T>(T item1 , T item2) where T :IComparable
        //{
        //    return item1.CompareTo(item2) > 0 ? item1 : item2;
        //} 
        #endregion


    }
}
