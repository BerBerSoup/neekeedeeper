using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("遊戲畫面");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
