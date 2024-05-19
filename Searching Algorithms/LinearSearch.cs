using System;

public class LinearSearch
{
    static int Linear(int[] a, int size, int s){
        for(int i=0; i < size; i++){
            if(a[i] == s){
                return i;
            }
        }
        return -1;
    }
    
    public static void Main(string[] args)
    {
        int size, i, search, status = 0;
        
        Console.WriteLine("Enter the size of array: ");
        size = Convert.ToInt32(Console.ReadLine());
        
        int[] array = new int[size];
        
        for(i=0; i<size; i++){
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("Enter the element to search: ");
        search = Convert.ToInt32(Console.ReadLine());
        
        status = Linear(array, size, search);
        
        if(status == -1){
            Console.WriteLine("Element Not Found");
        }
        else{
            Console.WriteLine("Element Found at {0} position",status);
        }
    }
}