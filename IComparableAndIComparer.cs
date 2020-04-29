class IComparableAndIComparer
    {

        public delegate void helloDelegate<in T>(T x, T y);
        public static void Main(String[] args)
        {
            Hashtable ht = new Hashtable();
            List<students> allStudents = new List<students>();
            allStudents.Add(new students(1, "john", 29));

            allStudents.Add(new students(3, "bob", 28));
            allStudents.Add(new students(2, "Andrew", 34));
            allStudents.Add(new students(4, "Allen", 19));
            allStudents.Add(new students { id = 4, name = "calvin", age = 19 });
            // first sort overload no paramter - IComparable
            allStudents.Sort();
            CompareStudents obj = new CompareStudents();

            // first sort overload no paramter - IComparer
            allStudents.Sort(obj);

            // third sort :we dont want to sort the first one and it is left like that, the remaining 3 will be sorted
            allStudents.Sort(1, 3, obj);



            // fourth sort overload my own method to sort . this uses the Comparision delegate



            Comparison<students> DelegateObj = new Comparison<students>(ComaparisionName);
            // usually we cannot pass the method name directly as a method name but here we can as it is already defined in the sort()
            allStudents.Sort(DelegateObj);


            // or 
            allStudents.Sort(ComaparisionName);

            // Or use Delegate directly Annonymous methods


            allStudents.Sort(delegate (students s1, students s2)
            {
                return s1.name.CompareTo(s2.name);
            }

            );

        


            // or just use a lambda expression

            allStudents.Sort((x, y) => {

                return x.name.CompareTo(y.name);
            });
        }


        // Comparison delegate signature match
        public static int ComaparisionName(students s1, students s2)
        {
            return s1.name.CompareTo(s2.name);
        }




    }

    class students : IComparable
    {
        public int id;
        public string name;
        public int age;

        public students(int id, string name, int age)
        {
            this.id = id;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.age = age;
        }

        public students() { }

        public int CompareTo(object other)
        {
            students obj =(students) other ;
            if(this.id> obj.id)
            {
                return 1;
            }
            else if(this.id < obj.id){
                return -1;
            }
            else return 0;
        }
    }

    class CompareStudents : IComparer<students>
    {
        public int Compare(students x, students y)
        {
            if (x.age > y.age)
            {
                return 1;
            }
            else if (x.age < y.age)
            {
                return -1;
            }
            else return 0;
        }
    }
