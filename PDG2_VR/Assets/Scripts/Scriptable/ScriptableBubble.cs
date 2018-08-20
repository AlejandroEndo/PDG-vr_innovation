using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Post-it", menuName = "Bubbles/PostIt")]
public class ScriptableBubble : ScriptableObject {

    public string tittle;
    public string description;

    public GameObject draw;

}
