using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2d;

    public float moveSpeed = 3f;

    public const string Right = "right";
    public const string Left = "left";
    public const string Up = "up";
    public const string Down = "down";

    string buttonPressed;

    //Dash
    public float dashSpeed = 6f;
    private float dashTime;
    public float startDashTime;
    private int direction;

    public GameObject dashEffect;

    //DeathDetector
    private Vector3 respawnPoint;
    public GameObject DeathDetector;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            buttonPressed = Right;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            buttonPressed = Left;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            buttonPressed = Up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            buttonPressed = Down;
        }
        else 
        {
            buttonPressed = null;
        }

        if (direction == 0)
             {
            //     if (Input.GetKeyDown(KeyCode.LeftArrow))
            //     {
            //         Instantiate(dashEffect, transform.position, Quaternion.identity);
            //         direction = 1;
            //     }
            //     else if (Input.GetKeyDown(KeyCode.RightArrow))
            //     {
            //         Instantiate(dashEffect, transform.position, Quaternion.identity);
            //         direction = 2;
            //     }
            //     else 
                 if (Input.GetKeyDown(KeyCode.UpArrow))
                 {
                     Instantiate(dashEffect, transform.position, Quaternion.identity);
                     direction = 1;
                 }
                 else if (Input.GetKeyDown(KeyCode.DownArrow))
                 {
                     Instantiate(dashEffect, transform.position, Quaternion.identity);
                     direction = 2;
                 }
             }
             else
             {
                 if (dashTime <= 0)
                 {
                     direction = 0;
                     dashTime = startDashTime;
                     rb2d.velocity = Vector2.zero;
                 }
                 else
                 {
                     dashTime -= Time.deltaTime;

            //         if(direction == 1)
            //         {
            //             rb2d.velocity = Vector2.left * dashSpeed;
            //         }
            //         else if (direction == 2)
            //         {
            //             rb2d.velocity = Vector2.right * dashSpeed;
            //         }
            //         else
                     if (direction == 1)
                     {
                         rb2d.velocity = Vector2.left * dashSpeed;
                     }
                     else if (direction == 2)
                     {
                         rb2d.velocity = Vector2.right * dashSpeed;
                     }

                 }

             }



            // DeathDetector_Respawn

            DeathDetector.transform.position = new Vector2(transform.position.x, DeathDetector.transform.position.y);

        


    }

    private void FixedUpdate()
    {
             if(buttonPressed == Right)
        {
            rb2d.velocity = new Vector2(moveSpeed, 0);
        }
             else if( buttonPressed == Left)
        {
            rb2d.velocity = new Vector2 (-moveSpeed, 0);

        }
               else
        {
            rb2d.velocity = new Vector2(0, 0);

        }

        


  
       // //Dash left, rifght, up and down

       //else if (direction == 0)
       // {
       //     if (Input.GetKeyDown(KeyCode.LeftArrow))
       //     {
       //         Instantiate(dashEffect, transform.position, Quaternion.identity);
       //         direction = 1;
       //     }
       //     else if (Input.GetKeyDown(KeyCode.RightArrow))
       //     {
       //         Instantiate(dashEffect, transform.position, Quaternion.identity);
       //         direction = 2;
       //     }
       //     else 
       //     if (Input.GetKeyDown(KeyCode.UpArrow))
       //     {
       //         Instantiate(dashEffect, transform.position, Quaternion.identity);
       //         direction = 1;
       //     }
       //     else if (Input.GetKeyDown(KeyCode.DownArrow))
       //     {
       //         Instantiate(dashEffect, transform.position, Quaternion.identity);
       //         direction = 2;
       //     }
       // }
       // else
       // {
       //     if (dashTime <= 0)
       //     {
       //         direction = 0;
       //         dashTime = startDashTime;
       //         rb2d.velocity = Vector2.zero;
       //     }
       //     else
       //     {
       //         dashTime -= Time.deltaTime;

       //         if(direction == 1)
       //         {
       //             rb2d.velocity = Vector2.left * dashSpeed;
       //         }
       //         else if (direction == 2)
       //         {
       //             rb2d.velocity = Vector2.right * dashSpeed;
       //         }
       //         else
       //         if (direction == 3)
       //         {
       //             rb2d.velocity = Vector2.up * dashSpeed;
       //         }
       //         else if (direction == 4)
       //         {
       //             rb2d.velocity = Vector2.down * dashSpeed;
       //         }

       //     }

       // }
       // 

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "DeathDetector")
        {
            transform.position = respawnPoint;
        }
    }


}
