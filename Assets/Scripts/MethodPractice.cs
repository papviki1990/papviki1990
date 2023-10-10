
using UnityEngine;

class MethodPactice : MonoBehaviour
{
    
    void Start()
    {
        float a = Mathf.Pow(2, 7);    // Hatványozás
        float b = Mathf.Pow(6, 5);    // Hatványozás
        float c = Mathf.Pow(-12.4f, 10);    // Hatványozás

        float d = Mathf.Abs(-13); // 13
        float e = Mathf.Sign(-16);  // -1
        float f = Mathf.Sign(333);   //1
        float g = Mathf.Round(12.66f);  // 13
        float h = Mathf.Ceil(11.11f);  // 12
        float i = Mathf.Floor(11.98f); // 11
        float j = Mathf.Max(12, 55);   // 55
        float k = Mathf.Min(12, 55);   // 12


    }


    float Power(float baseNumber, int exponent) 
    {
        float accum = 1;
        for (int i = 0; i < exponent; i++)
        {
            accum = accum * baseNumber;
        }
        return accum;
    }
    
    void SumOffFirstNumbers(int n)
    {
        if (n < 0) return;

        int acc = 0;
        for (int i = 1; i <= n; i++)
        {
            acc += i;
        }
        Debug.Log(acc);
    }

    float Abs(float n)   // n = number
    {
        if (n < 0)
        
        { 
            n = -n;
        }
        return n;
    }

    float Sign(float n)
    {
        if (n < 0)
        
            return -1;
        else
            return 1;  
    }
}
