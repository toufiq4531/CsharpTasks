using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    class Student
    {
        int _id;
        string name;
        float _CGPA;
        
        public int id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name 
        {
            get
            {
                if (this.name != null)
                    return name;
                return "there is no name";
            } 
            set => name = value; // => this is called lambda operator
            //set { name = value; }  using lambda is equivalent to this line

        }

        public float CGPA { protected get => _CGPA; set => _CGPA = value; }
        // protected get { return _CGPA; }  (same line 34)
        // set { _CGPA = value; }  (same line 34)


        public double Salary { get; set; }  //Auto-implmented property
    }

    class TestStudent
    {
        static void Main(string[] args)
        {
            Student s = new Student();
                              //setting the value
            //Console.WriteLine(s.Salary);    //getting the value

            Console.ReadKey();
            
        }
    }
}
