using Indexer;
using Indexer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Indexer
{
    public class Program
    {
         static void Main(string[] args)
        {
            People peopleList = new People();
            peopleList.AddPerson(new Person { Name = "Can", SurName = "İçcan", Age = 23, Height = 1.93 });
            peopleList.AddPerson(new Person { Name = "Can01", SurName = "İçcan", Age = 23, Height = 1.93 });
            peopleList.AddPerson(new Person { Name = "Can02", SurName = "İçcan", Age = 23, Height = 1.93 });
            peopleList.AddPerson(new Person { Name = "Can03", SurName = "İçcan", Age = 23, Height = 1.93 });
            peopleList.AddPerson(new Person { Name = "Can04", SurName = "İçcan", Age = 23, Height = 1.93 });

            
            foreach (Person item in peopleList)
            {
                Console.WriteLine( item.Name + " " + item.SurName);
            }
            Console.ReadKey();
        }

        
    }
    }

    

