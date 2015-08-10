using UnityEngine;
using System.Collections;

public class Texturizer : MonoBehaviour
{

    //assigning texture locations to string
    string archives = "file:///C:/Users/nvandessel/_Unity/WebGL/Assets/Standard%20Assets/Sprites/Photospheres/archives.jpg";
    string greatHall = "file:///C:/Users/nvandessel/_Unity/WebGL/Assets/Standard%20Assets/Sprites/Photospheres/greathall.jpg";
    string greatHallStairs = "file:///C:/Users/nvandessel/_Unity/WebGL/Assets/Standard%20Assets/Sprites/Photospheres/greathallstairs.jpg";
    string CableHOF = "file:///C:/Users/nvandessel/_Unity/WebGL/Assets/Standard%20Assets/Sprites/Photospheres/chof.jpg";
    string barcoLibrary = "file:///C:/Users/nvandessel/_Unity/WebGL/Assets/Standard%20Assets/Sprites/Photospheres/barcolibrary.jpg";
    string secFloorMez = "file:///C:/Users/nvandessel/_Unity/WebGL/Assets/Standard%20Assets/Sprites/Photospheres/secondfloorwindowrampgreathall.jpg";
    string thrdFloorMez = "file:///C:/Users/nvandessel/_Unity/WebGL/Assets/Standard%20Assets/Sprites/Photospheres/thirdfloor.jpg";
    string theatreMez = "file:///C:/Users/nvandessel/_Unity/WebGL/Assets/Standard%20Assets/Sprites/Photospheres/malonetheater.jpg";
    string theatreStg = "";
    string hubLounge = "file:///C:/Users/nvandessel/_Unity/WebGL/Assets/Standard%20Assets/Sprites/Photospheres/hublounge.jpg";


    //creating objs to reference in script
    public GameObject sph_Archive;
    public GameObject sph_gHall;
    public GameObject sph_gHallStrs;
    public GameObject sph_chof;
    public GameObject sph_barcoLib;
    public GameObject sph_secFlrMez;
    public GameObject sph_thrdFlrMez;
    public GameObject sph_theatreStg;
    public GameObject sph_theatreMez;
    public GameObject sph_HubLounge;


    // Use this for initialization
    void Start()
    {
        //starts download of given URL
        WWW archv = new WWW(archives);
        WWW gHall = new WWW(greatHall);
        WWW gHallStrs = new WWW(greatHallStairs);
        WWW chof = new WWW(CableHOF);
        WWW barco = new WWW(barcoLibrary);
        WWW secFlrMez = new WWW(secFloorMez);
        WWW thrdFlrMez = new WWW(thrdFloorMez);
        WWW thtrMez = new WWW(theatreMez);
        WWW thtrStg = new WWW(theatreStg);
        WWW hubLnge = new WWW(hubLounge);

        StartCoroutine(WaitForRequest(archv, gHall, gHallStrs, chof, barco, secFlrMez, thrdFlrMez, thtrMez, thtrStg, hubLnge));
    }

    IEnumerator WaitForRequest(WWW archv, WWW gHall, WWW gHallStrs, WWW chof, WWW barco, WWW secFlrMez, WWW thrdFlrMez, WWW thtrMez, WWW thtrStg, WWW hubLnge)
    {
        //waits for download to finish
        yield return archv;
        yield return gHall;
        yield return gHallStrs;
        yield return chof;
        yield return barco;
        yield return secFlrMez;
        yield return thrdFlrMez;
        yield return thtrMez;
        yield return thtrStg;
        yield return hubLnge;

        //check for errors - if none apply texture
        //archives
        if (archv.error == null)
        {
            Debug.Log("WWW.archv OK!");
            sph_Archive.GetComponent<Renderer>().material.mainTexture = archv.texture;
        }
        else
        {
            Debug.Log("WWW.archv Error: " + archv.error);
        }

        //great hall
        if (gHall.error == null)
        {
            Debug.Log("WWW.gHall OK!");
            sph_gHall.GetComponent<Renderer>().material.mainTexture = gHall.texture;
        }
        else
        {
            Debug.Log("WWW.gHall Error: " + gHall.error);
        }

        //great hall stairs
        if (gHallStrs.error == null)
        {
            Debug.Log("WWW.gHallStrs OK!");
            sph_gHallStrs.GetComponent<Renderer>().material.mainTexture = gHallStrs.texture;
        }
        else
        {
            Debug.Log("WWW.gHallStrs Error: " + gHallStrs.error);
        }

        //cable hall of fame
        if (chof.error == null)
        {
            Debug.Log("WWW.chof OK!");
            sph_chof.GetComponent<Renderer>().material.mainTexture = chof.texture;
        }
        else
        {
            Debug.Log("WWW.chof Error: " + chof.error);
        }

        //barco library
        if (barco.error == null)
        {
            Debug.Log("WWW.barco OK!");
            sph_barcoLib.GetComponent<Renderer>().material.mainTexture = barco.texture;
        }
        else
        {
            Debug.Log("WWW.barco Error: " + barco.error);
        }

        //second floor mez
        if (secFlrMez.error == null)
        {
            Debug.Log("WWW.secFlrMez OK!");
            sph_secFlrMez.GetComponent<Renderer>().material.mainTexture = secFlrMez.texture;
        }
        else
        {
            Debug.Log("WWW.secFlrMez Error: " + secFlrMez.error);
        }

        //third floor mez
        if (thrdFlrMez.error == null)
        {
            Debug.Log("WWW.thrdFlrMez OK!");
            sph_thrdFlrMez.GetComponent<Renderer>().material.mainTexture = thrdFlrMez.texture;
        }
        else
        {
            Debug.Log("WWW.thrdFlrMez Error: " + thrdFlrMez.error);
        }

        //theatre mez
        if (thtrMez.error == null)
        {
            Debug.Log("WWW.thtrMez OK!");
            sph_theatreMez.GetComponent<Renderer>().material.mainTexture = thtrMez.texture;
        }
        else
        {
            Debug.Log("WWW.thtrMez Error: " + thtrMez.error);
        }

        //theatre stage
        if (thtrStg.error == null)
        {
            Debug.Log("WWW.thtrStg OK!");
            sph_theatreStg.GetComponent<Renderer>().material.mainTexture = thtrStg.texture;
        }
        else
        {
            Debug.Log("WWW.thtrStg Error: " + thtrStg.error);
        }

        //hub lounge
        if (hubLnge.error == null)
        {
            Debug.Log("WWW.hubLnge OK!");
            sph_HubLounge.GetComponent<Renderer>().material.mainTexture = hubLnge.texture;
        }
        else
        {
            Debug.Log("WWW.hubLnge Error: " + hubLnge.error);
        }
    }
    
}
