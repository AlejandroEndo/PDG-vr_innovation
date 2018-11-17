using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class EditorPostit : MonoBehaviour {

    public VRTK_InteractableObject linkedObject;

    [SerializeField] private GameObject editor;

    private void Start() {
        editor = GameObject.FindGameObjectWithTag("EditorReference");
    }

    protected virtual void OnEnable() {
        linkedObject = (linkedObject == null ? GetComponent<VRTK_InteractableObject>() : linkedObject);

        if (linkedObject != null) {
            linkedObject.InteractableObjectUsed += InteractableObjectUsed;
        }
    }

    protected virtual void OnDisable() {
        if (linkedObject != null) {
            linkedObject.InteractableObjectUsed -= InteractableObjectUsed;
        }
    }

    protected virtual void InteractableObjectUsed(object sender, InteractableObjectEventArgs e) {
        FireProjectile();
    }

    protected virtual void FireProjectile() { // Este metodo se ejecuta con el trigger
        editor.GetComponent<EditorManager>().TakePlace();
    }
}

