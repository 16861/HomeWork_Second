using NUnit.Framework;
using first_task;
using System;


namespace tests
{
    [TestFixture(typeof(int))]
    [TestFixture(typeof(Guid))]
    [TestFixture(typeof(double))]
    [TestFixture(typeof(string))]
    public class Tests<T>
    {
        IMyList<T> _myList;
        T secondItem;

        T GetRandomData() {
            if (typeof(T) == typeof(int)) {
                Random r = new Random();
                return (T)(object)r.Next();
            } else 
            if (typeof(T) == typeof(Guid)) {
                return (T)(object)Guid.NewGuid();
            } else 
            if (typeof(T) == typeof(double)) {
                Random r = new Random();
                return (T)(object)r.NextDouble();
            } else 
            if (typeof(T) == typeof(string)) {
                Random r = new Random();
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                string ret = string.Empty;
                for(int i = 0; i < 20; i++)
                    ret += chars[r.Next(20)];
                Console.WriteLine(ret);
                return (T)(object)ret;
            }

            throw new Exception("Error when trying to generate random numbers");
        }

        [SetUp]
        public void Setup()
        {
            _myList = new MyList<T>();

            secondItem = GetRandomData();
            _myList.Add(GetRandomData());
            _myList.Add(secondItem);
            _myList.Add(GetRandomData());
        }

        [Test]
        public void TestListCountAndIndex()
        {        
            Assert.AreEqual(3, _myList.Count);            
            Assert.AreEqual(secondItem, _myList[1]);
        }

        [Test]
        public void TestListClear() {
            _myList.Clear();

            Assert.AreEqual(0, _myList.Count);
            Assert.AreNotEqual(secondItem, _myList[1]);
        }

        [Test]
        public void TestListContains() {
            Assert.IsTrue(_myList.Contains(secondItem));
            Assert.IsFalse(_myList.Contains(GetRandomData()));
        }
    }
}