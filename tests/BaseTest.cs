using System;

namespace tests {
    public abstract class BaseTest<T> {
        protected T GetRandomData() {
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
                return (T)(object)ret;
            }

            throw new Exception("Error when trying to generate random numbers");
        }
    }
}