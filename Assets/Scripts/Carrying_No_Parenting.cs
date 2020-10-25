using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrying_No_Parenting : MonoBehaviour
{

    private float startPosition;
    public Vector3 lastPosition;
    Transform _transform;
    private float currentPosition;
    public List<Rigidbody2D> rigidbody2Ds = new List<Rigidbody2D>();
    private GameObject element;

    void Start()
    {
        _transform = transform;
        lastPosition = transform.position;
        startPosition = transform.position.x;
    }

    private void LateUpdate()
    {
        if (rigidbody2Ds.Count > 0)
        {
            for (int i = 0; i < rigidbody2Ds.Count; i++)
            {
                Rigidbody2D rb2d = rigidbody2Ds[i];
                Vector3 velocity = (_transform.position - lastPosition);
                rb2d.transform.Translate(velocity, _transform);
            }
        }

        lastPosition = _transform.position;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Add(rb);
        }


    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Remove(rb);
        }
    }

    void Add(Rigidbody2D rb2d)
    {
        if (!rigidbody2Ds.Contains(rb2d))
        {
            rigidbody2Ds.Add(rb2d);
        }
    }

    void Remove(Rigidbody2D rb2d)
    {
        if (rigidbody2Ds.Contains(rb2d))
        {
            rigidbody2Ds.Remove(rb2d);
        }
    }

}