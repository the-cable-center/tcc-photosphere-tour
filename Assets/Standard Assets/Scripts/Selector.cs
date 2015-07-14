using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Selector : MonoBehaviour
{

	public GameObject plyr;

	public RaycastHit hit = new RaycastHit ();
	public Ray ray;

	// Use this for initialization
	void Start ()
	{
		plyr = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{
		Selection ();
	}

	void Selection ()
	{
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if (Input.GetKeyUp(KeyCode.Mouse0))
		{
			if (Physics.Raycast(ray,out hit,50))
			{
				if (hit.transform.tag == "ghStairs") 
				{
					plyr.GetComponent<PanoController>().toGHstairs ();
				}
			}
		}
	}
}
