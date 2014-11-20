using UnityEngine;
using System.Collections;

public class RevealNoneuclidian : MonoBehaviour {
	public GameObject roof;
	public GameObject nonEuclidian;
	public GameObject walkingWood;
	
	void OnTriggerEnter (Collider other){
		if (roof.activeSelf){
			roof.SetActive (false);
			nonEuclidian.SetActive (true);
			walkingWood.SetActive (true);
		}
	}
}
