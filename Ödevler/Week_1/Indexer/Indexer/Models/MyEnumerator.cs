using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.Models
{
    internal class MyEnumerator : IEnumerator
    {
        private List<Person> _iteration = new List<Person>();
        int position = -1;
        
        public MyEnumerator(List<Person> iteration)
        {
            _iteration = iteration;
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return _iteration[position];
                }
                catch (IndexOutOfRangeException)
                {

                    throw new InvalidOperationException();
                }
            }

        }

        

        public bool MoveNext()
        {
            position++;
            Console.Write(position.ToString() + " Index Numaralı Nesne : ");
            return (position < _iteration.Count);
        }
        
        public void Reset() => position = -1;



    }
}
