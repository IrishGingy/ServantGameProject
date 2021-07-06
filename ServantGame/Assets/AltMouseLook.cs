using UnityEngine;

public class AltMouseLook : MonoBehaviour
{
    public float speed = 75f;

    private void Start()
    {
        gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    void FixedUpdate()
    {
        var v3 = new Vector3(Input.GetAxis("Vertical"), 0.0f, 0.0f);
        transform.Rotate(v3 * -speed * Time.deltaTime);
    }
    /*
    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

    xRotation -= mouseY;
    xRotation = Mathf.Clamp(xRotation, -90f, 90f);

    transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    playerBody.Rotate(Vector3.up * mouseX);
    */
}