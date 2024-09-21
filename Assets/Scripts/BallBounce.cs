using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public Ball ball;
    public ScoreManager scoreManager;
    
    void Bounce(Collision2D collision)
    {
        Vector3 ballPos = transform.position;
        Vector3 racketPos = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;

        float speedVecX;
        
        if (collision.gameObject.name == "Player 1")
        {
            speedVecX = 1;
        }
        else
        {
            speedVecX = -1;
        }

        float speedVecY = (ballPos.y - racketPos.y) / racketHeight;
        
        ball.increaseSpeed();
        ball.MoveBall(new Vector2(speedVecX,speedVecY));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player 1" || other.gameObject.name == "Player 2")
        {
            Bounce(other);
        }
        else if (other.gameObject.name == "Right Wall")
        {
            scoreManager.Player1Goal();
            StartCoroutine( ball.FirstMove());
        }
        else if(other.gameObject.name == "Left Wall")
        {
            scoreManager.Player2Goal();
            StartCoroutine( ball.FirstMove());
        }
    }
}
