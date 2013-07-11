using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour
{
	public Texture2D crosshairImage;

	void Awake()
	{
       // crosshairImage = Resources.Load ("myImage");
	}

	void OnGUI(){
		//GUI.DrawTexture (Rect (Screen.width*.1, (Screen.height/2)-(((Screen.width*.8)/1.6)/2)-20, Screen.width*.8, (Screen.width*.8)/1.6), crosshairImage);   
	}
}
