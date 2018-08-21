using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponsiveObject : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        //if (other.CompareTag("Boundarie")) {
            //transform.localScale = new Vector3(transform.localScale.x - 0.01f, transform.localScale.y - 0.01f, transform.localScale.z - 0.01f);
        //Debug.Log("DUDUDUDU");
        //}
    }

    private void OnTriggerStay(Collider other) {
        if (other.CompareTag("Boundarie")) {
            transform.localScale = new Vector3(transform.localScale.x - 0.01f, transform.localScale.y - 0.01f, transform.localScale.z - 0.01f);
        //Debug.Log("DUDUDUDU");
        }
    }

}
