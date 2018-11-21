using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class goalCollide : MonoBehaviour
{
    public float score=0f;
    public Text winScore;
    public Text countScore;
    Vector3 initialPos;
    GameObject ball;
    GameObject ballTwo;
    GameObject ballThree;
    GameObject goalie;
    public int turn;

    void Start()
    {
        ball = GameObject.Find("Ball");
        goalie = GameObject.Find("Cube");
        ballTwo = GameObject.Find("Sphere");
        ballThree = GameObject.Find("BallThree");
        if (score==0)
        initialPos = new Vector3(ball.transform.position.x, ball.transform.position.y, ball.transform.position.z);
        countScore.text = "Score: "+score;
        
    }

    void Update()
    {
        turn = SwipeShot.turn;
    }

    void OnTriggerEnter(Collider other)
    {
        if(score==0)
            countScore.text = "Score: 0";
        if ((other.gameObject.name == "Ball") || (other.gameObject.name == "Sphere") || (other.gameObject.name == "BallThree"))
        {
            score++;
            countScore.text = "Score: " + score;
            if (score==3)
            {
                Destroy(goalie);
                displayScore();
            }
            
    
        }

    }
    void displayScore()
    {
        if(score==3)
            winScore.text = "You Win!";
        else
            winScore.text = "You Lose!";



    }

}

