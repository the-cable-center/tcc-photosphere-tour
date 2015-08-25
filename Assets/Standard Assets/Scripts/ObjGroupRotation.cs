using System.Collections.Generic;
using UnityEngine;

public class ObjGroupRotation : MonoBehaviour
{

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
        if (_nextObj)
        {
            gameObject.GetComponent<Transform>().eulerAngles = RotationList[_curIndex];


            if (_curIndex <= _listMax)
            {
                if (_curIndex + 1 != _listMax && _curIndex != _listMax)
                {
                    _curIndex = _curIndex + 1;
                    _curRotation = RotationList[_curIndex];
                }
                else if (_curIndex >= _listMax - 1)
                {
                    _curIndex = 0 + 1;
                }

            }

            print("NEXT - curIndex: " + _curIndex + ", listMax: " + _listMax);
            _nextObj = false;
        }
    }

    public void Back()
    {
        if (_prevObj)
        {
            gameObject.GetComponent<Transform>().eulerAngles = RotationList[_curIndex];

            if (_curIndex <= _listMax)
            {
                if (_curIndex - 1 != 0 && _curIndex != 0)
                {
                    _curIndex = _curIndex - 1;
                    _curRotation = RotationList[_curIndex];
                }
                else if (_curIndex <= 1)
                {
                    _curIndex = _listMax - 1;
                }
            }
            print("BACK - curIndex: " + _curIndex + ", listMax: " + _listMax);
            _prevObj = false;
        }
    }
}
