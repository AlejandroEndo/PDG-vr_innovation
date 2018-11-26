using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Screens : MonoBehaviour {

    [Header("Pantallas")]
    [SerializeField] private GameObject inicio;
    [SerializeField] private GameObject method;
    [SerializeField] private GameObject customerM;
    [SerializeField] private GameObject customerInfo;

    [Header("Enviroments")]
    [SerializeField] private GameObject neutralEnviroment;
    [SerializeField] private GameObject cjmEnviroment;

    [Header("Video Settings")]
    [SerializeField] private VideoPlayer vp;
    [SerializeField] private bool isPlaying;
    [SerializeField] private Slider slider;

    void Start () {
        inicio.SetActive(true);
        method.SetActive(false);
        customerM.SetActive(false);
        customerInfo.SetActive(false);

        neutralEnviroment.SetActive(true);
        cjmEnviroment.SetActive(false);
    }
	
	void Update () {
        if (!isPlaying) return;

        slider.value = vp.frame;
	}

    public void DisplayMethods() {
        inicio.SetActive(false);
        method.SetActive(true);
        customerM.SetActive(false);
        customerInfo.SetActive(false);
    }

    public void DisplayCustomerMap() {
        inicio.SetActive(false);
        method.SetActive(false);
        customerM.SetActive(true);
        customerInfo.SetActive(false);
    }

    public void ActivateCustomerMap() {
        inicio.SetActive(false);
        method.SetActive(false);
        customerM.SetActive(false);
        customerInfo.SetActive(true);

        neutralEnviroment.SetActive(false);
        cjmEnviroment.SetActive(true);

    }

    public void PlayStopVideo() {
        if (isPlaying) {
            vp.Pause();
        } else {
            vp.Play();
        }
        isPlaying = !isPlaying;
    }

    public void JumpToFrame(Slider s) {
        vp.Pause();
        vp.frame = (int) s.value;
        vp.Play();
        isPlaying = true;
    }
}
