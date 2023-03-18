using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using Unit4.BucketLib;

namespace Procject_References_fix
{
    internal class Program
    {
        public static Bucket[] bucketArray;
        
        public static Bucket bucket1;

        public static Bucket bucket2;

        public static Bucket bucket3;

        public static Bucket bucket4;

        public static bool success;

        public static bool selectorFailure;
        private static string ToString(Bucket bucket)
        {
            return $"Capacity = {bucket.GetCapacity()}, Current Amount = {bucket.GetCurrentAmount()}";
        }
        private static void Selector()
        {
            try
            {
                Console.WriteLine("Enter the question number you want to select");
                int questionSelector = int.Parse(Console.ReadLine());
                if (questionSelector == 1)
                {
                    selectorFailure = true;
                    Bucket1();
                }
                else if (questionSelector == 2)
                {
                    selectorFailure = true;
                    Bucket2();
                }
                else if (questionSelector == 3)
                {
                    selectorFailure = true;
                    Bucket3();
                }
                else if (questionSelector == 4)
                {
                    selectorFailure = true;
                    Bucket4();
                }
                else if (questionSelector == 5)
                {
                    selectorFailure = true;
                    Bucket5();
                }
                else if (questionSelector == 6)
                {
                    selectorFailure = true;
                    Bucket6();
                }
                else if (questionSelector == 7)
                {
                    selectorFailure = true;
                    Bucket7();
                }
                else if (questionSelector == 8)
                {
                    selectorFailure = true;
                    Bucket8();
                }
                else if (questionSelector == 9)
                {
                    selectorFailure = true;
                    Bucket9();
                }
                else if (questionSelector == 10)
                {
                    selectorFailure = true;
                    Bucket10();
                }
                else if (questionSelector == 11)
                {
                    selectorFailure = true;
                    Bucket11();
                }
                else if (questionSelector == 12)
                {
                    selectorFailure = true;
                    Bucket12();
                }
                else
                    selectorFailure = false;
            }
            catch (Exception) { }
        }
        static void Main(string[] args)
        {
            try
            {
                Selector();
            }
            catch (Exception) { }
            finally
            {
                while (!selectorFailure)
                {
                    Selector();
                }
            }
            Console.WriteLine(@"Close Down The Bucket Program To Exit 
no more expetions they have all been caught your welcome");   
        }
        public static void Bucket1()
        {
            bucket1 = new Bucket(12, "Bucket1");
            bucket1.Fill(8);
            bucket1.Fill(3);
            Console.WriteLine(ToString(bucket1));
            //Q1.d/output: bucket: bucket1:
            //Capacity = 12, Current Amount = 8
            //Q1.f/output: bucket: bucket1:
            //Capacity = 12, Current Amount = 11
            //The meaning of the function: bucket1.Fill(num); ____ is adding num overtime to the current amount of the bucket

        }
        public static void Bucket2()
        {
            double amount1, amount2;
            int capacity1, capacity2;
            try
            {
                Console.WriteLine("enter bucket1 capacity");//Q2.b/ Input 200
                capacity1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter bucket2 capacity");//Q2.b/ Input 400
                capacity2 = int.Parse(Console.ReadLine());
                success = capacity1 > 0 || capacity2 > 0;
                if (success)
                {
                    bucket1 = new Bucket(capacity1, "bucket1");
                    bucket2 = new Bucket(capacity2, "bucket2");
                    if (capacity1 > capacity2)
                    {
                        amount1 = capacity2;
                        amount2 = capacity1 - capacity2;
                    }
                    else
                    {
                        amount1 = capacity1;
                        amount2 = capacity2 - capacity1;
                    }
                    bucket1.Fill(amount1);
                    bucket2.Fill(amount2);
                    Console.WriteLine("b1: " + ToString(bucket1));//Q2.b/ Output b1: Capacity = 200, Current Amount = 200
                    Console.WriteLine("b2: " + ToString(bucket2));//Q2.b/ Output b2: Capacity = 400, Current Amount = 400 
                }
                else
                {
                    Console.Clear();
                }
                /*Console.WriteLine("enter amount to fill bucket1");//Q2.b/ Input 200
                amount1 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter amount to fill bucket2");//Q2.b/ Input 400
                amount2 = double.Parse(Console.ReadLine());
                */
            }
            finally
            {
                if (!success)
                {
                    Bucket2();
                }
            }

            //Q2.a/ This function lets you create your own bucket with a capacityy you set and how much you wish to fill it 
            //Q2.b/ it showed the water peaking then dropping back down to the limit so filling more then the cap will just cap out 
            //Q2.c/ it worked with the changes

        }
        public static void Bucket3()
        {
            try
            {
                if (success)
                {
                    bucket1 = new Bucket(100, "bucket1");
                    bucket2 = new Bucket(100, "bucket2");
                    bucket3 = new Bucket(100, "bucket3");
                }
                Console.WriteLine("enter bucket1 fill amount");
                double fillAmount1 = double.Parse(Console.ReadLine());
                while (fillAmount1 > 100 || fillAmount1 <= 0)
                {
                    Console.WriteLine("invalid num err");
                    try
                    {
                        fillAmount1 = double.Parse(Console.ReadLine());
                    }
                    catch (Exception) { }
                }
                Console.WriteLine("enter bucket2 fill amount");
                double fillAmount2 = double.Parse(Console.ReadLine());
                while (fillAmount2 > 100 || fillAmount2 <= 0)
                {
                    Console.WriteLine("invalid num err");
                    try
                    {
                        fillAmount2 = double.Parse(Console.ReadLine());
                    }
                    catch (Exception) { }
                }
                Console.WriteLine("enter bucket3 fill amount");
                double fillAmount3 = double.Parse(Console.ReadLine());
                while (fillAmount3 > 100 || fillAmount3 < 0)
                {
                    Console.WriteLine("invalid num err");
                    try
                    {
                        fillAmount3 = double.Parse(Console.ReadLine());
                    }
                    catch (Exception) { }
                }
                if (fillAmount1 > fillAmount2 && fillAmount1 > fillAmount3)
                {//f1=max
                    bucket1.Fill(fillAmount1);
                    if (fillAmount2 > fillAmount3)
                    {//f1 max, f2 mid, f3 min
                        bucket2.Fill(fillAmount2);
                        bucket3.Fill(fillAmount3);
                    }
                    else
                    {//f1 max, f3 mid, f2 min
                        bucket2.Fill(fillAmount3);
                        bucket3.Fill(fillAmount2);
                    }
                }
                else if (fillAmount2 > fillAmount1 && fillAmount2 > fillAmount3)
                {//f2 max
                    bucket1.Fill(fillAmount2);
                    if (fillAmount1 > fillAmount3)
                    {//f2 max, f1 mid, f3 min
                        bucket2.Fill(fillAmount1);
                        bucket3.Fill(fillAmount3);
                    }
                    else
                    {//f2 max, f3 mid, f1 min
                        bucket2.Fill(fillAmount3);
                        bucket3.Fill(fillAmount1);
                    }
                }
                else
                {//f3 max
                    bucket1.Fill(fillAmount3);
                    if (fillAmount2 > fillAmount1)
                    {//f3 max, f2 mid, f1 min
                        bucket2.Fill(fillAmount2);
                        bucket3.Fill(fillAmount1);
                    }
                    else
                    {//f3 max, f1 mid, f2 min
                        bucket2.Fill(fillAmount1);
                        bucket3.Fill(fillAmount2);
                    }
                }
            }
            finally
            {
                if (!success)
                {
                    Console.Clear();
                    Bucket3();
                }
            }
        }
        public static void Bucket4()
        {
            try
            {
                Console.WriteLine("Enter the value of Bucket at the array[1]");
                int amountToAdd1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the diffrence");
                int diffrence = int.Parse(Console.ReadLine());
                success = !(amountToAdd1 < 0 || amountToAdd1 + diffrence * 4 > 100);
                if (success)
                {
                    bucketArray = new Bucket[4];
                    for (int i = 0; i < bucketArray.Length; i++)
                    {
                        bucketArray[i] = new Bucket(100, $"Bucket[{i + 1}]");
                        bucketArray[i].Fill(amountToAdd1);
                        amountToAdd1 += diffrence;
                    }
                    for (int i = 0; i < bucketArray.Length; i++)
                    {
                        Console.WriteLine($"Bucket[{i + 1}]:{ToString(bucketArray[i])}");
                    }
                }
            }
            finally
            {
                if (!success)
                {
                    Console.Clear();
                    Bucket4();
                    Console.WriteLine("Invalid Number Try Again\n no crash go brrrr");
                }
            }
        }
        //Up untill now we been able to create a type class<Bucket> and add water to it via the function b1.Fill();
        public static void Bucket5()
        {
            /*Q5.a//
            bucket1 = new Bucket(12,"Bucket1");
            bucket1.Fill(6);
            Console.WriteLine($"Bucket1: {ToString(bucket1)}");
            bucket1.Empty();
            Console.WriteLine($"Bucket1: {ToString(bucket1)}");
            ///<summary>
            The meaning of bucket1.Empty(num); 
            is to remove num from the currentAmount of the bucket. but plot twist
            it will throw errors because bucket.Empty has no overloads and can only fully empty the
            bucket and should look like the following to function:
            bucket1.Empty(); this wont be angry at you and will function 
            ///</summary>

            ///Q5.b/No as i stated in Q5.a it isnt possiable to change bucket1.Empty(num); to have a 
            ///diffrent value for the num as it cant have a parameter/overload.
            ///but if it did work it would be a simple while statement to filter out the bad numbers.
            */
            try
            {
                bucket1 = new Bucket(12, "Bucket1");
                bucket1.Fill(6);
                Console.WriteLine($"Bucket1: {ToString(bucket1)}");
                bucket1.Empty();
                Console.WriteLine($"Bucket1: {ToString(bucket1)}");

                Console.WriteLine(@"Bucket5 is not a executable question but a verbal/missing file
you can go selcet a diffrent question or read the verbal part in the code. the logged bucket from this
is the closest thing i could make it to the template");
            }
            finally
            {

            }
        }
        public static void Bucket6()
        {
            /*Bucket Do Not have a EmptyAll but again as i stated in Q5 the Bucket.Empty would 
             * function the same way as the presumed EmptyAll.
             * assuming it was real it would not return a value it is a void, voids do not return values
             * 
             * IsEmpty returns a boolean value of (currentAmount == 0) 
             * if (currentAmount == 0) it will return true else it returns false
            */
            try
            {
                Console.WriteLine(@"Bucket6 is not a executable question but a verbal/missing file
you can go selcet a diffrent question or read the verbal part in the code");
            }
            finally
            {
                Selector();
            }
        }
        public static void Bucket7()
        {
            try
            {
                Console.WriteLine("Enter bucket capacity");
                int capacity = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter amount to fill the bucket");
                double amountToFill = double.Parse(Console.ReadLine());
                success = !(capacity < 0 || amountToFill < 0);
                if (success)
                {
                    bucket1 = new Bucket(capacity, "Bucket1");
                    bucket1.Fill(amountToFill);
                    Console.WriteLine("Imagine there was a slow animation of it pouring down with Bucket.Empty(num) \nthe slow is built in lol");
                    Console.WriteLine("I cannot make it print out every liter because it makes the entire program wait untill the animation is done");
                    Console.WriteLine("i would have made on my self if i could setcurrentamount but they have it all internal/private");
                    Console.WriteLine(@"while u wait for the bucket to empty heres a funny
(￣o￣) . z Z 
(￣o￣) . z Z
(￣o￣) . z Z");
                    bucket1.Empty();
                    Console.WriteLine("(。・∀・)ノ welcome back that probly took a while");
                    Console.WriteLine("Using any function on a Bucket would follow this princiable:\n" +
                        "Bucket.<nameof func>(parameters) an example would look as the following:\n" +
                        "bucket1.Fill(10);");
                    Console.WriteLine("incase of a func with no parameters it would look like\n");
                    Console.WriteLine("bucket1.Empty();");
                    Console.WriteLine("my personal ToString(Bucket bucket) does get a bucket " +
                        "but most of them are overriding an object.ToString() " +
                        "so they have tostring allready and dont need to recive one");
                }
            }
            finally
            {
                if (!success)
                {
                    Bucket7();
                }
            }
        }
        public static void Bucket8()
        {

        }
        public static void Bucket9()
        {

        }
        public static void Bucket10()
        {

        }
        public static void Bucket11()
        {

        }
        public static void Bucket12()
        {

        }
    }
}
