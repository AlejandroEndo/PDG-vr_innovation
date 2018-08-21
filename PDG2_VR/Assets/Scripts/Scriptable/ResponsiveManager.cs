﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponsiveManager : MonoBehaviour {

    [Header("Text Configuration")]
    [SerializeField] private RectTransform textTransform;

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
        if (transform.localScale.x < 1.3f || transform.localScale.y < 1.3f || transform.localScale.z < 1.3f) {
            transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
        }

        width = initialWidth * transform.localScale.x;
        height = initialHeight * transform.localScale.y;

        if (width < 2.5f && height < 2.5f) {
            textTransform.localScale = new Vector3(1 / transform.localScale.x, 1 / transform.localScale.y, 1 / transform.localScale.z);

            textTransform.sizeDelta = new Vector2(width, height * 0.8f);
        } else Debug.Log("Matilda");
    }
}
