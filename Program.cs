using System;

namespace GenericCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Cal c = new Cal();
            try
            {
                double a = c.Sum<double, doubleCalc>(1, 2);
                Console.WriteLine(a);
                int temp = c.Sum<int, IntCalc>(1, 2);
                Console.WriteLine(temp);
                int temp1 = c.Subtract<int, IntCalc>(1, 2);
                Console.WriteLine(temp1);
                int temp2 = c.Multiply<int, IntCalc>(1, 2);
                Console.WriteLine(temp2);
                int temp3 = c.Divide<int, IntCalc>(1, 0);
                Console.WriteLine(temp3);
            }
            catch(System.DivideByZeroException e)
            {
                Console.WriteLine("This is division by zero exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("please enter valid numbers");
            }

        }

    }

    public class Cal
    {
        public T Sum<T, C>(T a, T b) where C :
       ISummable<T>, new()
        {
            C calc = new C();
            return calc.Add(a, b);
        }
        public T Subtract<T, C>(T a, T b) where C :
      ISummable<T>, new()
        {
            C calc = new C();
            return calc.Sub(a, b);
        }
        public T Multiply<T, C>(T a, T b) where C :
   ISummable<T>, new()
        {
            C calc = new C();
            return calc.Mul(a, b);
        }
        public T Divide<T, C>(T a, T b) where C :
   ISummable<T>, new()
        {
            C calc = new C();
            return calc.Div(a, b);
        }
    }

    public interface ISummable<T>
    {
        T Add(T a, T b);
        T Sub(T a, T b);
        T Mul(T a, T b);
        T Div(T a, T b);


    }
    public class IntCalc : ISummable<int>
    {    

        
        
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
    }


    public class doubleCalc : ISummable<double>
    {
        
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            return a / b;

        }
    }

    
    

    

}

