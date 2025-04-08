using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_Assignment_04
{

    #region Q1
    internal class Calculator
    {

        public int add(int n1, int n2)
        {
            return n1 + n2;
        }


        public int add(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public float add(float n1, float n2)
        {
            return n1 + n2;
        }




    }
    #endregion

    #region Q2
    internal class Regtangle
    {
        public double width { set; get; }
        public double height { set; get; }



        Regtangle()
        {
            width = 0;
            height = 0;
        }



        Regtangle(double a, double b)
        {
            width = a;
            height = b;

        }

        Regtangle(double a)
        {
            width = a;
            height = a;

        }




    }
    #endregion


    #region Q3
    internal class complex
    {
        public int? real { set; get; }
        public int? img { set; get; }

        public override string ToString()
        {
            return $"{real} + {img}i";
        }

        public static complex operator +(complex c1, complex c2)
        {
            return new complex
            {
                real = (c1?.real ?? 0) + (c2?.real ?? 0),
                img = (c1?.img ?? 0) + (c2?.img ?? 0)

            };
        }







        public static complex operator -(complex c1, complex c2)
        {
            return new complex
            {
                real = (c1?.real ?? 0) - (c2?.real ?? 0),
                img = (c1?.img ?? 0) - (c2?.img ?? 0)

            };

        }


    }

    #endregion


    #region Q4
    internal class Employee
    {
        public virtual void method()
        {
            Console.WriteLine("Employee is  working");
        }

    }

    internal class Manager : Employee
    {
        public override void method()
        {
            Console.WriteLine("Manager is managing");
        }


    }



    #endregion

    #region Q5

    internal class baseclass()
    {
        public virtual void DisplayMessage()
        { Console.WriteLine("hello i am baseclass"); }

    }



    internal class DerivedClass1 : baseclass
    {
        public override void DisplayMessage()
        { Console.WriteLine("hello i am derivedclass1"); }

    }

    internal class DerivedClass2 : baseclass
    {
        public new void DisplayMessage()
        { Console.WriteLine("hello i am derivedclass1"); }

    }


    #endregion



    #region TIME_CLASS
    internal class TIME
    {
        public int hours { set; get; }
        public int minutes { set; get; }
        public int seconds { set; get; }



        public override string ToString()
        {
            return $"hours  {hours} : minutes {minutes} : seconds {seconds}";
        }


        //public TIME ()
        //{
        //    hours = 0;
        //    minutes = 0;
        //    seconds = 0;
        //}


        public TIME(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }


        public TIME(int sec)
        {
            if (sec > 3600)
            {
                hours = sec / 3600;
                minutes = (sec % 3600) / 60;
                seconds = (sec % 60);
            }
            else if (sec > 60)
            {
                minutes = sec / 60;
                seconds = (sec % 60);
            }
            else
            {
                seconds = sec;
            }

        }


        public static TIME operator +(TIME t1, TIME t2)

        {

            int N_total_secondes = (t1.hours + t2.hours) * 3600
                 + (t1.minutes + t2.minutes) * 60 +
                 ((t1.seconds + t2.seconds));


            return new TIME(N_total_secondes);

        }




        public static TIME operator +(TIME t1, int num)
        {
            int N_total_secondes = (t1.hours) * 3600 + (t1.minutes) * 60 + (t1.seconds) + num;
            return new TIME(N_total_secondes);

        }





        public static TIME operator +(int num, TIME t1)
        {
            int N_total_secondes = (t1.hours) * 3600 + (t1.minutes) * 60 + (t1.seconds) + num;
            return new TIME(N_total_secondes);

        }

        public static TIME operator ++(TIME t1)
        {

            int N_total_secondes = (t1.hours) * 3600 + (t1.minutes) * 60 + (t1.seconds) + 60;
            return new TIME(N_total_secondes);

        }

        public static TIME operator --(TIME t1)
        {

            int N_total_secondes = (t1.hours) * 3600 + (t1.minutes) * 60 + (t1.seconds) - 60;
            return new TIME(N_total_secondes);

        }

        public static TIME operator -(TIME t1, TIME t2)
        {
            int N_total_secondes = Math.Abs(t1.hours - t2.hours) * 3600
               + Math.Abs(t1.minutes - t2.minutes) * 60 +
               (Math.Abs(t1.seconds - t2.seconds));

            return new TIME(N_total_secondes);


        }







        public static bool operator >(TIME t1, TIME t2)
        {
            int t1_seconds = (t1.hours) * 3600 + (t1.minutes) * 60 + (t1.seconds);
            int t2_seconds = (t2.hours) * 3600 + (t2.minutes) * 60 + (t2.seconds);


            if (t1_seconds > t2_seconds)
                return t1_seconds > t2_seconds;
            else
                return t1_seconds < t2_seconds;


        }



        public static bool operator <(TIME t1, TIME t2)
        {

            int t1_seconds = (t1.hours) * 3600 + (t1.minutes) * 60 + (t1.seconds);
            int t2_seconds = (t2.hours) * 3600 + (t2.minutes) * 60 + (t2.seconds);

            if (t1_seconds < t2_seconds)
                return t1_seconds < t2_seconds;
            else
                return t1_seconds > t2_seconds;


        }


        public static bool operator <=(TIME t1, TIME t2)
        {
            int t1_seconds = (t1.hours) * 3600 + (t1.minutes) * 60 + (t1.seconds);
            int t2_seconds = (t2.hours) * 3600 + (t2.minutes) * 60 + (t2.seconds);

            if (t1_seconds <= t2_seconds)
                return t1_seconds <= t2_seconds;
            else return t1_seconds > t2_seconds;
        }

        public static bool operator >=(TIME t1, TIME t2)
        {
            int t1_seconds = (t1.hours) * 3600 + (t1.minutes) * 60 + (t1.seconds);
            int t2_seconds = (t2.hours) * 3600 + (t2.minutes) * 60 + (t2.seconds);

            if (t1_seconds >= t2_seconds)
                return t1_seconds >= t2_seconds;
            else return t1_seconds < t2_seconds;
        }




        // last 2 questions 
        // 




    }

    #endregion




}
