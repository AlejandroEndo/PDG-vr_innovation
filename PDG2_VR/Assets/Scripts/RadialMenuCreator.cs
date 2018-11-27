using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class RadialMenuCreator : MonoBehaviour {


    [Header("Right Hand")]
    [SerializeField] private GameObject marker;
    [SerializeField] private GameObject eraser;
    [SerializeField] private VRTK_ControllerTooltips rightTextField;
    [SerializeField] private Transform RightHand;

    [Header("Left Hand")]
    [SerializeField] private GameObject leftTextField;
    [SerializeField] private GameObject cubeYellow;
    [SerializeField] private GameObject cubePink;
    [SerializeField] private GameObject cubeGreen;
    [SerializeField] private GameObject cubeBlue;
    [SerializeField] private Transform LeftHand;

    [Header("Photon Objects")]
    [SerializeField] private GameObject cubeYellowPhoton;
    [SerializeField] private GameObject cubePinkPhoton;
    [SerializeField] private GameObject cubeGreenPhoton;
    [SerializeField] private GameObject cubeBluePhoton;

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

    public void CreateEraser() {
        try {
            GameObject e = GameObject.FindGameObjectWithTag("Eraser");
            e.transform.position = RightHand.position;
        } catch (Exception e) {
            Debug.Log("[CREANDO BORRADOR]");
            GameObject m = Instantiate(eraser, RightHand.position, Quaternion.identity);
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

    #region PHOTON INSTANTIATE POST-ITS

    public void CreatePhoton_Yellow() {
        PhotonNetwork.Instantiate(cubeYellowPhoton.name, LeftHand.position, Quaternion.identity, 0);
    }

    public void CreatePhoton_Pink() {
        PhotonNetwork.Instantiate(cubePinkPhoton.name, LeftHand.position, Quaternion.identity, 0);
    }

    public void CreatePhoton_Green() {
        PhotonNetwork.Instantiate(cubeGreenPhoton.name, LeftHand.position, Quaternion.identity, 0);
    }

    public void CreatePhoton_Blue() {
        PhotonNetwork.Instantiate(cubeBluePhoton.name, LeftHand.position, Quaternion.identity, 0);
    }
    #endregion

}
