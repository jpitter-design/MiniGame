using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutOfBounds : MonoBehaviour
{
    private float topbound = 0;
    private float bottombound = -8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topbound)
        {
            transform.position = new Vector3 (transform.position.x,transform.position.y,topbound);
        }
        if (transform.position.z < bottombound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, bottombound);
        }

    }
}
