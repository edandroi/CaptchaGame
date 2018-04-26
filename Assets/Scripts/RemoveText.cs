using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveText : MonoBehaviour {

	ButtonClick submitted;

	// Use this for initialization
	void Start () {
		submitted = GameObject.Find ("SubmitButton").GetComponent<ButtonClick> ();
	}
	
	// Deactivate the question text
	void Update () {
		if (submitted.submitted == true) {
			gameObject.SetActive(false);
		}
		
	}
}
