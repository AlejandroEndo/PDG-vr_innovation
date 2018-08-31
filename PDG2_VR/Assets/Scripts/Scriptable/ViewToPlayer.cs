using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewToPlayer : MonoBehaviour {

    [SerializeField] private Transform mCamera;

    void Start() {

    }


    void Update() {
        transform.LookAt(transform.position + mCamera.transform.rotation * Vector3.back,
           mCamera.transform.rotation * Vector3.up);
    }
}
