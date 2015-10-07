using UnityEngine;

public class IntroScript : MonoBehaviour {

    public GameObject plyr;
    public GameObject hud;
    public GameObject cam;
    public GameObject vrMouse;

    void Start()
    {
        //vrMouse.GetComponent<Canvas>().renderer = cam;
    }

    void Update()
    {
        //print("local pos" + plyr.localPosition);

        Vector3 gh = new Vector3(0, 0, 0);

        if (plyr.gameObject.transform.position == gh)
        {
            hud.GetComponent<Animator>().enabled = true;
            hud.GetComponent<Animator>().SetBool("HUDswitch", true);
            plyr.GetComponent<MouseLook>().enabled = true;
            cam.GetComponent<MouseLook>().enabled = true;
            plyr.GetComponent<Animator>().enabled = false;

            gameObject.GetComponent<IntroScript>().enabled = false;
        }
    }

    public void StartFlyby()
    {
        plyr.GetComponent<Animator>().SetBool("flyby", true);
        hud.GetComponent<Animator>().enabled = false;
        plyr.GetComponent<MouseLook>().enabled = false;
        cam.GetComponent<MouseLook>().enabled = false;
    }

}
