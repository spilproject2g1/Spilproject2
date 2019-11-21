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
        transform.eulerAngles = new Vector3(transform.localRotation.x + 35,transform.localRotation.y + 45, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            transform.position = new Vector3(camPos[1].transform.position.x, camPos[1].transform.position.y, camPos[1].transform.position.z);
            transform.eulerAngles = new Vector3(30, -45, 0);
        }
    }
}
