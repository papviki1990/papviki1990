using UnityEngine;

 class Testscript : MonoBehaviour
{
    void Start()
    {

        // Szia! Viki vagyok

        /*Komment */

        /* Több
         * Soros
         * Komment*/

        Debug.Log("Hello Unity!");
        Debug.Log($"Hello {name}!");

        // ----------------------

        // Változók
        int myFirstVariable = 76;
        Debug.Log(myFirstVariable); //76
        myFirstVariable = 7;
        Debug.Log(myFirstVariable);

        int myInt = 5; // Integer = Egész szám
        float myFloat = 46.67f; // Floating Point = Tizedes tört szám
        string myText = "iuvhih"; // String = Szöveg
        bool myBool1 = true; // Logical type = Eldöntendõ típus
        bool myBool2 = false;
        myBool2 = true;

    }
}