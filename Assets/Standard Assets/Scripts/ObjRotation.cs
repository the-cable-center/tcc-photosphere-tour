using UnityEngine;
using System.Collections;

public class ObjRotation : MonoBehaviour
{

    public float rotationSpeed = 10f;
    public float lerpSpeed = 1f;

    private Vector3 theSpeed;
    private Vector3 avgSpeed;
    public bool isDragging;

    // Use this for initialization
    void Start()
    {

    }

    void OnMouseDown()
    {
        isDragging = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && isDragging)
        {
            theSpeed = new Vector3(-Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0.0F);
            avgSpeed = Vector3.Lerp(avgSpeed, theSpeed, Time.deltaTime * 5);
        }
        else
        {
            if (isDragging)
            {
                theSpeed = avgSpeed;
                isDragging = false;
            }

            float i = Time.deltaTime * lerpSpeed;
            theSpeed = Vector3.Lerp(theSpeed, Vector3.zero, i);
        }
        transform.Rotate(Camera.main.transform.up * theSpeed.x * rotationSpeed, Space.Self);
        transform.Rotate(Camera.main.transform.right * theSpeed.y * rotationSpeed, Space.World);
    }

}



