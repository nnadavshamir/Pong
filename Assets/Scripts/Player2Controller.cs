using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;

    private Vector2 movDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float newMovDirection = Input.GetAxisRaw("Vertical2");

        movDirection = new Vector2(0, newMovDirection).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = movDirection * speed;
    }
}
