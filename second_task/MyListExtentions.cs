using first_task;

namespace second_task {
    public static class MyListExtentions {
        public static T[] GetArray<T>(this MyList<T> list) {
            T[] ret = new T[list.Count];
            var enumerator = list.GetEnumerator();
            
            for(int i = 0; enumerator.MoveNext(); i++)
                ret[i] = (T)enumerator.Current;
            
            return ret;
        }
    }
}