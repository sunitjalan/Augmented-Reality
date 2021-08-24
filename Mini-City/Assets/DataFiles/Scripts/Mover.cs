using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Vector3 pos = new Vector3(0, 0, 0);
    int laneNumber = 0;
    void Start()
    {
        pos = transform.position;
        if(pos== (new Vector3(300.3f, -216.0f, -76.5f)))
        {
            laneNumber = 1;
        }
        if (pos == (new Vector3(300.3f, -216.0f, -18f)))
        {
            laneNumber = 2;
        }
        if (pos == (new Vector3(150f, -216.0f, -137f)))
        {
            laneNumber = 3;
        }
    }
    void Update()
    {
        if (laneNumber == 1)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-15, 0, 0);
        }
        if (laneNumber == 2)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-15, 0, 0);
        }
        if (laneNumber == 3)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 15);
        }
    }
}
