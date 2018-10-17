using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Attributes : MonoBehaviour {

    [Header("Scriptable Settings")]
    [SerializeField] private ScriptableBubble bubble;

    [Header("Forward")]
    public TextMeshPro nameF;
    public TextMeshPro description;
    public GameObject draw;

    [Header("Right")]
    public TextMeshPro nameR;
    public TextMeshPro valueTextR;
    [Range(0, 10)] public int valueR;

    [Header("Backward")]
    public TextMeshPro nameB;
    public TextMeshPro valueTextB;
    [Range(0, 10)] public int valueB;

    [Header("Left")]
    public TextMeshPro nameL;
    public TextMeshPro valueTextL;
    [Range(0,10)] public int valueL;

    void Start () {
        valueTextR.text = valueR.ToString();
        valueTextB.text = valueB.ToString();
        valueTextL.text = valueL.ToString();
    }

    private void SetValueRight(int value) {
        valueR = value;
        valueTextR.text = valueR.ToString();
    }

    private void SetValueBackward(int value) {
        valueB = value;
        valueTextB.text = valueB.ToString();
    }

    private void SetValueLeft(int value) {
        valueL = value;
        valueTextL.text = valueL.ToString();
    }

}
