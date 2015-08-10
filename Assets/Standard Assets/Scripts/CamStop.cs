using UnityEngine;
using System.Collections;

public class CamStop : MonoBehaviour
{

    private GameObject archvObj;

    public GameObject player;
    public Camera main;
    

    void Start()
    {
        archvObj = GameObject.FindGameObjectWithTag("ArchiveModel");
    }

    void Update()
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
                player.GetComponent<MouseLook>().enabled = true;
                main.GetComponent<MouseLook>().enabled = true;
            }
            
        }
    }
}
