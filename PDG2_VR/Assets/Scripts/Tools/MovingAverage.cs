using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAverage : MonoBehaviour {

    private Rigidbody rb;

    [SerializeField] [Range(0, 100)] int range;

    [SerializeField] private List<Vector3> posiciones;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        if (range == 0) return;

        if (posiciones.Count < range) {
            posiciones.Add(transform.position);
        } else {
            Vector3 newPos = CalculateAverage(posiciones, transform.position);
            transform.position = newPos;
        }
    }

    private Vector3 CalculateAverage(List<Vector3> positions, Vector3 newPosition) {

        positions.RemoveAt(0);
        positions.Add(newPosition);

        float xTotal = 0f;
        float yTotal = 0f;
        float zTotal = 0f;

        if (positions.Count > range) {
            for (int i = 0; i < positions.Count - range; i++) {
                positions.RemoveAt(0);
            }
        }

        for (int i = 0; i < positions.Count; i++) {

            xTotal += positions[i].x;
            yTotal += positions[i].y;
            zTotal += positions[i].z;
        }

        xTotal = xTotal / positions.Count;
        yTotal = yTotal / positions.Count;
        zTotal = zTotal / positions.Count;

        return new Vector3(xTotal, yTotal, zTotal);
    }
}
