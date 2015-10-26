using UnityEngine;

public class ObjRotation : MonoBehaviour
{

    public float RotationSpeed = 10f;
    public float LerpSpeed = 1f;

    private Vector3 _theSpeed;
    private Vector3 _avgSpeed;
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

        //put everything below in its own function
        //check tag of object script is attached too
        //if tag = selected execute function

        if (Input.GetMouseButton(0) && isDragging)
        {
            _theSpeed = new Vector3(-Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0.0F);
            _avgSpeed = Vector3.Lerp(_avgSpeed, _theSpeed, Time.deltaTime * 5);
        }
        else
        {
            if (isDragging)
            {
                _theSpeed = _avgSpeed;
                isDragging = false;
            }

            float i = Time.deltaTime * LerpSpeed;
            _theSpeed = Vector3.Lerp(_theSpeed, Vector3.zero, i);
        }
        transform.Rotate(Camera.main.transform.up * _theSpeed.x * RotationSpeed, Space.Self);
        transform.Rotate(Camera.main.transform.right * _theSpeed.y * RotationSpeed, Space.World);
    }

}



