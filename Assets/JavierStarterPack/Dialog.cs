using UnityEngine;
using System.Collections;

public class Dialog : MonoBehaviour {

	public GUIStyle style = new GUIStyle(); //I made the GUI Style public so you can add customizations to your Text Box
	public bool dialog;
	public string words;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") { // If I enter the dialog cube
			dialog = true; //Set dialog to true so the GUI box can work
		}
	}
	void OnTriggerExit(Collider other){ //If I leave dialog cube
		dialog = false; //Set dialog to false so the GUI box can disappear
	}

	void OnGUI(){
		if (dialog == true) {
			GUI.Box (new Rect (Screen.width / 1000, Screen.height / 2, 1000, 20), words, style); //You can mess around with this if you like.
			//Rect API is new Rect(position x, position y, the width of the rect and the height of the rect) Very simple
		}
	}
}
