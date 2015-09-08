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
        if (_gHall)
        {
            transform.position = gh;
            StartTimer = false;
            _gHall = false;
            panoTimer = 0;
        }

        //go to stairs
        if (_gHallStairs)
        {
            transform.position = ghStairs;
            StartTimer = false;
            _gHallStairs = false;
            panoTimer = 0;
        }

        //go to chof
        if (_chof)
        {
            transform.position = chof;
            StartTimer = false;
            _chof = false;
            panoTimer = 0;
        }

        //go to barco library
        if (_bLib)
        {
            transform.position = barcolib;
            StartTimer = false;
            _bLib = false;
            panoTimer = 0;
        }

        //go to second floor mez
        if (_secFlrMez)
        {
            transform.position = scndflrMez;
            StartTimer = false;
            _secFlrMez = false;
            panoTimer = 0;
        }

        //got to third floor mez
        if (_thrdFlrMez)
        {
            transform.position = thrdflrMez;
            StartTimer = false;
            _thrdFlrMez = false;
            panoTimer = 0;
        }

        //go to archives
        if (_archv)
        {
            transform.position = archives;
            StartTimer = false;
            _archv = false;
            panoTimer = 0;
        }

        //go to hub lounge
        if (_hubLng)
        {
            transform.position = hub;
            StartTimer = false;
            _hubLng = false;
            panoTimer = 0;
        }

        //go to theatre mez
        if (_theatreMez)
        {
            transform.position = thtrMez;
            StartTimer = false;
            _theatreMez = false;
            panoTimer = 0;
        }

        //go to theatre stage
        if (_theatreStg)
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
