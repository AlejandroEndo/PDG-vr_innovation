using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNetwork : MonoBehaviour {

    [SerializeField] private GameObject playerCamera;
    [SerializeField] private MonoBehaviour[] playerControlScript;

    private PhotonView photonView;

    private void Start() {
        photonView = GetComponent<PhotonView>();

        Initialize();
    }

    private void Initialize() {
        if (!photonView.isMine) {
            playerCamera.SetActive(false);

            foreach (MonoBehaviour m in playerControlScript) {
                m.enabled = false;
            }
        }
    }

}
