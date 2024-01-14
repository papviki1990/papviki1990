using UnityEngine;

public class CarGameManager : MonoBehaviour
{
    void Update()
    {
        CheckPlayerOutOfBounds();
    }

    void CheckPlayerOutOfBounds()
    {
        GameObject player = GameObject.FindWithTag("Player"); // Az "Player" tag használata szükségtelen, ha más módon is hozzáférhetsz a játékoshoz.

        if (player != null)
        {
            Rigidbody rb = player.GetComponent<Rigidbody>();

            if (rb != null && rb.position.y < -1f)
            {
                EndGame();
            }
        }
    }

    public void EndGame()
    {
        Debug.Log("GAME OVER");
        // További Game Over kezelési lépések, például játék újraindítása vagy menü megjelenítése.
    }
}