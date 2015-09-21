using System.Collections.Generic;
using UnityEngine;

public class ObjGroupRotation : MonoBehaviour
{

    public List<Vector3> RotationList;
    public float LerpSpeed;


    private bool _nextObj;
    private bool _prevObj;
    public int _listMax;
    private int _curIndex;
    private Vector3 _curRotation;
    private Vector3 _prevRotation;

    void Start()
    {
        _listMax = RotationList.Count;
        _curRotation = RotationList[0];
        _prevRotation = _curRotation;
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



            if (_curIndex <= _listMax)
            {
                if (_curIndex + 1 != _listMax && _curIndex != _listMax)
                {
                    _curIndex = _curIndex + 1;
                    _prevRotation = _curRotation;
                    _curRotation = RotationList[_curIndex];
                }
                else if (_curIndex + 1 >= _listMax - 1)
                {
                    _curIndex = 0;
                }

            }
            //gameObject.GetComponent<Transform>().eulerAngles = RotationList[_curIndex];
            gameObject.GetComponent<Transform>().eulerAngles = Vector3.Lerp(gameObject.GetComponent<Transform>().eulerAngles, RotationList[_curIndex], Time.deltaTime * LerpSpeed);

            print("NEXT - curIndex: " + _curIndex + ", listMax: " + _listMax);
            _nextObj = false;
        }
        float i = Time.deltaTime * LerpSpeed;
        gameObject.GetComponent<Transform>().eulerAngles = Vector3.Lerp(gameObject.GetComponent<Transform>().eulerAngles, RotationList[_curIndex], i);
    }

    public void Back()
    {
        if (_prevObj)
        {



            if (_curIndex <= _listMax)
            {
                if (_curIndex - 1 != -1 && _curIndex != 0)
                {
                    _curIndex = _curIndex - 1;
                    _prevRotation = _curRotation;
                    _curRotation = RotationList[_curIndex];
                }
                else if (_curIndex - 1 <= 0)
                {
                    _curIndex = _listMax - 1;
                }
            }

            //gameObject.GetComponent<Transform>().eulerAngles = RotationList[_curIndex];
            gameObject.GetComponent<Transform>().eulerAngles = Vector3.Lerp(_prevRotation, RotationList[_curIndex], Time.deltaTime * 5);

            print("BACK - curIndex: " + _curIndex + ", listMax: " + _listMax);
            _prevObj = false;
        }
        float i = Time.deltaTime * LerpSpeed;
        gameObject.GetComponent<Transform>().eulerAngles = Vector3.Lerp(gameObject.GetComponent<Transform>().eulerAngles, RotationList[_curIndex], i);

    }

}
