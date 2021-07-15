using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltStop : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            BeltMovement.stop = true;
        }
            
    }
}
