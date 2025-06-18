using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;


    float XRotation;
    float YRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        XRotation -= mouseY;
        YRotation += mouseX;

        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        Debug.Log("X Rotation: " + XRotation);
        Debug.Log("Y Rotation: " + YRotation);

        transform.rotation = Quaternion.Euler(XRotation, YRotation, 0);

        // player orientation; prob won't be used
        //orientation.rotation = Quaternion.Euler(0, YRotation, 0);
    }
}