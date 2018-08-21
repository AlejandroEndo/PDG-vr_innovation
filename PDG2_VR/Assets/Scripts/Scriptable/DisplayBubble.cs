using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayBubble : MonoBehaviour {

    [SerializeField] private ScriptableBubble bubble;
    public TextMeshPro tittle;
    [SerializeField] private GameObject draw;

    void Start() {

        if (tittle != null) tittle.text = bubble.tittle;
        if (draw != null) {
            GameObject go = Instantiate(bubble.draw);
            go.transform.SetParent(draw.transform);
            go.transform.position = draw.transform.position;
            go.transform.localRotation = draw.transform.rotation;

            go.gameObject.AddComponent<ResponsiveObject>();
        }
    }

}
