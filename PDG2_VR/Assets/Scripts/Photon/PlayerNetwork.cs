using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNetwork : MonoBehaviour {

    [SerializeField] private GameObject[] playerCamera;
    [SerializeField] private MonoBehaviour[] playerControlScript;

    [SerializeField] private Transform head;
    [SerializeField] private Transform left;
    [SerializeField] private Transform right;

    private GameObject body;

    private Transform headVR;
    private Transform leftVR;
    private Transform rightVR;

    private PhotonView photonView;

    private void Start() {
        playerCamera = GameObject.FindGameObjectsWithTag("MainCamera");
        photonView = GetComponent<PhotonView>();
        body = GameObject.FindGameObjectWithTag("Body");

        Initialize();
    }

    //VERSION PARA PC
    private void Initialize() {
        if (!photonView.isMine) {
            for (int i = 0; i < playerCamera.Length; i++) {
                //playerCamera[i].SetActive(false);
            }

            foreach (MonoBehaviour m in playerControlScript) {
                //m.enabled = false;
            }
        } else {
            /*left.SetParent(body.transform.GetChild(0).transform);
            right.SetParent(body.transform.GetChild(1).transform);
            head.SetParent(body.transform.GetChild(2).transform);*/

            leftVR = body.transform.GetChild(0).transform;
            rightVR = body.transform.GetChild(1).transform;
            headVR = body.transform.GetChild(2).transform;

            head.localPosition = Vector3.zero;
            left.localPosition = Vector3.zero;
            right.localPosition = Vector3.zero;
        }
    }

    private void Update() {
        head.position = headVR.position;
        left.position = leftVR.position;
        right.position = rightVR.position;
    }
}
