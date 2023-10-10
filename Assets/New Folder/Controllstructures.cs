
using UnityEngine;

public class Controllstructures : MonoBehaviour
{
    [SerializeField] int number;
    void Start()
    {
        int number = 12;

        if (number >= 10)
        {
            Debug.Log("Többjegyû szám");
        }
        else
        {
            Debug.Log("Egyjegyû szám");
        }


        if (number > 0)
        {
            Debug.Log("Pozitív szám");
        }
        else
        {
            Debug.Log("Negatív szám");
        }

        // Elágazás
        if (number > 0)
        {
            Debug.Log("Pozitív szám");
        }
        else if (number < 0)
        {
            Debug.Log("Negatív szám");
        }
        else
        {
            Debug.Log("A szám nulla");
        }

        // -------------------

        if (number % 2 == 0)

            Debug.Log("PÁROS");

        else

            Debug.Log("PÁRATLAN");


        // ---------------------

        bool isEven;

        if (number % 2 == 0)
            isEven = true;
        else
            isEven = false;

        string pairity;
        if (number % 2 == 0)
            pairity = "EVEN";
        else
            pairity = "ODD";

        pairity = number % 2 == 0 ? "EVEN" : "ODD";

        // --------------------------

        int i = 1;

        while (i <= 100)
        {
            Debug.Log(i * i);
            i++;
        }

        for (int j = 100; j > 0; j--)
        {
            Debug.Log(j * j);
       

        }

        int k = 1;
        do
        {
            Debug.Log(k * k);
            k++;

        } while (k <= 100);

    }
}