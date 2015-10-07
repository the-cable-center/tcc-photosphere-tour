using UnityEngine;

public class PanoTransitionVR : MonoBehaviour
{

    public GameObject plyr;
    public GameObject cam;
    public Animator hud;

    public float maxScale;
    public float minScale;
    public float scaleSpeed;
    public float waitTime;
    public bool downScale;
    public bool upScale;

    private float timer;
    private float targetScale;
    private Vector3 v3Scale;
    private Vector3 v1;
    private Vector3 v2;

    void Start()
    {
        v1 = gameObject.transform.localScale;
        v2 = v3Scale;
    }

    void Update()
    {
        if (downScale == true)
        {
            ScaleDown();
        }
        else if (upScale == true)
        {
            timer += Time.deltaTime;
        }

        if (timer >= waitTime)
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
        if (dif <= 0.0001f && plyr.GetComponent<PanoControllerVR>().panoTimer == 0f)
        {
            hud.SetBool("HUDswitch", true);
            downScale = false;
            dif = 0f;
            GetComponent<MeshRenderer>().enabled = false;
        }
    }



    void ScaleUp()
    {
        targetScale = maxScale;
        v3Scale = new Vector3(targetScale, targetScale, targetScale);

        GetComponent<MeshRenderer>().enabled = true;

        if (gameObject.transform != null)
        {
            gameObject.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, v3Scale, Time.deltaTime * scaleSpeed);
        }

        float UPdif = Vector3.SqrMagnitude(v1 - v2);
        if (UPdif <= 0.001f && plyr.GetComponent<PanoControllerVR>().panoTimer >= 1f)
        {
            upScale = false;
            timer = 0;
            UPdif = 0f;
            downScale = true;
        }
    }
}


