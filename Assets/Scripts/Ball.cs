using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int numOfHits = 0;

    [SerializeField] 
    public float startSpeed;
    [SerializeField] 
    public float addedSpeed;

    [SerializeField] 
    public Rigidbody2D ball;

   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FirstMove());
    }
    
    public void MoveBall(Vector2 direction)
    {
        var newSpeed = startSpeed + numOfHits * addedSpeed;

        ball.velocity = newSpeed * direction;

    }

    private void Restart()
    {
        ball.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
    }
    
    public IEnumerator FirstMove()
    {
        Restart();
        yield return new WaitForSeconds(1);
        
        numOfHits = 0;
        MoveBall(new Vector2(1,0));
    }

    public void increaseSpeed()
    {
        numOfHits++;
    }
}
