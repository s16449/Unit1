using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanishing_Platform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Destroy(gameObject, 1);
            //gameObject.SetActive(false);
        }
    }
}
