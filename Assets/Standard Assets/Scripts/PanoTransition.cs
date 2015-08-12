﻿using UnityEngine;
using System.Collections;

public class PanoTransition : MonoBehaviour
{

    public GameObject plyr;

    public float maxScale;
    public float minScale;
    public float scaleSpeed;
    public bool downScale;
    public bool upScale;

    private float targetScale;
    private Vector3 v3Scale;
    private Vector3 v1;
    private Vector3 v2;

    // Use this for initialization
    void Start()
    {
        v1 = gameObject.transform.localScale;
        v2 = v3Scale;

        downScale = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (downScale == true)
        {
            ScaleDown();
        }
        else if (upScale == true)
        {
            ScaleUp();
        }

        v1 = gameObject.transform.localScale;
        v2 = v3Scale;
    }

    void ScaleDown()
    {
        targetScale = minScale;
        v3Scale = new Vector3(targetScale, targetScale, targetScale);

        if (gameObject.transform != null)
        {
            gameObject.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, v3Scale, Time.deltaTime * scaleSpeed);
        }

        float dif = Vector3.SqrMagnitude(v1 - v2);
        print("sqrMagnitude going down: " + dif);
        if (dif <= 0.0001f && plyr.GetComponent<PanoController>().panoTimer == 0f)
        {
            downScale = false;
            dif = 0f;
        }
    }

    void ScaleUp()
    {
        targetScale = maxScale;
        v3Scale = new Vector3(targetScale, targetScale, targetScale);

        if (gameObject.transform != null)
        {
            gameObject.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, v3Scale, Time.deltaTime * scaleSpeed);
        }

        float dif = Vector3.SqrMagnitude(v1 - v2);
        print("sqrMagnitude going up: " + dif);
        if (dif <= 0.0001f && plyr.GetComponent<PanoController>().panoTimer >= 0.5f)
        {
            upScale = false;
            downScale = true;
            dif = 0f;
        }
    }
}
