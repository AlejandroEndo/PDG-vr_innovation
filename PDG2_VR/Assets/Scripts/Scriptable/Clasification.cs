using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clasification : MonoBehaviour {

    [SerializeField] private GameObject[] postits;
    [SerializeField] private bool ordenar;
    [SerializeField] [Range(0, 2)] int face;

    void Start () {
        Seek();
	}
	
	void Update () {
        if (ordenar) {
            ordenar = false;


        }
	}

    private void Seek() {
        postits = GameObject.FindGameObjectsWithTag("PostIt");
    }
}
