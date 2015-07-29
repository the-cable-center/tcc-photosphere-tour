using UnityEngine;
using System.Collections;

public class PanoController : MonoBehaviour
{
	public GameObject transitionSphr;



	//locations
	private Vector3 gh = new Vector3 (0, 0, 0);
	private Vector3 ghStairs = new Vector3 (100, 50, 0);
	private Vector3 scndflrMez = new Vector3 (-100, 100, 0);
	private Vector3 thrdflrMez = new Vector3 (0, 200, -100);
	private Vector3 chof = new Vector3 (100, 100, -100);

	private Vector3 barcolib = new Vector3 (200, 0, -100);
	private Vector3 archives = new Vector3 (-100, -100, 0);
	private Vector3 hub = new Vector3 (200, 100, -100);
	private Vector3 thtrMez = new Vector3 (200, 100, 100);
	private Vector3 thtrStg = new Vector3 (200, 0, 200);


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

	public void toScndflrMez ()
	{
		transform.position = scndflrMez;
	}

	public void toThrdflrMez ()
	{
		transform.position = thrdflrMez;
	}

	public void toArchives ()
	{
		transform.position = archives;
	}

	public void toHub ()
	{
		transform.position = hub;
	}

	public void toThtrMez ()
	{
		transform.position = thtrMez;
	}

	public void toThtrStg ()
	{
		transform.position = thtrStg;
	}

}
