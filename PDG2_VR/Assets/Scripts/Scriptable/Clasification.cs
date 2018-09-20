using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clasification : MonoBehaviour {

    [SerializeField] private string postItTag;
    [SerializeField] private GameObject[] toSort;

    public List<PostIt> postITSorter = new List<PostIt>();

    [SerializeField] bool organizar;

    [System.Serializable]
    public class PostIt : IComparable<PostIt> {

        public int value { get; set; }
        public GameObject postit { get; set; }

        public int CompareTo(PostIt other) {
            if (this.value > other.value) return 1;
            else if (this.value < other.value) return -1;
            else return 0;
        }
    }


    void Start() {
        organizar = false;
    }

    void Update() {
        if (organizar) {
            postITSorter.Clear();
            toSort = GameObject.FindGameObjectsWithTag(postItTag);
            Sort();
            //Organizar();
            organizar = false;
        }
    }

    private void Sort() {
        for (int i = 0; i < toSort.Length; i++) {
            PostIt p = new PostIt();
            int side = toSort[i].GetComponent<ViewToPlayer>().index;
            int sideValue = 0;

            switch (side) {
                case 1: // Right
                    sideValue = toSort[i].GetComponent<Attributes>().valueR;
                    break;

                case 2: // Backward
                    sideValue = toSort[i].GetComponent<Attributes>().valueB;
                    break;

                case 3: // Left
                    sideValue = toSort[i].GetComponent<Attributes>().valueL;
                    break;
            }

            p.value = sideValue;
            p.postit = toSort[i];

            postITSorter.Add(p);

        }

        postITSorter.Sort();
        postITSorter.Reverse();

        for (int i = 0; i < postITSorter.Count; i++) {
            Debug.Log("[LIST VALUES: " + postITSorter[i].value +"]");
            toSort[i] = postITSorter[i].postit;
        }

        for (int i = 0; i < toSort.Length; i++) {
            Debug.Log("[ARRAY VALUES: " + toSort[i].GetComponent<Attributes>().valueR + "]");
        }

        Organizar();

    }

    private void Organizar() {
        Debug.Log("[ORGANIZANDO]");

        for (int i = 0; i < toSort.Length; i++) {
            //Debug.Log(toSort[i].GetComponent<Attributes>().valueR);
            Transform a = toSort[i].transform;

            if (toSort.Length < 4) {

                int l = (int)-1 * (toSort.Length / 2);
                a.position = new Vector3(l + i + transform.position.x, +transform.position.y,
                    transform.position.z);

            } else {

                if (i < toSort.Length / 2) {
                    int l = (int)-1 * (toSort.Length / 4);
                    a.position = new Vector3(l + i + +transform.position.x, -0.5f + transform.position.y,
                        transform.position.z);
                } else {
                    int l = (int)-1 * (toSort.Length / 4);
                    a.position = new Vector3(l + (i - toSort.Length / 2) + transform.position.x, 0.5f
                        + transform.position.y, +transform.position.z);
                }
            }
        }
        Debug.Log("[ORGANIZADO]");
    }
}
