using System.Collections.Generic;
using UnityEngine;

class ListPractise : MonoBehaviour
{
    [SerializeField] List<float> strings;


    void Start()
    {
        List<float> floatList = new List<float>();
        floatList.Add(23.44f);
        floatList.Add(37.44f);
        floatList.Add(44.22f);

        float f = floatList[2];
        floatList[0] = 12.66f;

        int count = floatList.Count;  // Darabsz�m

        bool found = floatList.Remove(23.44f);
        count = floatList.Count;  // Darabsz�m: 2
        f = floatList[0];  // 37.44f

        floatList.RemoveAt(0);
        count = floatList.Count;  // Darabsz�m: 1
        f = floatList[0];   // 44.22f

        floatList.Insert(0, 121.3f);
        int index = floatList.IndexOf(44.22f);  // 1
        count = floatList.Count;  // Darabsz�m: 2

        floatList.Clear();
        count = floatList.Count; // Darabsz�m: 0

        List<string> shoppingList = new() { "Toj�s", "K�rte", "Tej", "Zsemle", "Alma" };
        shoppingList.Sort();   //  Sorba rendez�s

        for (int i = 0; i < shoppingList.Count; i++)
        {
            string item = shoppingList[i];
            Debug.Log(item);
        }

        foreach (string item in shoppingList)
        {
            Debug.Log(item);
        }

    }

   
}
