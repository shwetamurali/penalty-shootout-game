using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Goalie : MonoBehaviour
{

    Vector3 initialPos;
    Vector3 initialGoalie;
    GameObject ball;
    GameObject ballTwo;
    GameObject ballThree;
    GameObject goalie;
    public int count = 0;
    public bool dirRight = true;
    public float pos;
    public float speed = 2.0f;
    public bool boonked = false;
    public Text winScore;

    void Start()
    {
        ball = GameObject.Find("Ball");
        ballTwo = GameObject.Find("Sphere");
        ballThree = GameObject.Find("BallThree");
        goalie = GameObject.Find("Cube");
        pos = goalie.transform.position.x;
        initialPos = new Vector3(0f, -0.337f,-4.2f);

    }

    void Update()
    {
        boonked = false;
        if (dirRight)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        else
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        if (transform.position.x >= 3.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -3)
        {
            dirRight = true;
        }


    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Ball")
        {
            //boonked = true;
            Destroy(ball);
            SwipeShot.increaseTurns();
            ballTwo.transform.position = initialPos;
        }
        if (other.gameObject.name == "Sphere")
        {
            //boonked = true;
            Destroy(ballTwo);
           SwipeShot.increaseTurns();
            ballThree.transform.position = initialPos;
        }
        if (other.gameObject.name == "BallThree")
        {
            boonked = true;
            Destroy(ballThree);
            winScore.text = "You Lose!";
            Destroy(goalie);

        }


    }


}


