using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    //variable for the speed of movement that can be edited in Unity
    public float speed = 5.0f;
    private float Move;

    //creates physics and collision for the character
    private Rigidbody2D rb;

    //create movement buttons
    public Button LeftButtonLeft;
    public Button RightButtonLeft;
    public Button LeftButtonRight;
    public Button RightButtonRight;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //disable arrows at start
        //disable right side left arrow
        LeftButtonRight.enabled = false;
        LeftButtonRight.GetComponent<Image>().enabled = false;
        LeftButtonRight.interactable = false;

        //disable right side right arrow
        RightButtonRight.enabled = false;
        RightButtonRight.GetComponent<Image>().enabled = false;
        RightButtonRight.interactable = false;

        //disable Left side left arrow
        LeftButtonLeft.enabled = false;
        LeftButtonLeft.GetComponent<Image>().enabled = false;
        LeftButtonLeft.interactable = false;

        //disable Left side right arrow
        RightButtonLeft.enabled = false;
        RightButtonLeft.GetComponent<Image>().enabled = false;
        RightButtonLeft.interactable = false;

        //Tap controls
        if (GlobalVariables.controls == 0)
        {
            Vector2 Velocity = rb.linearVelocity;

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0); // Get the first touch

                // Check which half of the screen was touched
                if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
                {
                    float middleScreen = Screen.width / 2f;

                    if (touch.position.x < middleScreen)
                    {
                        // Move left
                        Velocity.x = -speed;
                    }
                    else
                    {
                        // Move right
                        Velocity.x = speed;
                    }
                }
                else
                {
                    //no movement
                    Velocity.x = 0f;
                }

                rb.linearVelocity = Velocity;
            }

        }

        //Left arrow controls
        else if (GlobalVariables.controls == 1)
        {
            //enable left side left arrow
            LeftButtonLeft.enabled = true;
            LeftButtonLeft.GetComponent<Image>().enabled = true;
            LeftButtonLeft.interactable = true;

            //enable left side right arrow
            RightButtonLeft.enabled = true;
            RightButtonLeft.GetComponent<Image>().enabled = true;
            RightButtonLeft.interactable = true;
        }

        //Right arrow controls
        else if (GlobalVariables.controls == 2)
        {
            //enable Right side left arrow
            LeftButtonRight.enabled = true;
            LeftButtonRight.GetComponent<Image>().enabled = true;
            LeftButtonRight.interactable = true;

            //enable Right side right arrow
            RightButtonRight.enabled = true;
            RightButtonRight.GetComponent<Image>().enabled = true;
            RightButtonRight.interactable = true;
        }

        //Keyboard controls
        else if (GlobalVariables.controls == 3)
        {
            Move = Input.GetAxisRaw("Horizontal");
        }
    }


    void Update()
    {
        //disable arrows
        //disable right side left arrow
        LeftButtonRight.enabled = false;
        LeftButtonRight.GetComponent<Image>().enabled = false;
        LeftButtonRight.interactable = false;

        //disable right side right arrow
        RightButtonRight.enabled = false;
        RightButtonRight.GetComponent<Image>().enabled = false;
        RightButtonRight.interactable = false;

        //disable Left side left arrow
        LeftButtonLeft.enabled = false;
        LeftButtonLeft.GetComponent<Image>().enabled = false;
        LeftButtonLeft.interactable = false;

        //disable Left side right arrow
        RightButtonLeft.enabled = false;
        RightButtonLeft.GetComponent<Image>().enabled = false;
        RightButtonLeft.interactable = false;
        if (GlobalVariables.controls == 0)
        {
            Vector2 Velocity = rb.linearVelocity;

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0); // Get the first touch

                // Check which half of the screen was touched
                if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
                {
                    float middleScreen = Screen.width / 2f;

                    if (touch.position.x < middleScreen)
                    {
                        // Move left
                        Velocity.x = -speed;
                    }
                    else
                    {
                        // Move right
                        Velocity.x = speed;
                    }
                }
                else
                {
                    Velocity.x = 0f;
                }

                rb.linearVelocity = Velocity;
            }
         
        }
        
        else if (GlobalVariables.controls == 1)
        {
            //enable left side left arrow
            LeftButtonLeft.enabled = true;
            LeftButtonLeft.GetComponent<Image>().enabled = true;
            LeftButtonLeft.interactable = true;

            //enable left side right arrow
            RightButtonLeft.enabled = true;
            RightButtonLeft.GetComponent<Image>().enabled = true;
            RightButtonLeft.interactable = true;
        }

        else if (GlobalVariables.controls == 2)
        {
            //enable Right side left arrow
            LeftButtonRight.enabled = true;
            LeftButtonRight.GetComponent<Image>().enabled = true;
            LeftButtonRight.interactable = true;

            //enable Right side right arrow
            RightButtonRight.enabled = true;
            RightButtonRight.GetComponent<Image>().enabled = true;
            RightButtonRight.interactable = true;
        }

        else if (GlobalVariables.controls == 3)
        {
            Move = Input.GetAxisRaw("Horizontal");
        }
        
    }
    

    //Move character left on button click
    public void LeftButtonClicked()
    {
        if (GlobalVariables.controls == 1)
        {
            Vector2 Velocity = rb.linearVelocity;
            Velocity.x = -speed;

            rb.linearVelocity = Velocity;
        }
    }

    //Move character right on button click
    public void RightButtonClicked()
    {
        if (GlobalVariables.controls == 1)
        {
            Vector2 Velocity = rb.linearVelocity;
            Velocity.x = speed;

            rb.linearVelocity = Velocity;
        }
    }

    //Stop movement when button is released
    public void ButtonReleased()
    {
        if (GlobalVariables.controls == 1)
        {
            Vector2 Velocity = rb.linearVelocity;
            Velocity.x = 0;

            rb.linearVelocity = Velocity;
        }
    }

    //Move character left on button click
    public void LeftButtonRightClicked()
    {
        if (GlobalVariables.controls == 2)
        {
            Vector2 Velocity = rb.linearVelocity;
            Velocity.x = -speed;

            rb.linearVelocity = Velocity;
        }
    }

    //Move character right on button click
    public void RightButtonRightClicked()
    {
        if (GlobalVariables.controls == 2)
        {
            Vector2 Velocity = rb.linearVelocity;
            Velocity.x = speed;

            rb.linearVelocity = Velocity;
        }
    }

    //Stop movement when button is released
    public void RightButtonReleased()
    {
        if (GlobalVariables.controls == 2)
        {
            Vector2 Velocity = rb.linearVelocity;
            Velocity.x = 0;

            rb.linearVelocity = Velocity;
        }
    }

    void FixedUpdate()
    {
        //Keyboard controls
        if (GlobalVariables.controls == 3)
        {
            rb.linearVelocity = new Vector2(Move * speed, rb.linearVelocity.y);
        }
    }
}
