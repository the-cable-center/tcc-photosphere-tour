using UnityEngine;

public class UI_MouseHoverAnim : MonoBehaviour
{
    public bool mouseOver;

    private GameObject VRmouse;
    private RaycastHit hovHit;

    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

        VRmouse = GameObject.FindGameObjectWithTag("vrMouse");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey (KeyCode.Keypad1)) {
            anim.SetBool ("mouseOver", true);
        } else {
            anim.SetBool ("mouseOver", false);
        }
        */

        if (VRmouse.GetComponent<VRmouse>().hoverHit.collider != null && VRmouse.GetComponent<VRmouse>().hoverHit.collider.tag == "Selected")
        {
            anim.SetBool("mouseOver", true);
        }
        else
        {
            anim.SetBool("mouseOver", false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (VRmouse.GetComponent<VRmouse>().hoverHit.collider != null && VRmouse.GetComponent<VRmouse>().clickHit.collider.tag == "Selected")
            {
                anim.SetBool("mouseClick", true);
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("mouseClick", false);
        }

    }
}
