using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour {

    public GameObject leftControl;
    public GameObject rightControl;

    void Start () {
        leftControl = GameObject.FindGameObjectWithTag("LeftHand");
        rightControl = GameObject.FindGameObjectWithTag("RightHand");
    }
	
	void Update () {
		
	}
}
