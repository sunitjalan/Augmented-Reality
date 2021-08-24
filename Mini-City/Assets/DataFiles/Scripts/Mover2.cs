using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2 : MonoBehaviour
{
    Vector3 pos = new Vector3(0, 0, 0);
    int laneNumber = 0;
    void Start()
    {
        pos = transform.position;
        if (pos == (new Vector3(-10f, -216.0f, -65.67f)))
        {
            laneNumber = 1;
        }
        if (pos == (new Vector3(-92f, -216.0f, -8f)))
        {
            laneNumber = 2;
        }
        if (pos == (new Vector3(162f, -216.0f, -22.1f)))
        {
            laneNumber = 3;
        }
    }
    void Update()
    {
        if (laneNumber == 1)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
        }
        if (laneNumber == 2)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
        }
        if (laneNumber == 3)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -15);
        }
    }
}
