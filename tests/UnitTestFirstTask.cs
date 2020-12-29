using NUnit.Framework;
using first_task;
using System;


namespace tests
{
    [TestFixture(typeof(int))]
    [TestFixture(typeof(Guid))]
    [TestFixture(typeof(double))]
    [TestFixture(typeof(string))]
    public class TestsFirstTask<T> : BaseTest<T>
    {
        IMyList<T> _myList;
        T secondItem;

        

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