using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject[] camPos;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(camPos[0].transform.position.x, camPos[0].transform.position.y, camPos[0].transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
