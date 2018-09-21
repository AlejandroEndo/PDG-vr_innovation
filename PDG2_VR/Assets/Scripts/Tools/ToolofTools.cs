using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolofTools : MonoBehaviour {

    [SerializeField] private Transform VRcamera;

    private Vector3 pos;

	void Start () {
        pos = transform.localPosition;
	}
	
	void Update () {
        transform.position = new Vector3(VRcamera.position.x + pos.x, VRcamera.position.y + pos.y, VRcamera.position.z + pos.z);
        transform.rotation = Quaternion.Euler(transform.localRotation.eulerAngles.x, VRcamera.transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z);
	}
}
