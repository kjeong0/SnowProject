using UnityEngine;
using System.Collections;

public class WalkingScript : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if (getAnyKey (KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D)){
			fadeIn ();
		} else {
			fadeOut ();
		}
	}
	bool getAnyKey (params KeyCode[] aKeys){
		foreach(KeyCode key in aKeys){
			if (Input.GetKey(key)){
				return true;
			}
		}
		return false;
	}
	void fadeIn(){
		if (gameObject.audio.volume < 0.4){
			gameObject.audio.volume += 1f * Time.deltaTime;
		}
	}
	void fadeOut(){
		gameObject.audio.volume -= 1f * Time.deltaTime;
	}
}
