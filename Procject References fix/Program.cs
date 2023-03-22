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
        public static void Bucket5()
        {

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
                    for (double i = amountToFill; i >= 0; i--)
                    {
                        Console.WriteLine($"Bucket[1] current fill: {i}");
                        bucket1.Fill(-1);
                    }
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
            try
            {
                Console.WriteLine("Not an executable go back");
            }
            finally
            {
                Selector();
            }
        }
        public static void Bucket9()
        {
            try
            {

                Console.WriteLine("Enter bucket capacity");
                int capacity = int.Parse(Console.ReadLine());
                double amountToFill = double.Parse(Console.ReadLine());
                success = !(capacity < 0 || amountToFill < 0);
                if (success)
                {
                    bucket1 = new Bucket(capacity, "Bucket1");
                    while (amountToFill < capacity)
                    {
                        bucket1.Fill(1);
                        amountToFill--;
                        Console.WriteLine($"SBucket[1] current amount: {bucket1.GetCurrentAmount()}");
                    }
                }
            }
            finally
            {
                if (!success)
                {
                    Bucket9();
                }
            }
        }
        public static void Bucket10()
        {
            try
            {
                int capacity = int.Parse(Console.ReadLine());
                double amountToFill = 0;
                success = !(capacity < 0 || amountToFill < 0);
                if (success)
                {
                    bucket1 = new Bucket(capacity, "Bucket1");
                    for (double i = amountToFill; i < capacity; i += amountToFill)
                    {
                        try
                        {
                            Console.WriteLine("enter amount to fill the bucket");
                            amountToFill = double.Parse(Console.ReadLine());
                            while (amountToFill < 0)
                            {
                                Console.WriteLine("Error invalid num try again");
                                amountToFill = double.Parse(Console.ReadLine());
                            }
                        }
                        catch (Exception) { }
                        bucket1.Fill(amountToFill);
                        Console.WriteLine($"current amount: {bucket1.GetCurrentAmount()}");
                    }

                }
            }
            finally
            {
                if (!success)
                {
                    Bucket10();
                }
            }
        }
        public static void Bucket11()
        {
            double amountToFill = 0;
            Console.WriteLine("Enter capacity");
            int capacity = int.Parse(Console.ReadLine());
            while (capacity < 0)
            {
                Console.WriteLine("error invalid num try again");
                try
                {
                    capacity = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                }
            }
            bucket1 = new Bucket(capacity, "Bucket1");
            for (double i = 0; i < capacity; i += amountToFill)
            {
                Console.WriteLine("Bnter a positve or negetive");
                amountToFill = double.Parse(Console.ReadLine());
                bucket1.Fill(amountToFill);
                Console.WriteLine($"the bucket is now at: {bucket1.GetCurrentAmount()}");
            }
        }
        public static void Bucket12()
        {
            bucket1 = new Bucket(12, "Bucket1");
            bucket1.Fill(6);
            bucket2 = new Bucket(bucket1.GetCapacity(), "Bucket2");
            bucket2.Fill(9);
            Console.WriteLine(ToString(bucket1));
            Console.WriteLine(ToString(bucket2));
            bucket3 = new Bucket(bucket1.GetCapacity(), "bucket3");
            bucket1.PourInto(bucket3);
            bucket2.PourInto(bucket1);
            bucket3.PourInto(bucket2);
            Console.WriteLine("\n");
            Console.WriteLine(ToString(bucket1));
            Console.WriteLine(ToString(bucket2));
            Console.WriteLine(ToString(bucket3));
        }
    }
}
