using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SwipeShot : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Rigidbody rbTwo;
    private Rigidbody rbThree;
    Vector3 movement;
    Vector3 movementTwo;
    Vector3 movementThree;
    public Text winScore;
    public Text countScore;
    public int power;
    public int powerTwo;
    public int powerThree;
    Vector3 initialPos;
    GameObject ball;
    GameObject ballTwo;
    GameObject ballThree;
    public static int turn;
    public float initialX;



    void Start()
    {
        ball = GameObject.Find("Ball");
        ballTwo = GameObject.Find("Sphere");
        ballThree = GameObject.Find("BallThree");
        rb = ball.GetComponent<Rigidbody>();
        rbTwo = ballTwo.GetComponent<Rigidbody>();
        rbThree = ballThree.GetComponent<Rigidbody>();
        //ballTwo.active = false;
        initialX = ball.transform.position.x;
        initialPos = new Vector3(ball.transform.position.x, ball.transform.position.y, ball.transform.position.z);
        //ball.transform.position = initialPos;


    }
    void FixedUpdate()
    {
        if (turn == 0)
        {
            if (Input.GetKey("1"))
                power = 1;
            if (Input.GetKey("2"))
                power = 2;
            if (Input.GetKey("3"))
                power = 3;

            if (power == 1)
            {
                if (Input.GetKey("d")) //down straight
                    movement = new Vector3(0, 10, 5);
                else if (Input.GetKey("f")) //down right
                    movement = new Vector3(5, 10, 5);
                else if (Input.GetKey("s")) //down left
                    movement = new Vector3(-5, 10, 5);
                else if (Input.GetKey("e")) //up straight
                    movement = new Vector3(0, 10, 5);
                else if (Input.GetKey("w")) //up left
                    movement = new Vector3(-5, 12, 5);
                else if (Input.GetKey("r")) //up right
                    movement = new Vector3(5, 12, 5);
                rb.AddForce(movement);
                

            }
            else if (power == 2)
            {
                if (Input.GetKey("d")) //down straight
                    movement = new Vector3(0, 10, 17);
                else if (Input.GetKey("f")) //down right
                    movement = new Vector3(5, 7, 17);
                else if (Input.GetKey("s")) //down left
                    movement = new Vector3(-5, 7, 17);
                else if (Input.GetKey("e")) //up straight 
                    movement = new Vector3(0, 16, 5);
                else if (Input.GetKey("w")) //up left
                    movement = new Vector3(-5, 13, 5);
                else if (Input.GetKey("r")) //up right
                    movement = new Vector3(5, 13, 5);
                rb.AddForce(movement);
                

            }
            else if (power == 3)
            {
                if (Input.GetKey("d")) //down straight
                    movement = new Vector3(0, 10, 25);
                else if (Input.GetKey("f")) //down right
                    movement = new Vector3(5, 7, 25);
                else if (Input.GetKey("s")) //down left
                    movement = new Vector3(-5, 7, 23);
                else if (Input.GetKey("e")) //up straight 
                    movement = new Vector3(0, 18, 5);
                else if (Input.GetKey("w")) //up left
                    movement = new Vector3(-6, 20, 5);
                else if (Input.GetKey("r")) //up right
                    movement = new Vector3(20, 20, 6);
                rb.AddForce(movement);
            }
            if (ball.transform.position.z>-1.5)
            {
                turn++;
                Destroy(ball);
                //ballTwo.active = true;
                ballTwo.transform.position = initialPos;
            }

        }


        if (turn == 1)
        {
            if (Input.GetKey("1"))
                powerTwo = 1;
            if (Input.GetKey("2"))
                powerTwo = 2;
            if (Input.GetKey("3"))
                powerTwo = 3;

            if (powerTwo == 1)
            {
                if (Input.GetKey("d")) //down straight
                    movementTwo = new Vector3(0, 10, 5);
                else if (Input.GetKey("f")) //down right
                    movementTwo = new Vector3(5, 10, 5);
                else if (Input.GetKey("s")) //down left
                    movementTwo = new Vector3(-5, 10, 5);
                else if (Input.GetKey("e")) //up straight
                    movementTwo = new Vector3(0, 10, 5);
                else if (Input.GetKey("w")) //up left
                    movementTwo = new Vector3(-5, 12, 5);
                else if (Input.GetKey("r")) //up right
                    movementTwo = new Vector3(5, 12, 5);
                rbTwo.AddForce(movementTwo);


            }
            else if (powerTwo == 2)
            {
                if (Input.GetKey("d")) //down straight
                    movementTwo = new Vector3(0, 10, 17);
                else if (Input.GetKey("f")) //down right
                    movementTwo = new Vector3(5, 7, 17);
                else if (Input.GetKey("s")) //down left
                    movementTwo = new Vector3(-5, 7, 17);
                else if (Input.GetKey("e")) //up straight 
                    movementTwo = new Vector3(0, 16, 5);
                else if (Input.GetKey("w")) //up left
                    movementTwo = new Vector3(-5, 13, 5);
                else if (Input.GetKey("r")) //up right
                    movementTwo = new Vector3(5, 13, 5);
                rbTwo.AddForce(movementTwo);


            }
            else if (powerTwo == 3)
            {
                if (Input.GetKey("d")) //down straight
                    movementTwo = new Vector3(0, 10, 25);
                else if (Input.GetKey("f")) //down right
                    movementTwo = new Vector3(5, 7, 25);
                else if (Input.GetKey("s")) //down left
                    movementTwo = new Vector3(-5, 7, 23);
                else if (Input.GetKey("e")) //up straight 
                    movementTwo = new Vector3(0, 18, 5);
                else if (Input.GetKey("w")) //up left
                    movementTwo = new Vector3(-5, 20, 5);
                else if (Input.GetKey("r")) //up right
                    movementTwo = new Vector3(5, 20, 5);
                rbTwo.AddForce(movementTwo);
            }
            if (ballTwo.transform.position.z > -1.5)
            {
                turn++;
                Destroy(ballTwo);
                //ballThree.active = true;
                ballThree.transform.position = initialPos;
            }

        }


        if (turn == 2)
        {
            if (Input.GetKey("1"))
                powerThree = 1;
            if (Input.GetKey("2"))
                powerThree = 2;
            if (Input.GetKey("3"))
                powerThree = 3;

            if (powerThree == 1)
            {
                if (Input.GetKey("d")) //down straight
                    movementThree = new Vector3(0, 10, 5);
                else if (Input.GetKey("f")) //down right
                    movementThree = new Vector3(5, 10, 5);
                else if (Input.GetKey("s")) //down left
                    movementThree = new Vector3(-5, 10, 5);
                else if (Input.GetKey("e")) //up straight
                    movementThree = new Vector3(0, 10, 5);
                else if (Input.GetKey("w")) //up left
                    movementThree = new Vector3(-5, 12, 5);
                else if (Input.GetKey("r")) //up right
                    movementThree = new Vector3(5, 12, 5);
                rbThree.AddForce(movementThree);


            }
            else if (powerThree == 2)
            {
                if (Input.GetKey("d")) //down straight
                    movementThree = new Vector3(0, 10, 17);
                else if (Input.GetKey("f")) //down right
                    movementThree = new Vector3(5, 7, 17);
                else if (Input.GetKey("s")) //down left
                    movementThree = new Vector3(-5, 7, 17);
                else if (Input.GetKey("e")) //up straight 
                    movementThree = new Vector3(0, 16, 5);
                else if (Input.GetKey("w")) //up left
                    movementThree = new Vector3(-5, 13, 5);
                else if (Input.GetKey("r")) //up right
                    movementThree = new Vector3(5, 13, 5);
                rbThree.AddForce(movementThree);


            }
            else if (powerThree == 3)
            {
                if (Input.GetKey("d")) //down straight
                    movementThree = new Vector3(0, 10, 25);
                else if (Input.GetKey("f")) //down right
                    movementThree = new Vector3(5, 7, 25);
                else if (Input.GetKey("s")) //down left
                    movementThree = new Vector3(-5, 7, 23);
                else if (Input.GetKey("e")) //up straight 
                    movementThree = new Vector3(0, 18, 5);
                else if (Input.GetKey("w")) //up left
                    movementThree = new Vector3(-5, 20, 5);
                else if (Input.GetKey("r")) //up right
                    movementThree = new Vector3(5, 20, 5);
                rbThree.AddForce(movementThree);
            }
            if (ballThree.transform.position.z > -1.5)
            {
                turn++;
                Destroy(ballThree);
                winScore.text = "You're done";
                //ballTwo.active = true;
                //ballTwo.transform.position = initialPos;
            }
                

        }
       

    }
    public static void increaseTurns()
    {
        turn++;
       }
    public static int getTurns()
    {
        return turn;
    }



}
