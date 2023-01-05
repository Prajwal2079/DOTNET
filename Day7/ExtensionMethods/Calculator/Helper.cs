namespace Mathematics;

public static class Helper{
    public static void Multiply(this MathEngine me, int num1, int num2){
        me.Result = num1 * num2;
        Console.WriteLine("Multiplication :" + me.Result);
    }


}