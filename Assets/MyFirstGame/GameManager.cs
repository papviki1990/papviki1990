using UnityEngine;
using UnityEngine.SceneManagement;

class GameManager : MonoBehaviour
{
    [SerializeField] GameObject GameOverObject;
    [SerializeField] string thisSceneName;
    [SerializeField] string nextSceneName;

    public void OnGameEnded()
    {
        // GAME OVER SCREEN ON
        GameOverObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(thisSceneName);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

