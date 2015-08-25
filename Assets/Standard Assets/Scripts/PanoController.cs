using UnityEngine;

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
    private bool _gHall = false;
    private bool _gHallStairs = false;
    private bool _secFlrMez = false;
    private bool _thrdFlrMez = false;
    private bool _chof = false;
    private bool _bLib = false;
    private bool _archv = false;
    private bool _hubLng = false;
    private bool _theatreMez = false;
    private bool _theatreStg = false;


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
            _gHall = true;
        }
        else if (panoTimer >= transitionTime && _gHall == true)
        {
            toGH();
            StartTimer = false;
            _gHall = false;
            panoTimer = 0;
        }

        //go to stairs
        if (Input.GetKey(KeyCode.Keypad1))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _gHallStairs = true;
        }
        else if (panoTimer >= transitionTime && _gHallStairs == true)
        {
            toGHstairs();
            StartTimer = false;
            _gHallStairs = false;
            panoTimer = 0;
        }

        //go to chof
        if (Input.GetKey(KeyCode.Keypad2))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _chof = true;
        }
        else if (panoTimer >= transitionTime && _chof == true)
        {
            toCHOF();
            StartTimer = false;
            _chof = false;
            panoTimer = 0;
        }

        //go to barco library
        if (Input.GetKey(KeyCode.Keypad3))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _bLib = true;
        }
        else if (panoTimer >= transitionTime && _bLib == true)
        {
            toBarcoLib();
            StartTimer = false;
            _bLib = false;
            panoTimer = 0;
        }

        //go to second floor mez
        if (Input.GetKey(KeyCode.Keypad4))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _secFlrMez = true;
        }
        else if (panoTimer >= transitionTime && _secFlrMez == true)
        {
            toScndflrMez();
            StartTimer = false;
            _secFlrMez = false;
            panoTimer = 0;
        }

        //got to third floor mez
        if (Input.GetKey(KeyCode.Keypad5))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _thrdFlrMez = true;
        }
        else if (panoTimer >= transitionTime && _thrdFlrMez == true)
        {
            toThrdflrMez();
            StartTimer = false;
            _thrdFlrMez = false;
            panoTimer = 0;
        }

        //go to archives
        if (Input.GetKey(KeyCode.Keypad6))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _archv = true;
        }
        else if (panoTimer >= transitionTime && _archv == true)
        {
            toArchives();
            StartTimer = false;
            _archv = false;
            panoTimer = 0;

        }

        //go to hub lounge
        if (Input.GetKey(KeyCode.Keypad7))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _hubLng = true;
        }
        else if (panoTimer >= transitionTime && _hubLng == true)
        {
            toHub();
            StartTimer = false;
            _hubLng = false;
            panoTimer = 0;
        }

        //go to theatre mez
        if (Input.GetKey(KeyCode.Keypad8))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _theatreMez = true;
        }
        else if (panoTimer >= transitionTime && _theatreMez == true)
        {
            toThtrMez();
            StartTimer = false;
            _theatreMez = false;
            panoTimer = 0;
        }

        //go to theatre stage
        if (Input.GetKey(KeyCode.Keypad9))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _theatreStg = true;
        }
        else if (panoTimer >= transitionTime && _theatreStg == true)
        {
            toThtrStg();
            StartTimer = false;
            _theatreStg = false;
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
