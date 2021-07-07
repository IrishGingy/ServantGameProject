using UnityEngine;

public class AltMouseLook : MonoBehaviour
{
    public float speed = 75f;

    float xRotation = 0f;

    private void Start()
    {
        gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    void FixedUpdate()
    {
        var v3 = new Vector3(Input.GetAxis("Vertical"), 0.0f, 0.0f);

        float xInput = Input.GetAxis("Vertical");

        xRotation -= xInput;
        xRotation = Mathf.Clamp(xRotation, 20f, 65f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}