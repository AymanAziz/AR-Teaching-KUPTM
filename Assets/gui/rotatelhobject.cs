using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatelhobject : MonoBehaviour {
    public GameObject objectRotate;
    public GameObject objectRotate1;
    public GameObject objectRotate2;
    public GameObject objectRotate3;
    public GameObject objectRotate4;
    public GameObject objectRotate5;
    public GameObject objectRotate6;
    public GameObject objectRotate7;
    public GameObject objectRotate8;

    public float rotateSpeed = 50f;
    bool rotateStatus = false;

    public void Rotasi()
    {

        if (rotateStatus == false)
        {
            rotateStatus = true;
        }
        else
        {
            rotateStatus = false;
        }
    }

    void Update()
    {
        if (rotateStatus == true)
        {
            objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            objectRotate1.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            objectRotate2.transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
            objectRotate3.transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
            objectRotate4.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            objectRotate5.transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
            objectRotate6.transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
            objectRotate7.transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
            objectRotate8.transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
        }


        }
        }
        