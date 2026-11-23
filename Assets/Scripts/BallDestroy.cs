using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    //creates variable that can be chenged in Unity
    public float ballDestructionTime = 0.5f;
   
    //leaving here for now because it is another option of destroying the ball on collision

    //public GameObject destroyBall;
    /*
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Character is colliding with ball
        
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(Other.destroyBall);
        }
    }*/
    /*
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }*/

    /*
    public GameObject[] ball;
    public string triggerTag = "Floor";

    private void OnCollisionEnter(Collision collision)
    {
        foreach (var obj in ball)
        {
            if (obj.CompareTag(triggerTag))
            {
                Destroy(obj);
                break;
            }
        }
    }
    */


    void Start()
    {
        //destroys ball game object after ballDestructionTime number of seconds
        Destroy(gameObject, ballDestructionTime);
    }
}
