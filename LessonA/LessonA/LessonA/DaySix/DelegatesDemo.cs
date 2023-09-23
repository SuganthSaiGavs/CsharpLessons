public delegate void MethodHandlerA();
public delegate int MethodHandlerB(int x, int y);

/// <summary>
/// 1.delegates are a powerful feature,
/// that allows the declaration of variables, that can hold references to methods.
/// 2.Just like int,a delegate can store references to methods with a particular signature. 
/// </summary>

public class MathCalculator
{
    public void DoTask()
    {
        Console.WriteLine("Calculator DoTask");
    }
    public int Add(int x, int y)
    {
        Console.WriteLine(x + "," + y);
        return x + y;
    }
    public int Multiply(int x, int y)
    {
        Console.WriteLine(x + "," + y);
        return x * y;
    }
    public double Divide(double x, double y)
    {
        Console.WriteLine(x + "," + y);
        return x / y;
    }
    public String GetModel()
    {
        return "X500";
    }

    public class DelegateDemo
    {
        public static void TestOne()
        {
            MathCalculator mc = new MathCalculator();
            MethodHandlerA methodHandlerA = new MethodHandlerA(mc.DoTask);  // OR mc.Dotask; MethodHandlerA handles only void type.
            MethodHandlerB methodHandlerB = new MethodHandlerB(mc.Add);    // OR mc.Add;

            //we are taking the address of the method we dont invoke method
            MethodHandlerB methodHandlerTwo = new MethodHandlerB(mc.Multiply);
            //MethodHandlerB methodHandlerThree = new MethodHandlerA(mc.Divide); parameter not same its illegal



            methodHandlerA();
            int addResult = methodHandlerB(100, 50); //MethodHandler will invoke add method without calling the add method.
            Console.WriteLine(addResult);
            int multiplyResult = methodHandlerTwo(20, 5);
            Console.WriteLine(multiplyResult);

        }

        public static void TestTwo()
        {
            MathCalculator mc = new MathCalculator();
            MethodHandlerB methodHandlerB = mc.Add;


            int addResult= methodHandlerB(100, 50);
            Console.WriteLine(addResult);

            methodHandlerB += mc.Multiply;   //Multicast delegates,  which means a delegate can reference more than one method.
            int multiplyResult = methodHandlerB(100, 50); //You can use the += operator to combine methods.
            Console.WriteLine(multiplyResult);  //So when methodHandlerB is called, it calls two methods.
        }
    }
}