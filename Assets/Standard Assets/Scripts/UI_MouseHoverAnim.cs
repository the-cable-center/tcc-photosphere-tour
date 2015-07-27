using UnityEngine;
using System.Collections;

public class UI_MouseHoverAnim : MonoBehaviour
{
	public bool mouseOver;

	private GameObject VRmouse;

	private Animator anim;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();

		VRmouse = GameObject.FindGameObjectWithTag ("vrMouse");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.Keypad1)) {
			anim.SetBool ("mouseOver", true);
		} else {
			anim.SetBool ("mouseOver", false);
		}

		if (VRmouse.GetComponent<VRmouse> ().hoverHit.collider.tag == "ArchiveModel"){
			anim.SetBool ("mouseOver", true);
		} else {
			anim.SetBool ("mouseOver", false);
		}
	}
	
/* 
	void OnMouseOver (Collider c)
	{
		if (c.gameObject.tag == "ArchiveModel") {
			anim.SetBool ("mouseOver", true);
		} else {
			anim.SetBool ("mouseOver", false);
		}
	}

	void OnMouseExit (Collider c)
	{
		if (c.gameObject.tag == "ArchiveModel") {
			anim.SetBool ("mouseOver", false);
		}
	}
*/

}
