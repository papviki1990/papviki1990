
using TMPro;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] int startHealth = 10;
    [SerializeField] TMP_Text uiText;
    [SerializeField] GameManager gameManager;

    int currentHealth;

   public  int GetCurrentHealth()
    {
        return currentHealth;
    }
    private void Start()
    {
        
        currentHealth = startHealth;

        uiText.text = "Health:" + currentHealth.ToString();
    }

    public void Damage(int damage)
    {
        if (currentHealth <= 0)
            return;

        currentHealth -= damage;
        currentHealth = Mathf.Max(0, currentHealth);

        if (currentHealth <= 0)
        {
            GameManager gm = FindAnyObjectByType<GameManager>();
            gm.OnGameEnded();
        }
            gameManager.OnGameEnded();


            updUIText();
    }

    void updUIText()
    {
        uiText.text = "Health:" + currentHealth.ToString();
    }
}
