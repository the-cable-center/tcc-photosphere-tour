using System.Collections.Generic;
using UnityEngine;

public class ObjGroupRotation : MonoBehaviour
{

    //    private static Quaternion[] rotationVector3s =
    //    {
    //        Quaternion.Euler(0, 0, 0),
    //        Quaternion.Euler(0,45,0),
    //        Quaternion.Euler(0,90,0),
    //        Quaternion.Euler(0,135,0),
    //        Quaternion.Euler(0,180,0),
    //        Quaternion.Euler(0,225,0),
    //        Quaternion.Euler(0,270,0),
    //        Quaternion.Euler(0,315,0)
    //    };

    public List<Vector3> RotationList;

    private bool _nextObj;
    private bool _prevObj;
    private int _listMax;
    private int _curIndex;
    private Vector3 _curRotation;

    void Start()
    {
        _listMax = RotationList.Count;
        _curRotation = RotationList[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.N))
        {
            _nextObj = true;
        }
        else if (Input.GetKeyUp(KeyCode.B))
        {
            _prevObj = true;
        }

        Next();
        Back();
    }

    public void Next()
    {
        if (_nextObj == true)
        {
            gameObject.GetComponent<Transform>().eulerAngles = RotationList[_curIndex];

            if (_curIndex < _listMax)
            {
                _curIndex = _curIndex + 1;
                _curRotation = RotationList[_curIndex];
            }
            else if (_curIndex >= _listMax)
            {
                _curIndex = 0;
            }
            _nextObj = false;
        }
    }

    public void Back()
    {

    }
}
