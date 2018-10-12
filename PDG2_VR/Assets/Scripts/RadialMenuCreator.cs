using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class RadialMenuCreator : MonoBehaviour {


    [Header("Right Hand")]
    [SerializeField] private GameObject marker;
    [SerializeField] private VRTK_ControllerTooltips rightTextField;
    [SerializeField] private Transform RightHand;

    [Header("Left Hand")]
    [SerializeField] private GameObject leftTextField;
    [SerializeField] private GameObject cubeYellow;
    [SerializeField] private GameObject cubePink;
    [SerializeField] private GameObject cubeGreen;
    [SerializeField] private GameObject cubeBlue;
    [SerializeField] private Transform LeftHand;

    void Start() {

    }

    #region RIGHT CONTROLLER
    public void CreateMarker() {
        try {
            GameObject m = GameObject.FindGameObjectWithTag("Marker");
            m.transform.position = RightHand.position;
        } catch (Exception e) {
            Debug.Log("[CREANDO MARCADOR]");
            GameObject m = Instantiate(marker, RightHand.position, Quaternion.identity);
        }
    }

    public void ChangeTextField(string t) {
        rightTextField.touchpadText = t;
    }

    #endregion

    #region LEFT CONTROLLER
    public void CreatePostit_Yellow() {
        GameObject c = Instantiate(cubeYellow, LeftHand.position, Quaternion.identity);
    }

    public void CreatePostit_Pink() {
        GameObject c = Instantiate(cubePink, LeftHand.position, Quaternion.identity);
    }

    public void CreatePostit_Green() {
        GameObject c = Instantiate(cubeGreen, LeftHand.position, Quaternion.identity);
    }

    public void CreatePostit_Blue() {
        GameObject c = Instantiate(cubeBlue, LeftHand.position, Quaternion.identity);
    }
    #endregion

}
