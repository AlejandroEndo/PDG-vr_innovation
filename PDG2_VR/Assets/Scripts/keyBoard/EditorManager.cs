using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EditorManager : MonoBehaviour {

    [Header("Post-it settings")]
    [SerializeField] GameObject postitOnEdit;
    [SerializeField] private Transform reference;
    [SerializeField] private Transform postItPosition;

    [Header("KeyBoard")]
    [SerializeField] private Test_CaptureInputKey keyboard;

    [Header("UI Buttons")]
    [SerializeField] private GameObject tittleButton;
    [SerializeField] private GameObject descriptionButton;
    [SerializeField] private GameObject valueSlider;

    [Header("Editor Elements")]
    [SerializeField] private GameObject keyboardGO;
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject postitPosition;

    [Header("Post-it Attributes")]
    [SerializeField] private int side;
    public bool onEdit;

    void Start() {
        DeactivateEditor();
    }

    void Update() {
    }

    public void DeactivateEditor() {
        onEdit = false;

        ViewToPlayer vtp = postitOnEdit.GetComponent<ViewToPlayer>();
        vtp.index = 0;

        Debug.Log(transform.childCount);

        keyboardGO.SetActive(false);
        canvas.SetActive(false);
        postitPosition.SetActive(false);

        postitOnEdit = null;
        Debug.Log("[EDITOR DEACTIVATED]");
    }

    public void TakePlace(GameObject postit) {
        onEdit = true;
        postitOnEdit = postit;

        Debug.Log("[ADJUSTING POST-IT EDITOR]");

        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, reference.eulerAngles.y, transform.eulerAngles.z);
        transform.position = new Vector3(reference.position.x, 1.70f, reference.position.z);

        postitOnEdit.transform.position = postItPosition.position;
        if (postitOnEdit.transform.parent != null)
            postitOnEdit.transform.SetParent(null);

        //keyboard.inputFieldLabel = postitOnEdit.GetComponent<Attributes>().nameF;

        keyboardGO.SetActive(true);
        canvas.SetActive(true);
        postitPosition.SetActive(true);

        Debug.Log("[EDITOR ADJUSTED]");
    }

    public void TurnRight(Slider v) {
        if (!onEdit) return;

        ViewToPlayer vtp = postitOnEdit.GetComponent<ViewToPlayer>();
        if (vtp.index < 3) vtp.index++;
        else vtp.index = 0;

        switch (vtp.index) {
            case 0:
                tittleButton.SetActive(true);
                descriptionButton.SetActive(true);
                valueSlider.SetActive(false);
                break;

            case 1:
                tittleButton.SetActive(false);
                descriptionButton.SetActive(false);
                valueSlider.SetActive(true);

                v.value = postitOnEdit.GetComponent<Attributes>().valueR;
                break;

            case 2:
                tittleButton.SetActive(false);
                descriptionButton.SetActive(false);
                valueSlider.SetActive(true);

                v.value = postitOnEdit.GetComponent<Attributes>().valueB;
                break;

            case 3:
                tittleButton.SetActive(false);
                descriptionButton.SetActive(false);
                valueSlider.SetActive(true);

                v.value = postitOnEdit.GetComponent<Attributes>().valueL;
                break;
        }
    }

    public void TurnLeft(Slider v) {
        if (!onEdit) return;

        ViewToPlayer vtp = postitOnEdit.GetComponent<ViewToPlayer>();
        if (vtp.index > 0) vtp.index--;
        else vtp.index = 3;

        switch (vtp.index) {
            case 0:
                tittleButton.SetActive(true);
                descriptionButton.SetActive(true);
                valueSlider.SetActive(false);
                break;

            case 1:
                tittleButton.SetActive(false);
                descriptionButton.SetActive(false);
                valueSlider.SetActive(true);

                v.value = postitOnEdit.GetComponent<Attributes>().valueR;
                break;

            case 2:
                tittleButton.SetActive(false);
                descriptionButton.SetActive(false);
                valueSlider.SetActive(true);

                v.value = postitOnEdit.GetComponent<Attributes>().valueB;
                break;

            case 3:
                tittleButton.SetActive(false);
                descriptionButton.SetActive(false);
                valueSlider.SetActive(true);

                v.value = postitOnEdit.GetComponent<Attributes>().valueL;
                break;
        }
    }

    public void ChangeToTittle() {
        if (!onEdit) return;
        postitOnEdit.GetComponent<Attributes>().nameF.text = "";
        keyboard.inputFieldLabel = postitOnEdit.GetComponent<Attributes>().nameF;
    }

    public void ChangeToDescription() {
        if (!onEdit) return;
        postitOnEdit.GetComponent<Attributes>().description.text = "";

        keyboard.inputFieldLabel = postitOnEdit.GetComponent<Attributes>().description;
    }

    public void ChangeSideValue(Slider v) {
        if (!onEdit) return;

        int index = postitOnEdit.GetComponent<ViewToPlayer>().index;

        Attributes a = postitOnEdit.GetComponent<Attributes>();

        switch (index) {
            case 1: // Right
                a.SetValueRight((int)v.value);
                break;

            case 2: // Backward
                a.SetValueBackward((int)v.value);
                break;

            case 3: // Left
                a.SetValueLeft((int)v.value);
                break;
        }
    }
}
