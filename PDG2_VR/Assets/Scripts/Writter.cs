using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;


public class Writter : VRTK_InteractableObject {

    public Whiteboard whiteboard;
    public WallBoard wallboard;
    private RaycastHit touch;
    private Quaternion lastAngle;
    private bool lastTouch;
    public GameObject floor;

    // Use this for initialization
    void Start() {

        this.whiteboard = GameObject.Find("Whiteboard").GetComponent<Whiteboard>();

        GetComponent<VRTK_ControllerEvents>().TriggerPressed += new ControllerInteractionEventHandler(DoTriggerPressed);
    }

    private void DoTriggerPressed(object sender, ControllerInteractionEventArgs e) {

        floor.SetActive(false);
    }

    void Update() {
        float tipHeight = transform.Find("Tip").transform.localScale.y;
        Vector3 tip = transform.Find("Tip/TouchPoint").transform.position;
        whiteboard.SetPenSize(10);
        //Debug.Log(tip);

        if (lastTouch) {
            tipHeight *= 1.1f;
        }

        if (Physics.Raycast(tip, transform.up, out touch, tipHeight)) {
            if (touch.collider.tag == "Wallboard") {
                this.wallboard = touch.collider.GetComponent<WallBoard>();

                wallboard.SetColor(Color.black);
                wallboard.SetTouchPosition(touch.textureCoord.x, touch.textureCoord.y);
                wallboard.ToggleTouch(true);

                if (lastTouch == false) {
                    lastTouch = true;
                    lastAngle = transform.rotation;
                }
            } else if (touch.collider.tag == "Whiteboard") {
                this.whiteboard = touch.collider.GetComponent<Whiteboard>();

                whiteboard.SetColor(Color.black);
                whiteboard.SetTouchPosition(touch.textureCoord.x, touch.textureCoord.y);
                whiteboard.ToggleTouch(true);

                if (lastTouch == false) {
                    lastTouch = true;
                    lastAngle = transform.rotation;
                }
            }
        } else {
            whiteboard.ToggleTouch(false);
            lastTouch = false;
        }


        if (lastTouch) {
            transform.rotation = lastAngle;
        }
    }


}
