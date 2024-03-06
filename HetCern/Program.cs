namespace HetCern;

class Program
{
    static void Main(string[] args)
    {
       WillemKlein wk = new WillemKlein();
       SimonVanDerMeer sm = new SimonVanDerMeer();

       //wk.Bereken(sm.Add, 4, 5);
       //wk.Bereken(sm.Subtract, 4, 5);

       MathDel m1 = Multiply;
       //wk.Bereken(m1, 2,3);


       MathDel m2 = sm.Add;
       m2 += sm.Subtract;
       m2 -= sm.Subtract;
       m2 += sm.Add;
       m2 += sm.Subtract;
       m2 += sm.Add;

foreach(var item in m2.GetInvocationList())
{
    System.Console.WriteLine(item.Method.Name);
}


        int result = m2(1,2);
       Console.WriteLine(result);
    }
    static int Multiply(int a, int b)
    {
       return a * b;
    }
}
