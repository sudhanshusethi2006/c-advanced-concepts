using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList
{




    class Employee : IComparable
    {
        public int id;
        public string name;

        public override string ToString()
        {
            // return base.ToString();

            return this.id + " " + this.name;
        }



        public int CompareTo(object obj)
        {
            Employee other = (Employee)obj;
            // here you can compare two objects 

            if (this.id > other.id) return 1;
            else if (this.id < other.id) return -1;
            else return 0;
        }


    }

    // other way of implementing comparato in case you dont have access to the employee class

    class EmployeeComparer : IComparer
    {


        public int Compare(object x, object y)
        {
            Employee first = (Employee)x;
            Employee second = (Employee)y;
       

        
            if (first.id > second.id)
            {
                return 1;
            }
            else if (first.id < second.id)
            {
                return -1;
            }
            else
            {
                return 0;
            }

            //or

          //  return first.id - second.id;
        }
    }
    class IEnumeratorPractice
    {
        static void Main(string[] args)
        {
            LinkedList<Employee> mylistofEmployees = new LinkedList<Employee>();
            ArrayList myArrayListofEmployees = new ArrayList();

            //// for Array List
            myArrayListofEmployees.Add(new Employee() { id = 3, name = "sam" });
            myArrayListofEmployees.Add(new Employee() { id = 1, name = "sid" });
            myArrayListofEmployees.Add(new Employee() { id = 2, name = "susan" });

            IEnumerator en = myArrayListofEmployees.GetEnumerator();
            while (en.MoveNext())
            {
                Employee currentEmployee = (Employee)en.Current;
                Console.WriteLine(currentEmployee);
            }
            EmployeeComparer ec = new EmployeeComparer();
            myArrayListofEmployees.Sort(ec);
            // for Linked List
            mylistofEmployees.AddLast(new Employee() { id = 1, name = "sam" });
            mylistofEmployees.AddLast(new Employee() { id = 2, name = "sid" });
            mylistofEmployees.AddLast(new Employee() { id = 3, name = "susan" });
            IEnumerator en2 = mylistofEmployees.GetEnumerator();
            while (en2.MoveNext())
            {
                Employee currentEmployee = (Employee)en.Current;
                Console.WriteLine(currentEmployee);
            }


        }

    }


}
