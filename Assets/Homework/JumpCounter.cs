
using UnityEngine;

class JumpCounter : MonoBehaviour
{
    [SerializeField] Vector2 a, b;

    [SerializeField] int jumpCount;
    [SerializeField] Vector2 jumpVector;

    private void OnValidate()
    {
        float d = Vector2.Distance(a, b);
        jumpCount = Mathf.CeilToInt(d);
        jumpVector = (b - a) / jumpCount;
    }
}
