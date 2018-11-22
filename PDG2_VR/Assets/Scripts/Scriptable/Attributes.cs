using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Attributes : MonoBehaviour {

    [Header("Scriptable Settings")]
    [SerializeField] private ScriptableBubble bubble;

    [Header("Type")]
    public string color;

    [Header("Forward")]
    public TextMeshPro nameF;
    public TextMeshPro description;
    public GameObject draw;

    [HideInInspector]public string newNameF;
    [HideInInspector] public string newDescription;

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
        nameF.text = newNameF;
        description.text = newDescription;

        nameR.text = bubble.tittleR;
        nameB.text = bubble.tittleB;
        nameL.text = bubble.tittleL;

        valueTextR.text = valueR.ToString();
        valueTextB.text = valueB.ToString();
        valueTextL.text = valueL.ToString();
    }

    public  void SetValueRight(int value) {
        valueR = value;
        valueTextR.text = valueR.ToString();
    }

    public void SetValueBackward(int value) {
        valueB = value;
        valueTextB.text = valueB.ToString();
    }

    public void SetValueLeft(int value) {
        valueL = value;
        valueTextL.text = valueL.ToString();
    }

}
