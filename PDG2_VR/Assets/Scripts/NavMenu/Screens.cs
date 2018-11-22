using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screens : MonoBehaviour {

    [SerializeField] private GameObject inicio;
    [SerializeField] private GameObject method;
    [SerializeField] private GameObject customerM;

    void Start () {
		
	}
	
	void Update () {
		
	}

    public void DisplayMethods() {
        inicio.SetActive(false);
        method.SetActive(true);
    }

    public void DisplayCustomerMap() {
        method.SetActive(false);
        customerM.SetActive(true);
    }

    public void ActivateCustomerMap() {
        Debug.Log("COMENZÓ LO BUENO HPTA");
    }
}
