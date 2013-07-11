using UnityEngine;

using System.Collections;

using System.Collections.Generic;



public class CameraUpdate : MonoBehaviour
{

	/*
 
    This script is used to average the mouse input over x 
 
    amount of frames in order to create a smooth mouselook.
 
    */

	private GameObject player;

	void Awake ()
	{
		
		player = GameObject.FindGameObjectWithTag(DoneTags.player);
	
		positionCamera();
	}



	void Update ()
	{
		positionCamera();
	}



	private void positionCamera()
	{
		//transform.rotation = player.transform.rotation;
		transform.position = player.transform.position + new Vector3(0, 2.2f, 0);
		transform.Translate (Vector3.forward * -1);
		//transform.forward -= Vector3.forward;
	}
}