using UnityEngine;
using UnityEngine.SceneManagement;//�ޥγ���API

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("�C������");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
