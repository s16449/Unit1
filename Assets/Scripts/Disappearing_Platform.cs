using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappearing_Platform : MonoBehaviour
{
    public float timeActive = 2f;
    public float time = 0;
    public bool platformAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        platformAlive = true;

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= timeActive)
        {
            time = 0;
            Disapear();

        }

    }
    void Disapear()
    {
        platformAlive = !platformAlive;
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(platformAlive);
        }
    }

}
