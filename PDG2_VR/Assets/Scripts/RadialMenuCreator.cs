using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class RadialMenuCreator : MonoBehaviour {


    [Header("Right Hand")]
    [SerializeField] private GameObject marker;
    [SerializeField] private VRTK_ControllerTooltips rightTextField;

    [Header("Left Hand")]
    [SerializeField] private GameObject leftTextField;

    void Start() {

    }

    #region RIGHT CONTROLLER
    public void CreateMarker() {
        GameObject m = Instantiate(marker, transform.position, Quaternion.identity);
    }

    public void ChangeTextField(string t) {
        rightTextField.touchpadText = t;
    }

    #endregion

    #region LEFT CONTROLLER
    public void a() {

    }

    #endregion

}
