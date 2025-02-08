                //NAME:CHILUKURI SAMPATH(Mutant Version)

namespace TriangleApp{
public class Triangle
{
    public static bool IsIsosceles(int a, int b, int c)
    {
        //checking equilateral Triangle instead of isosceles Triangle to chect mutation
        return a == b && b == c  ;
    }
    public static void Main(string[] args){
        Console.WriteLine("TestExecuted by Chilukuri Sampath");
        Console.WriteLine(IsIsosceles(5,4,5));
    }
}
}

