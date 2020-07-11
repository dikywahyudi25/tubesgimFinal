using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2winFinish5 : MonoBehaviour
{
 void OnTriggerEnter2D(Collider2D other){
 	if (other.tag == "player2") {
 		Application.LoadLevel(25);
 		return;
 	}
 	if(other.gameObject.transform.parent){
 		Destroy (other.gameObject.transform.parent.gameObject);

 	}else{
 		Destroy (other.gameObject);
 	}
 }
}
