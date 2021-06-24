using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//it allows to define classes and methods with placeholders
//The concept of generics is used to create general purpose classes and methods.
//use<> angular brackets
//generics allows u to create class/methods that can work with any datatype
//

namespace GenericsCSharp
{
    class Gen
    {


        //generic method
        //generic method is applied for stroring data of any type-int, string , char

        //ex1
        //create 1 static method having integer type array as parameter
        public static void Demo<T>(T[] arr)  //T for any data type(int, string, char)
        {
            //apply for loop
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //--------------------------------------------------------
        //ex2
        public static bool Demo2<T>(T a, T b)
        {
            bool c = a.Equals(b);        //boolean a == b 
            return c;
        }

        }


    //-------------------------------------------------------------------


        class Program
        {
            static void Main(string[] args)
            {
            
            //ex1

                //create array here
                int[] n = new int[5];

                //giving values to array
                n[0] = 10;
                n[1] = 20;
                n[2] = 30;
                n[3] = 40;
                n[4] = 50;

            //now creating aray of string type
            string[] s = { "paul", "john", "daisy" };

            //now creating aray of double type
            double[] d = { 2.0, 3.5, 5.6 };


            //since the method was static , we cant create an oobject, we will call it by classname.methodname
            Gen.Demo(n);     //T can have int type value or  
            Gen.Demo(s);          //T can have string type value 
            Gen.Demo(d);          //T can have double type value 
            Console.ReadLine();



            //--------------------------------------------------
            //for ex2
            Console.WriteLine(Gen.Demo2(10, 20));     //false
            Console.WriteLine(Gen.Demo2("ali", "ali")); //true
            Console.ReadLine();
        }
        }
    }
