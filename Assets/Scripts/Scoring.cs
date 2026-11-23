using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    //variable to keep score
    public TextMeshProUGUI scoring;
    public int score;
    private float timer = 0.0f;

    public GameObject hasCollided;
    public BallCollision script;

    void Start()
    {
        //script is set to whether or not the character has collided with the ball
        //will be false if not collided
        //will be true if collided
        script = hasCollided.GetComponent<BallCollision>();
    }

    void Update()
    {
        //sets timer equal to the amount of seconds that has passed
        timer += Time.deltaTime;

        //stores the final score value in a global variable when the character collides with the ball
        if (script.ballCollision == true)
        {
            GlobalVariables.finalScore = score;
        }

        //if the character has not collided with the ball the score goes up by one every second
        else if (timer >= 1f)
        {
            score++;
            scoring.text = "Score: " + score;
            timer = 0f;
        }
    }
}
