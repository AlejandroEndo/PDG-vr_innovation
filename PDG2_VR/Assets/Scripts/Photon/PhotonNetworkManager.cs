using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonNetworkManager : MonoBehaviour {

    [SerializeField] private Text connectText;
    [SerializeField] private GameObject lobbyCamera;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject player;

    private void Start () {
        PhotonNetwork.ConnectUsingSettings("0.2.0");
        //PhotonNetwork.autoCleanUpPlayerObjects = false;
	}
	
    public virtual void OnJoinedLobby() {
        Debug.Log("Joined to loby");
        PhotonNetwork.JoinOrCreateRoom("InnLab", null, null);
    }

    public virtual void OnJoinedRoom() {
        Debug.Log("On da jaus");
        PhotonNetwork.Instantiate(player.name, spawnPoint.position, Quaternion.identity, 0);
        lobbyCamera.SetActive(false);
    }


	private void Update () {
        connectText.text = PhotonNetwork.connectionStateDetailed.ToString();
	}
}
