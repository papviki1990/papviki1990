using UnityEngine;
using UnityEngine.SceneManagement;

public class CarGameManager : MonoBehaviour
{
    [SerializeField] float maxDistanceX;
   // [SerializeField] Transform player;
    [SerializeField] GameObject player;
    [SerializeField] GameObject GameOverObject;
    [SerializeField] GameObject WinnerObject;
    //[SerializeField] string thisSceneName;

    void Update()
    {
        float x = player.transform.position.x;
        if (Mathf.Abs(x) > maxDistanceX)
            EndGame();
    }

    public void EndGame()
    {
        Debug.Log("GAME OVER");
        Invoke("Restart", 3);
    }

    public void Winner()
        { 
        WinnerObject.SetActive(true);
        GameOverObject.SetActive(true);
    }

    void Restart()
    {
        GameOverObject.SetActive(true);

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
