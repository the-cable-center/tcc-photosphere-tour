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
    private void Update()
    {

        if (panoTimer >= transitionTime)
        {
            PanoSwitcher();
        }
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
<<<<<<< HEAD
        if (_gHall)
=======
        if (Input.GetKey(KeyCode.Keypad0))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _gHall = true;
        }
        else if (panoTimer >= transitionTime && _gHall == true)
>>>>>>> feature_ObjGroupingRig
        {
            transform.position = gh;
            StartTimer = false;
            _gHall = false;
            panoTimer = 0;
        }

        //go to stairs
<<<<<<< HEAD
        if (_gHallStairs)
=======
        if (Input.GetKey(KeyCode.Keypad1))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _gHallStairs = true;
        }
        else if (panoTimer >= transitionTime && _gHallStairs == true)
>>>>>>> feature_ObjGroupingRig
        {
            transform.position = ghStairs;
            StartTimer = false;
            _gHallStairs = false;
            panoTimer = 0;
        }

        //go to chof
<<<<<<< HEAD
        if (_chof)
=======
        if (Input.GetKey(KeyCode.Keypad2))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _chof = true;
        }
        else if (panoTimer >= transitionTime && _chof == true)
>>>>>>> feature_ObjGroupingRig
        {
            transform.position = chof;
            StartTimer = false;
            _chof = false;
            panoTimer = 0;
        }

        //go to barco library
<<<<<<< HEAD
        if (_bLib)
=======
        if (Input.GetKey(KeyCode.Keypad3))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _bLib = true;
        }
        else if (panoTimer >= transitionTime && _bLib == true)
>>>>>>> feature_ObjGroupingRig
        {
            transform.position = barcolib;
            StartTimer = false;
            _bLib = false;
            panoTimer = 0;
        }

        //go to second floor mez
<<<<<<< HEAD
        if (_secFlrMez)
=======
        if (Input.GetKey(KeyCode.Keypad4))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _secFlrMez = true;
        }
        else if (panoTimer >= transitionTime && _secFlrMez == true)
>>>>>>> feature_ObjGroupingRig
        {
            transform.position = scndflrMez;
            StartTimer = false;
            _secFlrMez = false;
            panoTimer = 0;
        }

        //got to third floor mez
<<<<<<< HEAD
        if (_thrdFlrMez)
=======
        if (Input.GetKey(KeyCode.Keypad5))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _thrdFlrMez = true;
        }
        else if (panoTimer >= transitionTime && _thrdFlrMez == true)
>>>>>>> feature_ObjGroupingRig
        {
            transform.position = thrdflrMez;
            StartTimer = false;
            _thrdFlrMez = false;
            panoTimer = 0;
        }

        //go to archives
        if (_archv)
        {
<<<<<<< HEAD
            transform.position = archives;
=======
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _archv = true;
        }
        else if (panoTimer >= transitionTime && _archv == true)
        {
            toArchives();
>>>>>>> feature_ObjGroupingRig
            StartTimer = false;
            _archv = false;
            panoTimer = 0;
        }

        //go to hub lounge
<<<<<<< HEAD
        if (_hubLng)
=======
        if (Input.GetKey(KeyCode.Keypad7))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _hubLng = true;
        }
        else if (panoTimer >= transitionTime && _hubLng == true)
>>>>>>> feature_ObjGroupingRig
        {
            transform.position = hub;
            StartTimer = false;
            _hubLng = false;
            panoTimer = 0;
        }

        //go to theatre mez
        if (_theatreMez)
        {
<<<<<<< HEAD
            transform.position = thtrMez;
=======
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _theatreMez = true;
        }
        else if (panoTimer >= transitionTime && _theatreMez == true)
        {
            toThtrMez();
>>>>>>> feature_ObjGroupingRig
            StartTimer = false;
            _theatreMez = false;
            panoTimer = 0;
        }

        //go to theatre stage
<<<<<<< HEAD
        if (_theatreStg)
=======
        if (Input.GetKey(KeyCode.Keypad9))
        {
            StartTimer = true;
            transitionSphr.GetComponent<PanoTransition>().upScale = true;
            _theatreStg = true;
        }
        else if (panoTimer >= transitionTime && _theatreStg == true)
>>>>>>> feature_ObjGroupingRig
        {
            transform.position = thtrStg;
            StartTimer = false;
            _theatreStg = false;
            panoTimer = 0;

        }

    }


    public void toGH()
    {
        StartTimer = true;
        transitionSphr.GetComponent<PanoTransition>().upScale = true;
        _gHall = true;
    }

    public void toGHstairs()
    {
        StartTimer = true;
        transitionSphr.GetComponent<PanoTransition>().upScale = true;
        _gHallStairs = true;
    }

    public void toCHOF()
    {
        StartTimer = true;
        transitionSphr.GetComponent<PanoTransition>().upScale = true;
        _chof = true;
    }

    public void toBarcoLib()
    {
        StartTimer = true;
        transitionSphr.GetComponent<PanoTransition>().upScale = true;
        _bLib = true;
    }

    public void toScndflrMez()
    {
        StartTimer = true;
        transitionSphr.GetComponent<PanoTransition>().upScale = true;
        _secFlrMez = true;
    }

    public void toThrdflrMez()
    {
        StartTimer = true;
        transitionSphr.GetComponent<PanoTransition>().upScale = true;
        _thrdFlrMez = true;
    }

    public void toArchives()
    {
        StartTimer = true;
        transitionSphr.GetComponent<PanoTransition>().upScale = true;
        _archv = true;
    }

    public void toHub()
    {
        StartTimer = true;
        transitionSphr.GetComponent<PanoTransition>().upScale = true;
        _hubLng = true;
    }

    public void toThtrMez()
    {
        StartTimer = true;
        transitionSphr.GetComponent<PanoTransition>().upScale = true;
        _theatreMez = true;
    }

    public void toThtrStg()
    {
        StartTimer = true;
        transitionSphr.GetComponent<PanoTransition>().upScale = true;
        _theatreStg = true;
    }

}
