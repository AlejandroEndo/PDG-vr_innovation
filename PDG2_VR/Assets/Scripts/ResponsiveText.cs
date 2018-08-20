using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponsiveText : MonoBehaviour {

    [SerializeField]private RectTransform textTransform;

    private float initialWidth;
    private float initialHeight;

    private float width;
    private float height;

	void Start () {
        initialWidth = textTransform.sizeDelta.x;
        initialHeight = textTransform.sizeDelta.y;
	}
	
	void Update () {
        textTransform.localScale = new Vector3(1 / transform.localScale.x, 1 / transform.localScale.y, 1 / transform.localScale.z);

        width = initialWidth * transform.localScale.x;
        height = initialHeight * transform.localScale.y;

        textTransform.sizeDelta = new Vector2(width, height);
	}
}
