using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour {

    [SerializeField] private GameObject[] sliders;
    [SerializeField] private LineRenderer line;

    private void Start() {
        line = GetComponent<LineRenderer>();

        for (int i = 0; i < line.positionCount; i++) {
            line.SetPosition(i, sliders[i].transform.position);
        }
    }

    private void Update() {
        //line.SetPosition(2, new Vector3(0,0,0));
    }

    public void UpdateLinePosition(int tag, Vector3 pos) {
        if(line != null)
        line.SetPosition(tag, pos);
        //Debug.Log(sliders[tag].transform.position);
    }
}
