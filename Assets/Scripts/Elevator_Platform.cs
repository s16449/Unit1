using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_Platform : MonoBehaviour
{
    private float speed = 1f;
    private float starPosition;
    bool moveUp;
    private float currentPosition;
    public float UpDirectionValue = 1f;
    public float DownDirectionValue = 1f;

    private GameObject player;

    private void Start()
    {
        starPosition = transform.position.y;
    }
    private void Update()
    {
        if (transform.position.y > starPosition + DownDirectionValue)
        {
            moveUp = false;

        }
        if (transform.position.y < starPosition - UpDirectionValue)
        {
            moveUp = true;

        }

        if (moveUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);


        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);

        }

    }
}
