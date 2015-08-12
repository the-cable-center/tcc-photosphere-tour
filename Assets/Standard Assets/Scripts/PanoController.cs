using UnityEngine;
using System.Collections;

public class PanoController : MonoBehaviour
{
    public GameObject transitionSphr;

    //timer setup
    public float transitionTime;
    private bool StartTimer;
    public float panoTimer;

    //locations
    private Vector3 gh = new Vector3(0, 0, 0);
    private Vector3 ghStairs = new Vector3(100, 50, 0);
    private Vector3 scndflrMez = new Vector3(-100, 100, 0);
    private Vector3 thrdflrMez = new Vector3(0, 200, -100);
    private Vector3 chof = new Vector3(100, 100, -100);

    private Vector3 barcolib = new Vector3(200, 0, -100);
    private Vector3 archives = new Vector3(-100, -100, 0);
    private Vector3 hub = new Vector3(200, 100, -100);
    private Vector3 thtrMez = new Vector3(200, 100, 100);
    private Vector3 thtrStg = new Vector3(200, 0, 200);

    //transfer bools
    private bool gHall = false;
    private bool gHallStairs = false;
    private bool secFlrMez = false;
    private bool thrdFlrMez = false;
    private bool CHOF = false;
    private bool bLib = false;
    private bool archv = false;
    private bool hubLng = false;
    private bool theatreMez = false;
    private bool theatreStg = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PanoSwitcher();
    }

    void FixedUpdate()
    {
        if (StartTimer)
        {
            panoTimer += Time.fixedDeltaTime;
            Debug.Log("panoTimer " + panoTimer);
        }
    }

    void PanoSwitcher()
    {
        //go to great hall
        if (Input.GetKey(KeyCode.Keypad0))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            gHall = true;
        }
        else if (panoTimer >= transitionTime && gHall == true)
        {
            toGH();
            StartTimer = false;
            gHall = false;
            panoTimer = 0;
        }

        //go to stairs
        if (Input.GetKey(KeyCode.Keypad1))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            gHallStairs = true;
        }
        else if (panoTimer >= transitionTime && gHallStairs == true)
        {
            toGHstairs();
            StartTimer = false;
            gHallStairs = false;
            panoTimer = 0;
        }

        //go to chof
        if (Input.GetKey(KeyCode.Keypad2))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            CHOF = true;
        }
        else if (panoTimer >= transitionTime && CHOF == true)
        {
            toCHOF();
            StartTimer = false;
            CHOF = false;
            panoTimer = 0;
        }

        //go to barco library
        if (Input.GetKey(KeyCode.Keypad3))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            bLib = true;
        }
        else if (panoTimer >= transitionTime && bLib == true)
        {
            toBarcoLib();
            StartTimer = false;
            bLib = false;
            panoTimer = 0;
        }

        //go to second floor mez
        if (Input.GetKey(KeyCode.Keypad4))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            secFlrMez = true;
        }
        else if (panoTimer >= transitionTime && secFlrMez == true)
        {
            toScndflrMez();
            StartTimer = false;
            secFlrMez = false;  
            panoTimer = 0;
        }

        //got to third floor mez
        if (Input.GetKey(KeyCode.Keypad5))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            thrdFlrMez = true;
        }
        else if (panoTimer >= transitionTime && thrdFlrMez == true)
        {
            toThrdflrMez();
            StartTimer = false;
            thrdFlrMez = false;
            panoTimer = 0;
        }

        //go to archives
        if (Input.GetKey(KeyCode.Keypad6))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            archv = true;
        }
        else if (panoTimer >= transitionTime && archv == true)
        {
            toArchives();
            StartTimer = false;
            archv = false;
            panoTimer = 0;

        }

        //go to hub lounge
        if (Input.GetKey(KeyCode.Keypad7))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            hubLng = true;
        }
        else if (panoTimer >= transitionTime && hubLng == true)
        {
            toHub();
            StartTimer = false;
            hubLng = false;
            panoTimer = 0;
        }

        //go to theatre mez
        if (Input.GetKey(KeyCode.Keypad8))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            theatreMez = true;
        }
        else if (panoTimer >= transitionTime && theatreMez == true)
        {
            toThtrMez();
            StartTimer = false;
            theatreMez = false;
            panoTimer = 0;
        }

        //go to theatre stage
        if (Input.GetKey(KeyCode.Keypad9))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            theatreStg = true;
        }
        else if (panoTimer >= transitionTime && theatreStg == true)
        {
            toThtrStg();
            StartTimer = false;
            theatreStg = false;
            panoTimer = 0;
        }
    }

    public void toGHstairs()
    {
        transform.position = ghStairs;
    }

    public void toGH()
    {
        transform.position = gh;
    }

    public void toCHOF()
    {
        transform.position = chof;
    }

    public void toBarcoLib()
    {
        transform.position = barcolib;
    }

    public void toScndflrMez()
    {
        transform.position = scndflrMez;
    }

    public void toThrdflrMez()
    {
        transform.position = thrdflrMez;
    }

    public void toArchives()
    {
        transform.position = archives;
    }

    public void toHub()
    {
        transform.position = hub;
    }

    public void toThtrMez()
    {
        transform.position = thtrMez;
    }

    public void toThtrStg()
    {
        transform.position = thtrStg;
    }

}
