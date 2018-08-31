using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingFx : MonoBehaviour {

    [SerializeField] [Range(0f, 0.5f)] private float range;
    private float r;
    private float initialY;

    private void Awake() {
        r = Random.Range(0f, 5f);
        initialY = transform.position.y;
    }

    void Update () {
        r += Time.deltaTime;
        float y = initialY + Mathf.Sin(r) * range;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
	}
}
