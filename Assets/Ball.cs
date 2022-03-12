using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public GameManager.BallsColor ballColor;

    

    //private void OnCollisionEnter(Collision collision)
    //{
    //    var ball = collision.gameObject.GetComponent<Ball>();

    //    switch (ballColor)
    //    {
    //        case ballColor == ball.ballColor:
    //            Debug.Log("s");
    //            break;

    //        case GameManager.BallsColor.Green:
    //            Debug.Log("s");
    //            break;

    //        case GameManager.BallsColor.Blue:
    //            Debug.Log("s");
    //            break;
    //    }
    //}


    private void OnCollisionEnter(Collision collision)
    {
        var ball = collision.gameObject.GetComponent<Ball>();

        if (ballColor == ball.ballColor)
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

}
