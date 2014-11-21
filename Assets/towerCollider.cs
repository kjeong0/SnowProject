using UnityEngine;
using System.Collections;

public class towerCollider : MonoBehaviour {
	public GameObject door;
	public GameObject sounds;
	Animator animator;

	void OnTriggerEnter (Collider other){
		animator = door.GetComponent<Animator>();
		AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);

		if (!(state.nameHash == Animator.StringToHash("Base Layer.Close"))){
			Debug.Log ("close");
			animator.SetTrigger (Animator.StringToHash("CloseMe"));
		}
		if (!sounds.activeSelf){
			sounds.SetActive(true);
		}
	}
}
