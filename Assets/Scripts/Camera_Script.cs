using System.Collections;

using UnityEngine;


public class Camera_Script : MonoBehaviour
{
    public Transform player;
    public float distance = 20f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 3) / distance);
                
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
       
    }
}
