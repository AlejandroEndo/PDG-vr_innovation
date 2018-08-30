using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewToPlayer : MonoBehaviour {

    [SerializeField] private Transform player;
	
	void Start () {
		
	}
	
	
	void Update () {
        this.transform.LookAt(player.position);
	}
}
