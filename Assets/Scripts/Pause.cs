using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static Pause Instance { get; private set; }

    [SerializeField] private string pauseSceneName = "PauseScene";
    private bool isPaused = false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void PauseGame()
    {
        if (isPaused) return;

        isPaused = true;
        //freeze time
        Time.timeScale = 0f;

        //load pause scene
        SceneManager.LoadScene(pauseSceneName,LoadSceneMode.Additive);
    }

    public void ResumeGame()
    {
        if (!isPaused) return;

        isPaused = false;
        //unfreeze time
        Time.timeScale = 1f;

        //completely unload puase scene
        SceneManager.UnloadSceneAsync(pauseSceneName);
    }
}
