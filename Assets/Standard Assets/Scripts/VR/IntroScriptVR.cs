using UnityEngine;

public class IntroScriptVR : MonoBehaviour
{

    public GameObject plyr;
    public GameObject hud;
    public GameObject cam;
    public GameObject vrMouse;

    void Update()
    {
        Vector3 gh = new Vector3(0, 0, 0);

        if (plyr.gameObject.transform.position == gh)
        {
            hud.GetComponent<Animator>().enabled = true;
            hud.GetComponent<Animator>().SetBool("HUDswitch", true);
            plyr.GetComponent<Animator>().enabled = false;

            gameObject.GetComponent<IntroScriptVR>().enabled = false;
        }
    }

    public void StartFlyby()
    {
        plyr.GetComponent<Animator>().SetBool("flyby", true);
        hud.GetComponent<Animator>().enabled = false;
    }

}
