using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewToPlayer : MonoBehaviour {

    [SerializeField] private Transform mCamera;

    [SerializeField] private Vector3[] boxSide;
    [SerializeField] [Range(0f, 10f)] private float rotationSpeed;

    [Range(0, 5)] public int index;

    void Start() {

        mCamera = GameObject.FindGameObjectWithTag("LookAtMe").transform;

        boxSide = new Vector3[6];
        boxSide[0] = Vector3.forward;
        boxSide[1] = Vector3.right;
        boxSide[2] = Vector3.back;
        boxSide[3] = Vector3.left;
        boxSide[4] = Vector3.up;
        boxSide[5] = Vector3.down;
    }


    void Update() {
        //transform.LookAt(transform.position + mCamera.transform.rotation * boxSide[index], mCamera.transform.rotation * boxSide[index]);
        if (transform.parent == null || transform.parent.CompareTag("Clasificador")) {
            //transform.LookAt(transform.position + mCamera.transform.rotation * boxSide[index], mCamera.transform.rotation * Vector3.up);

            Quaternion OriginalRot = transform.rotation;
            transform.LookAt(transform.position + mCamera.transform.rotation * boxSide[index], mCamera.transform.rotation * Vector3.up);
            Quaternion NewRot = transform.rotation;
            transform.rotation = OriginalRot;
            transform.rotation = Quaternion.Lerp(transform.rotation, NewRot, rotationSpeed * Time.deltaTime);
        }
    }
}