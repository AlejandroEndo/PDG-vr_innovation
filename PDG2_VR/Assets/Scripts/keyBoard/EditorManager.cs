using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorManager : MonoBehaviour {

    [SerializeField] private Transform reference;

    void Start() {

    }

    void Update() {

    }

    public void DeactivateEditor() {
        for (int i = 0; i < transform.childCount; i++) {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        Debug.Log("[EDITOR DEACTIVATED]");
    }

    public void TakePlace() {
        Debug.Log("[ADJUSTING POST-IT EDITOR]");

        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, reference.eulerAngles.y, transform.eulerAngles.z);
        transform.position = new Vector3(reference.position.x, 1.70f, reference.position.z);

        for(int i = 0; i < transform.childCount; i++) {
            transform.GetChild(i).gameObject.SetActive(true);
        }
        Debug.Log("[EDITOR ADJUSTED]");
    }
}
