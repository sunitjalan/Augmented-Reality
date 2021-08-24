using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject Car1Prefab;
    [SerializeField]
    GameObject Car2Prefab;
    [SerializeField]
    GameObject l1;
    [SerializeField]
    GameObject l2;
    [SerializeField]
    GameObject l3;

    GameObject lane;
    Vector3 pos1 = new Vector3(0, 0, 0);
    Vector3 pos2 = new Vector3(0, 0, 0);
    GameObject car01; GameObject car02;
    void Start()
    {
        int choice = Random.Range(0, 3);

        car01 = Instantiate(Car1Prefab) as GameObject;
        car02 = Instantiate(Car2Prefab) as GameObject;
        if (choice == 0)
        {
            lane = l1;
            pos1 = new Vector3(300.3f, -216.0f, -76.5f);
            pos2 = new Vector3(-10f, -216.0f, -65.67f);

        }
        else if (choice == 1)
        {
            lane = l2;
            pos1 = new Vector3(300.3f, -216.0f, -18f);
            pos2 = new Vector3(-92f, -216.0f, -8f);
        }
        else if (choice == 2)
        {
            lane = l3;
            car01.transform.Rotate(new Vector3(0, -90, 0));
            car02.transform.Rotate(new Vector3(0, 90, 0));
            pos1 = new Vector3(150f, -216.0f, -137f);
            pos2 = new Vector3(162f, -216.0f, -22.1f);
        }
        car01.transform.position = pos1;
        car02.transform.position = pos2;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
