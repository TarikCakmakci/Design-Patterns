using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class objectPool<T>
    {
        private readonly Func<T> _create;
        private readonly Action<T> _reset;
        private readonly Stack<T> _pool;

        public objectPool(Func<T> create, Action<T> reset)
        {
            _create = create;
            _reset = reset;
            _pool = new Stack<T>();
        }

        public T GetObject()
        {
            lock (_pool)
            {
                if (_pool.Count > 0)
                {
                    return _pool.Pop();
                }
                else
                {
                    return _create();
                }
            }
        }

        public void PutObject(T item)
        {
            lock (_pool)
            {
                _reset(item);
                _pool.Push(item);
            }
        }
        public List<T> GetObjects()
        {
            lock (_pool)
            {
                return new List<T>(_pool);
            }
        }
    }
}
