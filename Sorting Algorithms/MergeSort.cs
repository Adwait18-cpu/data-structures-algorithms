using System;

public class HelloWorld
{
    static void Merge(int[] a, int beg, int mid, int end){
        int i, j, k;
        int n1 = mid - beg + 1;
        int n2 = end - mid;

        int[] LeftArray = new int[n1];
        int[] RightArray = new int[n2];

        for(i=0; i<n1; i++){
            LeftArray[i] = a[beg+i];
        }

        for(j=0; j<n2; j++){
            RightArray[j] = a[mid+1+j];
        }

        i = 0;
        j = 0;
        k = beg;

        while(i < n1 && j < n2){
            if(LeftArray[i] <= RightArray[j]){
                a[k] = LeftArray[i];
                i++;
            }
            else{
                a[k] = RightArray[j];
                j++;
            }
            k++;
        }
        while(i < n1){
            a[k] = LeftArray[i];
            i++;
            k++;
        }

        while(j < n2){
            a[k] = RightArray[j];
            j++;
            k++;
        }
    }

    static void MergeSort(int[] a, int beg, int end){
        if(beg <= end){
            int mid = (beg+end)/2;
            MergeSort(a, beg, mid);
            MergeSort(a, mid+1, end);

            Merge(a, beg, mid, end);
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
        MergeSort(array, 0, size-1);
        foreach(int a in array){
            Console.Write(a + " ");
        }
    }
}