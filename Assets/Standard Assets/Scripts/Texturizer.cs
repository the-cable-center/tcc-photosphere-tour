using UnityEngine;
using System.Collections;

public class Texturizer : MonoBehaviour {

	//assigning texture locations to string
	string archives = "file:///C:/Users/nvandessel/_Unity/WebGL/Assets/Standard%20Assets/Sprites/Photospheres/archives.jpg";


	// Use this for initialization
	void Start ()
	{
		//starts download of given URL
		WWW archv = new WWW(archives);

		StartCoroutine (WaitForRequest(archv));
	}

	IEnumerator WaitForRequest (WWW archv)
	{
		//waits for download to finish
		yield return archv;

		//check for errors
		if(archv.error == null)
		{
			Debug.Log ("WWW.archv OK!");


		} else {
			Debug.Log ("WWW.archv Error: " + archv.error);
		}
	}


		//assign downloaded image as texture of the object
		//archv.LoadImageIntoTexture(Renderer.material.mainTexture);

	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
