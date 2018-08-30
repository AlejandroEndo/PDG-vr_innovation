using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponsiveManager : MonoBehaviour {

    [Header("Text Configuration")]
    [SerializeField] private RectTransform textTransform;

    [SerializeField] private float minSize;

    private float initialWidth;
    private float initialHeight;

    private float width;
    private float height;

    [Header("Object configuration")]
    [SerializeField] private Transform go;

    void Start() {
        initialWidth = textTransform.sizeDelta.x;
        initialHeight = textTransform.sizeDelta.y;
    }

    void Update() {
        if (transform.localScale.x < minSize || transform.localScale.y < minSize || transform.localScale.z < minSize) {
            transform.localScale = new Vector3(minSize, minSize, minSize);
        }

        width = initialWidth * transform.localScale.x;
        height = initialHeight * transform.localScale.y;

        //if (width < textTransformScale && height < textTransformScale) {
            textTransform.localScale = new Vector3(1 / transform.localScale.x, 1 / transform.localScale.y, 1 / transform.localScale.z);

            textTransform.sizeDelta = new Vector2(width, height * 0.8f);
        //} else Debug.Log("Matilda");
    }
}
