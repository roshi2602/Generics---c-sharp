using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//generics allows u to define a class with placeholders for fields , methods, parameters
//it helps in code reusablitity
// generics can be applied to - classes, methods,delegates,event,static method,operator
//using<> angle brackets
namespace GenericClasses
{
    //ex1
    //create 1 generic class
    class GenClass<T>
    {
        //create constructor
        public GenClass(T x)
        {
            Console.WriteLine(x);
        }
    }
    //goto main method
    //--------------------------------------------------

    //ex2
    class GenClass2<T>  //T defines that it does not belong to any specific data type
    {
        T x;  //declare a variable

        //create constructor
        public GenClass2(T y)    //can be used with constructor's parameter
        {
            //initializing x variable
            this.x = y;
        }

        //create 1 method
        public T Get()
        {
            //to get the value which was set above
            return this.x;      //return value of x
        }
    }
    //goto main method
    //----------------------------------------------------

    //ex3
    //using get and set property
    class GenClass3<T>  //<T> as type parameter
    {
        T g; //g as variable

            //create 1 property
            public T Prop
        {
            //apply property for variable g
            set
            {
                this.g = value;
            }
            get
            {
                return this.g;
            }
        }
    }

    //goto main method
    //----------------------------------------------------



    class Program
    {
        static void Main()
        {
            //ex1

            //class can of any type now, string , int   , char
            //creating object and passing value 
            GenClass<int> gg = new GenClass<int>(100);   //when we give values we define what data type generic is
            GenClass<string> gh = new GenClass<string>("hello");
            GenClass<char> gb = new GenClass<char>('L');
            Console.ReadLine();


            //----------------------------------------------------
            //ex2
            //object declare of which data type
            GenClass2<int> gc = new GenClass2<int>(10); //pass value in it of int data type
            GenClass2<string> gd = new GenClass2<string>("hello"); //pass value in it of string data type
            Console.WriteLine(gc.Get());
            Console.WriteLine(gd.Get());
            Console.ReadLine();

            //----------------------------------------------------
            //ex3
            //creating object of same class now int data type
            GenClass3<int> cc = new GenClass3<int>();    //it has property so we will not assign any value here
            cc.Prop = 100;
            Console.WriteLine(cc.Prop);

            //creating object of same class now string data type
            GenClass3<string> oo = new GenClass3<string>();    //it has property so we will not assign any value here
            oo.Prop = "rosshi";
            Console.WriteLine(oo.Prop);


            Console.ReadLine();

        }
    }
}
