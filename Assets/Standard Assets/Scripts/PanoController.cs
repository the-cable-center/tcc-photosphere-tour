using UnityEngine;
using System.Collections;

public class PanoController : MonoBehaviour
{

	//locations
	private Vector3 gh = new Vector3 (0, 0, 0);
	private Vector3 ghStairs = new Vector3 (100, 50, 0);
	private Vector3 chof = new Vector3 (100, 100, -100);
	private Vector3 barcolib = new Vector3 (200, 0, -100);
	private Vector3 scndflrmez = new Vector3 (-100, 100, 0);
	private Vector3 thrdflrmez = new Vector3 (0, 200, -100);


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		PanoSwitcher ();
	}

	void PanoSwitcher ()
	{
		//go to great hall
		if (Input.GetKey (KeyCode.G)) {
			toGH ();
		}
		//go to stairs
		if (Input.GetKey (KeyCode.S)) {
			toGHstairs ();
		}
		//go to chof
		if (Input.GetKey (KeyCode.C)) {
			toCHOF ();
		}
		//go to barco library
		if (Input.GetKey (KeyCode.B)) {
			toBarcoLib ();
		}
	}

	public void toGHstairs ()
	{
		transform.position = ghStairs;
	}

	public void toGH ()
	{	
		transform.position = gh;
	}

	public void toCHOF ()
	{
		transform.position = chof;
	}

	public void toBarcoLib ()
	{
		transform.position = barcolib;
	}

	public void toScndflrmez ()
	{
		transform.position = scndflrmez;
	}

	public void toThrdflrmez ()
	{
		transform.position = thrdflrmez;
	}
}
