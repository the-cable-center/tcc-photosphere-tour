using UnityEngine;

public class CamStop : MonoBehaviour
{

    private GameObject archvObj;

    public GameObject player;
    public Camera main;

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
            main.GetComponent<MouseLook>().enabled = false;
        }
        else
        {
            if (archvObj.GetComponent<ObjRotation>().isDragging)
            {
                archvObj.GetComponent<ObjRotation>().isDragging = false;
            }
            player.GetComponent<MouseLook>().enabled = true;
            main.GetComponent<MouseLook>().enabled = true;
        }
    }
}
