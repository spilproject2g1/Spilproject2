﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform[] camPos;
    public Transform startPos;
    public Transform targetPos;

    public bool isMoving;
    public float currentCamPos;
    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        transform.position = camPos[0].position;
        transform.rotation = camPos[0].rotation;
        startPos.position = transform.position;
        currentCamPos = 1f;
        targetPos.position = camPos[1].position;
    }

    // Update is called once per frame
    void Update()
    {
        //change Camera Position
        if (Input.GetKeyDown(KeyCode.E) && isMoving == false)
        {
            ChangeCamE();
        }

        if (Input.GetKeyDown(KeyCode.Q) && isMoving == false)
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
                StartCoroutine("MoveToPosition");
                new WaitForSecondsRealtime(2.5f);
                currentCamPos = 2;
                break;

            case 2:
                targetPos = camPos[2];
                StartCoroutine("MoveToPosition");
                new WaitForSecondsRealtime(2.5f);
                currentCamPos = 3;
                break;

            case 3:
                targetPos = camPos[3];
                StartCoroutine("MoveToPosition");
                new WaitForSecondsRealtime(2.5f);
                currentCamPos = 4;
                break;

            case 4:
                targetPos = camPos[0];
                StartCoroutine("MoveToPosition");
                new WaitForSecondsRealtime(2.5f);
                currentCamPos = 1;
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
                StartCoroutine("MoveToPosition");
                new WaitForSecondsRealtime(2.5f);
                currentCamPos = 4;
                break;

            case 2:
                targetPos = camPos[0];
                StartCoroutine("MoveToPosition");
                new WaitForSecondsRealtime(2.5f);
                currentCamPos = 1;
                break;

            case 3:
                targetPos = camPos[1];
                StartCoroutine("MoveToPosition");
                new WaitForSecondsRealtime(2.5f);
                currentCamPos = 2;
                break;

            case 4:
                targetPos = camPos[2];
                StartCoroutine("MoveToPosition");
                new WaitForSecondsRealtime(2.5f);
                currentCamPos = 3;
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
    public IEnumerator MoveToPosition()
    {
        isMoving = true;
        var currentPos = transform.position;
        var currentRot = transform.rotation;
        var TargetPos = targetPos.position;
        var TargetRot = targetPos.rotation;
        var timeToMove = 2.5f;
        var t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / timeToMove;
            transform.position = Vector3.Lerp(currentPos, TargetPos , t);
            transform.rotation = Quaternion.Lerp(currentRot, TargetRot, t);
            yield return null;
        }
        isMoving = false;
    }
}
