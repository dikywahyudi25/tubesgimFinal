﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1winFinish3 : MonoBehaviour
{
 void OnTriggerEnter2D(Collider2D other){
 	if (other.tag == "player1") {
 		Application.LoadLevel(20);
 		return;
 	}
 	if(other.gameObject.transform.parent){
 		Destroy (other.gameObject.transform.parent.gameObject);

 	}else{
 		Destroy (other.gameObject);
 	}
 }
}
