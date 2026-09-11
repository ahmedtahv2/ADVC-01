using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ADVC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //class can have more than one type ,to code without duplicating the code for the same logic but different data type
            //Q13
            //returns the default value 
            //Q18
            //Each  generic type has its own separate copy of static members
            //Q19
            //by specifying its type parameter or keeping the derived class generic
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

        #region Q6
        ////interface with genric type and any calss implement it must say the type 
        //public interface IRepository<T>
        //{
        //    public void Add(T item);
        //    public void Remove(T item);
        //    public T GetById(int ID);
        //    public List<T> GetAll();
        //} 
        #endregion

        #region Q7
        ////constrain that let the type must be struct 
        //public class Test<T> where T:struct
        //{
        //    public void testt()
        //    {
        //        Console.WriteLine("ewww");
        //    }
        //} 
        #endregion

        #region Q8
        ////constrain that let the type must be Class (reference type)
        //public class Test<T> where T : class
        //{
        //    public void testt()
        //    {
        //        Console.WriteLine("ewww");
        //    }
        //} 
        #endregion

        #region Q9
        ////constrain that let the type must have paramterLess Ctor
        //public class Test<T> where T : new()
        //{
        //    public void testt()
        //    {
        //        Console.WriteLine("ewww");
        //    }
        //} 
        #endregion

        #region Q10
        ////constrain that let the type must implement specific interface
        //public class Test<T> where T : IComparable
        //{
        //    public void testt()
        //    {
        //        Console.WriteLine("ewww");
        //    }
        //} 
        #endregion

        #region Q11
        ////constrain that let the type must inherit feom the base class(any name)
        //public class Base()
        // {

        // }
        // public class Test<T> where T : Base
        // {
        //     public void testt()
        //     {
        //         Console.WriteLine("ewww");
        //     }
        // } 
        #endregion

        #region Q12
        ////by adding more than constrains Ez :)
        //public class Test<T> where T : class ,IComparable ,new()
        //{
        //    public void testt()
        //    {
        //        Console.WriteLine("ewww");
        //    }
        //} 
        #endregion

        #region Q14
        //public T SafeList<T>(List<T> list, int index) => index >= 0 ? list[index] : default;

        #endregion

        #region Q15
        //make the genric type return only (output)

        #endregion
        #region Q16
        //make the genric type read only (input)

        #endregion

        #region Q17
        //covariance let the genric type outPut only whe contravariance let the geniric type input only

        #endregion

        #region Q20
        public class Cache<TKey, TValue>
        {
            //????????????????????????????
        } 
        #endregion

    }
}
