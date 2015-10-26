using UnityEngine;

public class Reset : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            Application.LoadLevel(0);
        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            OVRManager.display.RecenterPose();
        }
    }

}