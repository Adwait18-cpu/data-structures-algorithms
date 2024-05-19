using System;

public class HelloWorld
{

    static void Selection(int[] a, int s){
        int i, j, temp, min;

        for(i=0; i<s-1; i++){
            min = i;

            for(j=i+1; j<s; j++){
                if(a[min]>a[j]){
                    min = j;
                }
            }
            temp = a[min];
            a[min] = a[i];
            a[i] = temp;
        }
    }
    
    public static void Main(string[] args)
    {
        int[] array = new int[]{5,1,7,2,3,9,11};
        int size = array.Length;

        //Console.WriteLine(size);

        Console.Write("Array Before Sorting: ");
        foreach(int i in array){
            Console.Write(i + " ");
        }
        Console.Write("\n");
        Console.Write("Array After Sorting: ");
        Selection(array, size);
        foreach(int a in array){
            Console.Write(a + " ");
        }
    }
}