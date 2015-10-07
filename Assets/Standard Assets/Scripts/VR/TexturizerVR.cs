using System.Collections;
using UnityEngine;

public class TexturizerVR : MonoBehaviour
{
    public GameObject transitionSphr;

    //assigning texture locations to string
    string _archives = "farm1.staticflickr.com/740/20035140704_f7bd601cf7_o_d.jpg";
    string _greatHall = "farm1.staticflickr.com/655/20648504172_46f7c716c9_o_d.jpg";
    string _greatHallStairs = "farm1.staticflickr.com/705/20470954679_6fdb53c753_o_d.jpg";
    string _cableHof = "farm1.staticflickr.com/770/20657697125_2296e52091_o_d.jpg";
    string _barcoLibrary = "farm1.staticflickr.com/735/20470956039_a9ce4371d3_o_d.jpg";
    string _secFloorMez = "farm1.staticflickr.com/777/20469692740_b8bbae72cd_o_d.jpg";
    string _thrdFloorMez = "farm6.staticflickr.com/5640/20035138504_739dd2dbec_o_d.jpg";
    string _theatreMez = "farm1.staticflickr.com/635/20470954379_2279fa017f_o_d.jpg";
    string _theatreStg = "";
    string _hubLounge = "farm6.staticflickr.com/5703/20648503922_1773d1ff77_o_d.jpg";


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


    void Start()
    {
        //starts download of given URL
        WWW archv = new WWW(_archives);
        WWW gHall = new WWW(_greatHall);
        WWW gHallStrs = new WWW(_greatHallStairs);
        WWW chof = new WWW(_cableHof);
        WWW barco = new WWW(_barcoLibrary);
        WWW secFlrMez = new WWW(_secFloorMez);
        WWW thrdFlrMez = new WWW(_thrdFloorMez);
        WWW thtrMez = new WWW(_theatreMez);
        WWW thtrStg = new WWW(_theatreStg);
        WWW hubLnge = new WWW(_hubLounge);

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

        transitionSphr.GetComponent<PanoTransitionVR>().downScale = true;
        gameObject.GetComponent<IntroScriptVR>().StartFlyby();

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
