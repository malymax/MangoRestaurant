using System.Collections;

namespace Mango.Product.API
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class MyEnumerable<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(this.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class MyEnumerator<T> : IEnumerator<T>
    {
        IList<T> inner;
        int currentIndex = -1;
        
        public MyEnumerator(IList<T> list) => inner = list;

        public T Current
        {
            get
            {
                if (currentIndex == -1)
                    throw new InvalidOperationException();
                if (currentIndex == inner.Count)
                    throw new InvalidOperationException();

                return inner[currentIndex];
            }
        }

        public bool MoveNext() => ++currentIndex < inner.Count;
        
        object IEnumerator.Current => Current;

        public void Dispose() => inner.Clear();

        public void Reset() => currentIndex = -1;
    }
}