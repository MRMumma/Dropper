using UnityEngine;

public class BackToGame : MonoBehaviour
{
    //resumes the game
    public void clickedBackToGame()
    {
        //finds active instance and triggers it
        if (Pause.Instance != null)
        {
            Pause.Instance.ResumeGame();
        }
    }
}
