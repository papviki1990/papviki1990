using System;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] string[] strings1;
    [SerializeField] string searched;
    [SerializeField] int indexOfSearched;
    [SerializeField] string[] reversed;

    private void OnValidate()
    {
        indexOfSearched = GetIndex(strings1, searched);
        reversed = GetReversed(strings1);

        indexOfSearched = Array.IndexOf(strings1, searched);
        reversed = new string[strings1.Length];
        Array.Copy(strings1, reversed, strings1.Length);
        Array.Reverse(reversed);

        Array.Sort(reversed);  // Sorba rakás

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

}
