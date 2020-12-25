using System;

namespace first_task {
    public class MyList<T> : IMyList<T> {
        private int _max = 100, _current = 0;
        private T[] arr;

        public MyList() {
            arr =  new T[_max];
        }

        public void Add(T a) {
            if (_current < _max) 
                arr[_current++] = a;
        }
        public T this[int index] { 
            get {
                if (index < _current || index > 0) {
                    return arr[index];
                }
                return default(T);
            }
        }
        public int Count { 
            get{
                return _current;
            } 
        } 
        public void Clear() {
            arr = new T[_max];
            _current = 0;
        }
        public bool Contains(T item) {
            for(int i = 0; i < _current; i++) {
                if (arr[i].Equals(item)) 
                    return true;
            }
            return false;
        }
    }
}