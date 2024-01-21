using UnityEngine;
using TMPro;

public class GameScore : MonoBehaviour
{
     [SerializeField] Transform player;
     [SerializeField] TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); 
    }
}