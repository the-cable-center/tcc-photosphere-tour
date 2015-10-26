using UnityEngine;

public class Selector : MonoBehaviour
{
    //attach this to something
    //check distance between pivotpoint and pointchecker
    //create an array and fill it with findgameobjectswithtag
    //which ever object is closest assign tag "selected"


    public GameObject pointChecker;
    private GameObject[] archiveGameObjects;

    private int childCount;


    void Start()
    {
        childCount = transform.childCount;
        archiveGameObjects = new GameObject[childCount];

        for (int i = 0; i < childCount; i++)
        {
            archiveGameObjects[i] = transform.GetChild(i).gameObject;
        }
    }

    void Update()
    {
        for (int i = 0; i < childCount; i++)
        {
            float distance = Vector3.Distance(archiveGameObjects[i].transform.position, pointChecker.transform.position);
            if (distance <= 1)
            {
                archiveGameObjects[i].tag = "Selected";
            }
            else if (distance > 1)
            {
                archiveGameObjects[i].tag = "ArchiveModel";
            }
        }
    }

}
