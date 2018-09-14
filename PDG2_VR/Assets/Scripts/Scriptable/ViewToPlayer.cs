using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewToPlayer : MonoBehaviour {

    [SerializeField] private Transform mCamera;

    [SerializeField] private Vector3[] boxSide;
    [SerializeField] [Range(0, 3)] private int index;
    [SerializeField] [Range(0f, 10f)] private float rotationSpeed;

    void Start() {
        boxSide = new Vector3[4];
        boxSide[0] = Vector3.forward;
        boxSide[1] = Vector3.right;
        boxSide[2] = Vector3.back;
        boxSide[3] = Vector3.left;
    }


    void Update() {
        //transform.LookAt(transform.position + mCamera.transform.rotation * boxSide[index], mCamera.transform.rotation * boxSide[index]);
        if (transform.parent == null) {
            //transform.LookAt(transform.position + mCamera.transform.rotation * boxSide[index], mCamera.transform.rotation * Vector3.up);

            Quaternion OriginalRot = transform.rotation;
            transform.LookAt(transform.position + mCamera.transform.rotation * boxSide[index], mCamera.transform.rotation * Vector3.up);
            Quaternion NewRot = transform.rotation;
            transform.rotation = OriginalRot;
            transform.rotation = Quaternion.Lerp(transform.rotation, NewRot, rotationSpeed * Time.deltaTime);
        }
    }
}