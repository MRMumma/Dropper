using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //classes made to show specific scenes when called
    public void ShowGameplay()
    {
        SceneManager.LoadSceneAsync("Gameplay");
    }

    public void ShowHowToPlay()
    {
        SceneManager.LoadSceneAsync("HowToPlay");
    }

    public void ShowGameEnd()
    {
        SceneManager.LoadSceneAsync("GameEnd");
    }

    public void ShowGameMenu()
    {
        SceneManager.LoadSceneAsync("GameMenu");
        Time.timeScale = 1f;
    }

    public void ShowSettings()
    {
        SceneManager.LoadSceneAsync("Settings");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
