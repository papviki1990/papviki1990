
using UnityEngine;

public class Otthonigyakorlas : MonoBehaviour
{
    [SerializeField] float a = 1.5f;
    [SerializeField] float b = 2.5f;
   

    void Start()
    {

        float osszeg = a + b;

        Debug.Log(osszeg);
    }  
}
