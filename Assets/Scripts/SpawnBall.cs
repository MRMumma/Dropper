using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    //creates variables to set the gameobject to spawn which can be changed in Unity
    public GameObject ball;
    public Transform leftWall;
    public Transform rightWall;

    //creates variable for the random position the ball can spawn and can be changed in Unity
    public Vector3 minPosition, maxPosition;

    //variables for spawning intervals and number of balls logic
    public float spawnInterval = 2f;
    public float nextSpawn = 0f;
    public float timer = 0.0f;
    public int numberBallSpawns = 1;

    //class that spawns one ball in a random locataion on the x axis with a set y of 5 and z of 0
    void RandomSpawn()
    {
        //get the x values for each wall
        float leftWallX = leftWall.position.x;
        float rightWallX = rightWall.position.x;

        //get the width of each wall
        float leftWallWidth = leftWall.GetComponent<SpriteRenderer>().bounds.size.x;
        float rightWallWidth = rightWall.GetComponent<SpriteRenderer>().bounds.size.x;

        //get the width of the ball
        float ballWidth = ball.GetComponent<SpriteRenderer>().bounds.size.x;

        //minimum and maximum x take into account the wall width and ball width to not spawn in or on the wall
        float minX = leftWallX + (leftWallWidth / 2) + (ballWidth / 2);
        float maxX = rightWallX - (rightWallWidth / 2) - (ballWidth / 2);

        //get the top point of the camera
        float topCamera = Camera.main.transform.position.y + Camera.main.orthographicSize;

        //set the y value to spawn the ball at
        float yValue = topCamera - (ballWidth / 2);

        Vector3 randomPosition = new Vector3(
            Random.Range(minX, maxX), yValue, 0);
        Instantiate(ball, randomPosition, Quaternion.identity);
    }

    void Update()
    {
        timer = Time.time;
        
        // 1 ball will spawn
        if (timer >= nextSpawn && numberBallSpawns == 1)
        {
            RandomSpawn();
            spawnInterval -= 0.2f;
            nextSpawn = timer + spawnInterval;

            if (spawnInterval <= 0.2)
            {
                numberBallSpawns += 1;
                spawnInterval = 1;
            }
        }

        //2 balls will spawn
        else if (timer >= nextSpawn && numberBallSpawns == 2)
        {
            RandomSpawn();
            RandomSpawn();
            spawnInterval -= 0.05f;
            nextSpawn = timer + spawnInterval;

            if (spawnInterval <= 0.2)
            {
                numberBallSpawns += 1;
                spawnInterval = 1;
            }
        }

        //3 balls will spawn
        else if (timer >= nextSpawn && numberBallSpawns == 3)
        {
            RandomSpawn();
            RandomSpawn();
            RandomSpawn();
            spawnInterval -= 0.05f;
            nextSpawn = timer + spawnInterval;

            if (spawnInterval <= 0.2)
            {
                numberBallSpawns += 1;
                spawnInterval = 1;
            }
        }

        //4 balls will spawn
        else if (timer >= nextSpawn && numberBallSpawns == 4)
        {
            RandomSpawn();
            RandomSpawn();
            RandomSpawn();
            RandomSpawn();
            spawnInterval -= 0.05f;
            nextSpawn = timer + spawnInterval;

            if (spawnInterval <= 0.2)
            {
                numberBallSpawns += 1;
                spawnInterval = 1;
            }
        }

        //5 balls will spawn
        else if (timer >= nextSpawn && numberBallSpawns >= 5)
        {
            RandomSpawn();
            RandomSpawn();
            RandomSpawn();
            RandomSpawn();
            RandomSpawn();
            spawnInterval -= 0.05f;
            nextSpawn = timer + spawnInterval;

            if (spawnInterval <= 0.2)
            {
                numberBallSpawns += 1;
                spawnInterval = 1;
            }
        }



    }
}
