using System.Drawing;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            
        }
      public static void BubbleSort(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }

       


    }
}
public class Range<T> where T:IComparable<T>
{

    public T? Min { get; set; }
    public T? Max { get; set; }
    public Range(T? min, T? max)
    {
        Min = min; 
        Max = max;
    }
    public bool IsInRange(T x)
    {
        if (x == null)
            return false;
        else if (x.CompareTo(Min) >= 0 && x.CompareTo(Max) <= 0)
            return true;
        else return false;


    }
    public int Length()
    {
        int mi=Convert.ToInt32(Min);
        int ma=Convert.ToInt32(Max);
        return ma - mi;

    }


    public  void display()
    {
        int mi = Convert.ToInt32(Min);
        int ma = Convert.ToInt32(Max);
        for (int i = mi; i <= ma; i++)
            Console.WriteLine(i);
    }

    }