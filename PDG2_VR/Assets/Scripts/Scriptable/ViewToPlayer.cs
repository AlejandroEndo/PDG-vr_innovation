using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewToPlayer : MonoBehaviour {

    [SerializeField] private Transform player;
	
	void Start () {
		
	}
	
	
	void Update () {
        //if(transform.parent.CompareTag(""))
        transform.LookAt(player.position);
	}
}
