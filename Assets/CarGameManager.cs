using UnityEngine;

public class CarGameManager : MonoBehaviour
{
    void Update()
    {
        CheckPlayerOutOfBounds();
    }

    void CheckPlayerOutOfBounds()
    {
        GameObject player = GameObject.FindWithTag("Player"); // Az "Player" tag haszn�lata sz�ks�gtelen, ha m�s m�don is hozz�f�rhetsz a j�t�koshoz.

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
        // Tov�bbi Game Over kezel�si l�p�sek, p�ld�ul j�t�k �jraind�t�sa vagy men� megjelen�t�se.
    }
}