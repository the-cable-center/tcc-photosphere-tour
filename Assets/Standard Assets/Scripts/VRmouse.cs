using UnityEngine;
using System.Collections;

public class VRmouse : MonoBehaviour
{
	public RaycastHit clickHit;
	public RaycastHit hoverHit;
	
	void FixedUpdate ()
	{
		Click ();
		Hover ();
	}

	void Click ()
	{
		Ray click = new Ray (transform.position, transform.forward);

		if (Input.GetMouseButtonDown (0)) {
			Debug.DrawRay (transform.position, transform.forward, Color.green);
		}
		if (Input.GetMouseButtonUp (0)) {
			if (Physics.Raycast(click, out clickHit, 65f)){
				print ("Click_Object Found!");
			}
		}
	}

	void Hover ()
	{
		Ray hov = new Ray (transform.position, transform.forward);

		Debug.DrawRay (transform.position, transform.forward, Color.red);
		if (Physics.Raycast(hov, out hoverHit, 65f)){
			print ("Click_Object Found!");
		}
	}
}
