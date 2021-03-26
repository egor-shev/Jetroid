using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 150f;
    public Vector2 maxVelocity = new Vector2(60, 100);

    private Rigidbody2D body2D;
    private SpriteRenderer renderer2D;

    // Start is called before the first frame update
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float absVelX = Mathf.Abs(body2D.velocity.x);

        float forceX = 0f;
        float forceY = 0f;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(absVelX < maxVelocity.x)
            {
                forceX = speed;
            }

            renderer2D.flipX = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (absVelX < maxVelocity.x)
            {
                forceX = -speed;
            }

            renderer2D.flipX = true;
        }

        body2D.AddForce(new Vector2(forceX, forceY));
    }
}