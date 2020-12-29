using second_task;
using first_task;
using NUnit.Framework;
using System;


namespace tests {

    [TestFixture(typeof(int))]
    [TestFixture(typeof(Guid))]
    [TestFixture(typeof(double))]
    [TestFixture(typeof(string))]
    public class TestsSecondTask<T> : BaseTest<T> {
        MyList<T> _myList;

        [SetUp]
        public void SetUp() {
            _myList = new MyList<T>();

            _myList.Add(GetRandomData());
            _myList.Add(GetRandomData());
            _myList.Add(GetRandomData());
            _myList.Add(GetRandomData());
            _myList.Add(GetRandomData());
        }

        [Test]
        public void TestGetArray() {
            var arr = _myList.GetArray();

            Assert.AreEqual(_myList.Count, arr.Length);
            for(int i = 0; i < arr.Length; i++)
                Assert.AreEqual(_myList[i], arr[i]);
        }
    }
}