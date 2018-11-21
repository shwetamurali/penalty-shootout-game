using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SkyCollide : MonoBehaviour
{
 
    Vector3 initialPos;
    GameObject ball;
    GameObject ballTwo;
    GameObject ballThree;
    GameObject goalie;
    public bool missed = false;
    public Text winScore;
    public int count = 0;
   

    void Start()
    {
        ball = GameObject.Find("Ball");
        ballTwo = GameObject.Find("Sphere");
        ballThree = GameObject.Find("BallThree");
        goalie = GameObject.Find("Cube");
    }

    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
    
        if (other.gameObject.name == "Ball")
        {
            Destroy(ball);
            SwipeShot.increaseTurns();
            ballTwo.transform.position = initialPos;
            missed = true;
        }
        if (other.gameObject.name == "Sphere")
        {
            Destroy(ballTwo);
            SwipeShot.increaseTurns();
            ballThree.transform.position = initialPos;
            missed = true;
        }
        if (other.gameObject.name == "BallThree")
        {
            Destroy(ballThree);
            SwipeShot.increaseTurns();
            winScore.text = "You Lose!";
            Destroy(goalie);
           // ballTwo.transform.position = initialPos;
        }


    }


}

