using UnityEngine;
using System.Collections;

public class Knife : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("trigger enter");
	}
//
//
//	void OnTriggerStay(Collider other) {
////		Debug.Log ("trigger stay");
//	}
//
//	void OnTriggerExit(Collider other) {
////		Debug.Log ("trigger exit");
//	}
	void OnCollisionStay (Collision collision) {

		if(collision.transform.name == "Apple"){

			Debug.Log (collision.transform.name + " : " + collision.contacts.Length.ToString());
			for (int aIndex = 0; aIndex < collision.contacts.Length; ++ aIndex) {
				// for debug
				Debug.Log(collision.contacts[aIndex].point);
				GameObject.Find("Decoi").transform.position = collision.contacts[aIndex].point;
			}
		}
	}
}
