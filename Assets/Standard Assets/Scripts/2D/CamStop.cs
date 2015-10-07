using UnityEngine;

public class CamStop : MonoBehaviour
{

    private GameObject archvObj;

    public GameObject player;
    public GameObject camera;

    void Update()
    {
        archvObj = GameObject.FindGameObjectWithTag("Selected");

        if (archvObj != null)
        {
            Check();
        }
    }

    void Check()
    {
        if (Input.GetMouseButton(0) && archvObj.GetComponent<ObjRotation>().isDragging)
        {
            player.GetComponent<MouseLook>().enabled = false;
            camera.GetComponent<MouseLook>().enabled = false;
        }
        else
        {
            if (archvObj.GetComponent<ObjRotation>().isDragging)
            {
                archvObj.GetComponent<ObjRotation>().isDragging = false;
            }
            player.GetComponent<MouseLook>().enabled = true;
            camera.GetComponent<MouseLook>().enabled = true;
        }
    }
}
