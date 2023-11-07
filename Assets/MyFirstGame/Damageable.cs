
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] int startHealth = 10;

    int currentHealth;

    private void Start()
    {
        currentHealth = startHealth;
    }

    public void Damage(int damage)
    {
        if (currentHealth <= 0)
            return;

        currentHealth  -= damage;
        currentHealth = Mathf.Max(0, currentHealth);
        Debug.Log(currentHealth);
    }
}
