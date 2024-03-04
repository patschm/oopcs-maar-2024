using System.Collections;

namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        // Arrays
        // Aaneengesloten geheugen.
        // Is immutable
        // Offset gebaseerd (Ordered)
        int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};
        int[] array2 = new int[] {1,2,3,4,5,6,7,8,9,10};
        int[] array3 = {1,2,3,4,5,6,7,8,9,10};
        int[] array4 = [1,2,3,4,5,6,7,8,9,10];
        array[0] = 10;
        array[1] = 20;
        System.Console.WriteLine(array4[4]);

        int[,] matrix = new int[2,3] {{1,2,3}, {4,5,6}};
        int[,] matrix2 = new int[2,3] {{1,2,3}, {4,5,6}};

        int[][] jagged = new int [3][];
        jagged[0] = new int[7];
        jagged[1] = new int[2];

        var list = new List<int>();
        list.Add(1);

        var dict = new Dictionary<string, int>();
        dict.Add("een", 1);
        dict.Add("twee", 2);

        System.Console.WriteLine(dict["twee"]);

        var stack = new Stack<int>();
        stack.Push(1);

        var queue = new Queue<int>();
        queue.Enqueue(1);

        ArrayList oldlist = new ArrayList();
        oldlist.Add(1);
        oldlist.Add("2");

        for(int i = 0; i < array.Length;i++)
        {
            int temp = array[i];
            System.Console.WriteLine(temp);
        }

        foreach(int temp in array)
        {
            System.Console.WriteLine(temp);
        }

    }
}
