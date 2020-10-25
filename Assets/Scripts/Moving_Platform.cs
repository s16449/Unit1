using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    private float speed = 2f;
    private float startPosition;
    bool moveRight;
    private float currentPosition;

    public float leftDirectionValue = 3f;
    public float rightDirectionValue = 3f;




    private void Start()
    {
        startPosition = transform.position.x;

    }


    private void Update()
    {
        if (transform.position.x > startPosition + leftDirectionValue)
        {
            moveRight = false;

        }
        if (transform.position.x < startPosition - rightDirectionValue)
        {
            moveRight = true;

        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }

}
