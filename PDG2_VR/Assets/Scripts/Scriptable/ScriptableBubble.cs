using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Post-it", menuName = "Bubbles/PostIt")]
public class ScriptableBubble : ScriptableObject {

    [Header("Forward")]
    public string tittle;
    public string description;
    public GameObject draw;

    [Header("Right")]
    public string tittleR;

    [Header("Backward")]
    public string tittleB;

    [Header("Left")]
    public string tittleL;

}
