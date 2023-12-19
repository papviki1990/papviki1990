using System;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] string[] strings1;
    [SerializeField] string searched;
    [SerializeField] int indexOfSearched;
    [SerializeField] string[] reversed;

    [SerializeField] int fibonacciCount;
    [SerializeField] int[] fibonacciNumbers;

    private void OnValidate()
    {
        indexOfSearched = GetIndex(strings1, searched);
        reversed = GetReversed(strings1);

        indexOfSearched = Array.IndexOf(strings1, searched);
        reversed = new string[strings1.Length];
        Array.Copy(strings1, reversed, strings1.Length);
        Array.Reverse(reversed);

        Array.Sort(reversed);  // Sorba rakás

        fibonacciNumbers = GetFibonacci(fibonacciCount);

    }
    int GetIndex(string[] array, string searchfor)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == searchfor)
                return i;
        }
        return -1;

    }

    string[] GetReversed(string[] original)
    {
        string[] reserved = new string[original.Length];
        for (int i = 0; i < original.Length; i++)
        {
            reserved[i] = original[^(i + 1)];
        }

        return reversed;
    }
    void Start()
    {
        // Tömbök
        int a;  // Deklarálás
        int[] integers; // Deklarálás

        a = 23; // Definiálás
        integers = new int[10]; // Definiálás

        int[] ints2 = new int[124]; // 124 elem

        ints2[0] = 21;   // eLSÕ ELEM = NULLÁS INDEX
        ints2[1] = 34;
        ints2[123] = 5446;  // Utolsó elem
        // ints2[124] = 12356;  // ERROR Utolsó utáni
        // ints2[-1] = 12356;  // ERROR

        string[] strings = new string[] { "Alma", "Barack", "Citrom" };
        Debug.Log(strings[1]);  // Barack
        int lenght = strings.Length;
        // Utolsó elem lekérése
        string last = strings[strings.Length - 1];
        string lastAlter = strings[^1];

        string[] strings2 = { "Alma", "Barack", "Citrom" };  // Így is megy

        int index1 = GetIndex(strings2, "Barack"); // 1
        int index2 = GetIndex(strings2, "Banán"); // -1




        // Int tömb 100 elemû. Értékek 1-100

        /* int[] integers3 = new int[100];
        int a = 0, b = 1;
        while (a < integers3.Length)
        {
            integers3[a] = b;
            a++;
            b++;

        }*/

        int[] ints3 = new int[100];
        for (int i = 0; i < ints3.Length; i++)
        {
            ints3[i] = i + 1;
        }


        //------------------------------

        int x = 12;
        int y = x;
        y += 100;
        Debug.Log(x);   // 12

        int[] intsA = { 1, 2, 3 };
        int[] intsB = intsA;
        intsB[0] += 100;
        Debug.Log(intsA[0]);   // 101


    }

    float Min(float[] array)
    {
        float min = float.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[1] < min)
                min = array[1];

        }
        return min;
    }

    float max(float[] array)
    {
        float max = float.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[1] < max)
                max = array[1];

        }
        return max;
    }

    /*float Min(params float[] array)
    {
        float min = float.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        return min;
    }

    float Max(params float[] array)
    {
        float max = float.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }*/

    int[] GetFibonacci(int count)
    {
        int[] fib = new int[count];

        if (count > 0)
            fib[0] = 0;

        if(count > 1)
            fib[1] = 1;


        for (int i = 0; i < count; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }

        return fib;
    }
}
