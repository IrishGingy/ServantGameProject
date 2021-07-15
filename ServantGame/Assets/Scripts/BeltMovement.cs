using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltMovement : MonoBehaviour
{
    public float speed = 3.0f;
    Rigidbody rb;
    public static bool stop;

    // Start is called before the first frame update
    void Start()
    {
        stop = false;
        rb = GetComponent<Rigidbody>();
    }

    public void OnCollisionStay(Collision collision)
    {
        if (stop == false)
        {
            Vector3 pos = rb.position;
            rb.position += Vector3.forward * speed * Time.deltaTime;
            rb.MovePosition(pos);
        }
        
        //float conveyorVelocity = speed * Time.deltaTime;
        //Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        //rb.AddForce(conveyorVelocity * transform.forward, ForceMode.VelocityChange);
    }

    IEnumerator SlowDown()
    {
        yield return new WaitForSeconds(1);
    }

    private void FixedUpdate()
    {
        
    }
}

