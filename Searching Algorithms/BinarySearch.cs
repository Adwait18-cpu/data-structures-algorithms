// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class BinarySearch
{
    
    static int binarySearch(int start, int end, int[] a, int s){
        int mid = (start+end)/2;
        int L = start;
        int R = end;
        
        if(L<=R){
            if(a[mid] == s){
                return mid;
            }
        
            if(s < a[mid]){
                return binarySearch(L, mid-1, a, s);
            }
        
            if(s > a[mid]){
                return binarySearch(mid+1, R, a, s);
            }
        }
        
        return -1;
    }
    
    public static void Main(string[] args)
    {
        int size, i, search, status = 0, result;
        
        Console.WriteLine("Enter the size of array: ");
        size = Convert.ToInt32(Console.ReadLine());
        
        int[] array = new int[size];
        
        for(i=0; i<size; i++){
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("Enter the element to search: ");
        search = Convert.ToInt32(Console.ReadLine());
        
        result = binarySearch(0, size-1, array, search);
        
        if(result == -1){
            Console.WriteLine("Not Found");
        }
        else{
            Console.WriteLine("Element Found at {0} position",result);
        }
    }
}