using System.Collections.Generic;

namespace ex68_poo
{
    class AwesomeList<T> : List<T>
    {
        public override string ToString()
        {
            return $"Number of elements: {this.Count}\nType of elements: " +
                $"{typeof(T)}";
        }
    }
}
