using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject[] camPos;
    public float currentCamPos;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(camPos[0].transform.position.x, camPos[0].transform.position.y, camPos[0].transform.position.z);
        transform.eulerAngles = new Vector3(transform.localRotation.x + 35,transform.localRotation.y + 45, 0);
        currentCamPos = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //change Camera Position
        if (Input.GetKeyDown(KeyCode.E))
        {
            switch (currentCamPos)
            {
                case 1:
                    StartCoroutine("changePosTo2ndCO");
                    break;

                case 2:
                    StartCoroutine("changePosTo3rdCO");
                    break;

                case 3:
                    StartCoroutine("changePosTo4thCO");
                    break;

                case 4:
                    StartCoroutine("changePosTo1stCO");
                    break;

                default:
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            switch (currentCamPos)
            {
                case 1:
                    StartCoroutine("changePosTo4thCO");
                    break;

                case 2:
                    StartCoroutine("changePosTo1stCO");
                    break;

                case 3:
                    StartCoroutine("changePosTo2ndCO");
                    break;

                case 4:
                    StartCoroutine("changePosTo3rdCO");
                    break;

                default:
                    break;
            }
        }
    }
    IEnumerator changePosTo1stCO()
    {
        transform.position = new Vector3(camPos[0].transform.position.x, camPos[0].transform.position.y, camPos[0].transform.position.z);
        transform.eulerAngles = new Vector3(30, 45, 0);
        yield return new WaitForSecondsRealtime(0.25f);
        currentCamPos = 1f;
        yield return null;
    }

    IEnumerator changePosTo2ndCO()
    {
        transform.position = new Vector3(camPos[1].transform.position.x, camPos[1].transform.position.y, camPos[1].transform.position.z);
        transform.eulerAngles = new Vector3(30, -45, 0);
        yield return new WaitForSecondsRealtime(0.25f);
        currentCamPos = 2f;
        yield return null;
    }

    IEnumerator changePosTo3rdCO()
    {
        transform.position = new Vector3(camPos[2].transform.position.x, camPos[2].transform.position.y, camPos[2].transform.position.z);
        transform.eulerAngles = new Vector3(30, -135, 0);
        yield return new WaitForSecondsRealtime(0.25f);
        currentCamPos = 3f;
        yield return null;
    }

    IEnumerator changePosTo4thCO()
    {
        transform.position = new Vector3(camPos[3].transform.position.x, camPos[3].transform.position.y, camPos[3].transform.position.z);
        transform.eulerAngles = new Vector3(30, 135, 0);
        yield return new WaitForSecondsRealtime(0.25f);
        currentCamPos = 4f;
        yield return null;
    }
}
