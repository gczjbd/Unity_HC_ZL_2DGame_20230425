using UnityEngine;
using UnityEngine.SceneManagement;//引用場景API

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("遊戲場景");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
