using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltMovement : MonoBehaviour
{
    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionStay(Collision collision)
    {
        float conveyorVelocity = speed * Time.deltaTime;
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(conveyorVelocity * transform.forward, ForceMode.VelocityChange);
    }
}

