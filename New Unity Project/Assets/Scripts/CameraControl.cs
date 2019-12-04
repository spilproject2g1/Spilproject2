using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform[] camPos;
    public Transform startPos;
    public Transform targetPos;

    public float currentCamPos;
    public float moveSpeed;
    private float startTime;
    private float movelength;
    private float distCovered;
    // Start is called before the first frame update
    void Start()
    {
        movelength = Vector3.Distance(startPos.position, targetPos.position);
        startTime = Time.time;
        moveSpeed = 0.01f;
        transform.position = new Vector3(camPos[0].transform.position.x, camPos[0].transform.position.y, camPos[0].transform.position.z);
        transform.eulerAngles = new Vector3(35, 45, 0);
        currentCamPos = 1f;
        targetPos.position = camPos[1].position;
        startPos.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //change Camera Position
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeCamE();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeCamQ();
        }
    }

    void ChangeCamE()
    {
        switch (currentCamPos)
        {
            case 1:
                targetPos = camPos[1];
                StartCoroutine("changePosTo2ndCO");
                break;

            case 2:
                targetPos = camPos[2];
                StartCoroutine("changePosTo3rdCO");
                break;

            case 3:
                targetPos = camPos[3];
                StartCoroutine("changePosTo4thCO");
                break;

            case 4:
                targetPos = camPos[0];
                StartCoroutine("changePosTo1stCO");
                break;

            default:
                break;
        }
    }

    void ChangeCamQ()
    {
        switch (currentCamPos)
        {
            case 1:
                targetPos = camPos[3];
                StartCoroutine("changePosTo4thCO");
                break;

            case 2:
                targetPos = camPos[0];
                StartCoroutine("changePosTo1stCO");
                break;

            case 3:
                targetPos = camPos[1];
                StartCoroutine("changePosTo2ndCO");
                break;

            case 4:
                targetPos = camPos[2];
                StartCoroutine("changePosTo3rdCO");
                break;

            default:
                break;
        }
    }
        IEnumerator changePosTo1stCO()
        {
            transform.position = Vector3.Lerp(startPos.position, targetPos.position, 1f);
            transform.rotation = Quaternion.Lerp(startPos.rotation, targetPos.rotation, 1f);
            currentCamPos = 1f;
            yield break;
        }

        IEnumerator changePosTo2ndCO()
        {    
            transform.position = Vector3.Lerp(startPos.position, targetPos.position, 1f);
            transform.rotation = Quaternion.Lerp(startPos.rotation, targetPos.rotation, 1f);
            currentCamPos = 2f;
            yield break;
        }

        IEnumerator changePosTo3rdCO()
        {
            transform.position = Vector3.Lerp(startPos.position, targetPos.position, 1f);
            transform.rotation = Quaternion.Lerp(startPos.rotation, targetPos.rotation, 1f);
            currentCamPos = 3f;
            yield break;
        }

        IEnumerator changePosTo4thCO()
        {
            transform.position = Vector3.Lerp(startPos.position, targetPos.position, 1f);
            transform.rotation = Quaternion.Lerp(startPos.rotation, targetPos.rotation, 1f);
            currentCamPos = 4f;
            yield break;
        }
}
