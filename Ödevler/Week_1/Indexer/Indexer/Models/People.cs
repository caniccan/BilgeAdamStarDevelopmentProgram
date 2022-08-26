using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class People : IEnumerable
    {

        private List<Person> people = new List<Person>();



        public void AddPerson(Person person)
        {


            people.Add(person);


        }

        public IEnumerator GetEnumerator()
        {
            return people.GetEnumerator();
        }
    }


}
   

