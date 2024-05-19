using System;

public class HelloWorld
{

    static void Insertion(int[] a, int s){
        int i, j, k;

        for(i=1; i<s; i++){
            k = a[i];
            j = i-1;

            while(j>=0 && k<=a[j]){
                a[j+1] = a[j];
                j = j-1;
            }
            a[j+1] = k;
        }
    }
    
    public static void Main(string[] args)
    {
        int[] array = new int[]{5,1,7,2,3,9,11};
        int size = array.Length;

        //Console.WriteLine(size);

        foreach(int i in array){
            Console.WriteLine(i + " ");
        }
        Insertion(array, size);
        foreach(int a in array){
            Console.WriteLine(a + " ");
        }
    }
}