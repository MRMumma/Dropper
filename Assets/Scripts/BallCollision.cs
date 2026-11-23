using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCollision : MonoBehaviour
{
    //variable to store wether the character has collided with the ball or not
    //false is not collided
    //true is collided
    public bool ballCollision = false;

    //will bring up the game end scene
    public void ShowGameEnd()
    {
        SceneManager.LoadSceneAsync("GameEnd");
    }

    //when the Character collides with the ball
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Character is colliding with ball
        if (collision.gameObject.CompareTag("Ball"))
        {
            ballCollision = true;
            ShowGameEnd();
        }
    }

}
