using UnityEngine;
using System.Collections;

public class ObjRotation : MonoBehaviour
{
	public float rotateVel;


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void FixedUpdate ()
	{
		Rotate ();
	}

	void Rotate ()
	{
		transform.Rotate (Vector3.up * rotateVel);
	}
}
