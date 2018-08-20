using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateElement : MonoBehaviour {

    [SerializeField] private Camera cam;
    [SerializeField] private GameObject box;

    private Ray ray;
    private RaycastHit hit;

    void Start() {

    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit)) {
                PhotonNetwork.Instantiate(box.name, hit.transform.position + hit.normal, Quaternion.identity, 0);
                Debug.Log("aaa");
            }
        }
    }
}
