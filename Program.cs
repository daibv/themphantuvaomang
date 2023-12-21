using System;

namespace themphantuvaomang2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size; int[] array;int m; int n;int p;
            do 
            {
            Console.WriteLine("Enter size of an array: "); size = Int32.Parse(Console.ReadLine());
            if (size > 10)  Console.WriteLine("Size should not exceed 10");
            } 
            while (size > 10);

            array = new int[size*2];

            int i = 0;
            while (i < (size/2))
            {
                Console.Write("Enter the first half of elements. Other elements shall be assigned equal to 0:" + "\n" + "Element No." + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            for (int k = size/2; k < size; k++) { array[k] = 0;}

            Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length/2; j++) {Console.Write(array[j] + "\t");}
            Console.Write("\n");
            
            Console.WriteLine("Enter the number that you want to insert: ");
            m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position that you want to insert - must be in range of 1-10:");
            n = Int32.Parse(Console.ReadLine());
            if (n<1) {Console.WriteLine("Cannot insert the number in that position");}
            if (n>10) {Console.WriteLine("Cannot insert the number in that position");}

            for (p=size; p>=n; p--) { array[p] = array[p+1];}
            array[(n-1)] = m;
            Console.WriteLine("Property list: ");
            for (int j = 0; j < (array.Length/2); j++) {Console.Write(array[j] + "\t");}          
            
        }
    }
}