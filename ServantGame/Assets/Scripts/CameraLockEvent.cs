using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLockEvent : MonoBehaviour
{
    public float distance;
    public GameObject buttonPrompt;
    public GameObject textPrompt;
    public Camera playerCam;
    public Transform player;

    MouseLook mouseScript;
    PlayerMovement movementScript;
    AltMouseLook altMouse;

    bool inCheckout = false;
    //public GameObject player;
    //public GameObject baggingCam;

    // Update is called once per frame
    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
        mouseScript = playerCam.GetComponent<MouseLook>();
        movementScript = player.GetComponent<PlayerMovement>();
        altMouse = playerCam.GetComponent<AltMouseLook>();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnGUI()
    {
        if (inCheckout)
        {
            if (Input.GetButtonDown("Exit Action"))
            {
                if (distance <= 3)
                {
                    inCheckout = false;
                    buttonPrompt.SetActive(false);
                    textPrompt.SetActive(false);
                    altMouse.enabled = false;
                    movementScript.enabled = true;
                    mouseScript.enabled = true;
                    Debug.Log("Out of checkout lane");
                    //baggingCam.SetActive(true);
                    //player.SetActive(false);
                }
            }
        }
    }

    private void OnMouseOver()
    {
        if (distance <= 3 && !inCheckout)
        {
            buttonPrompt.SetActive(true);
            textPrompt.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            
            if (distance <= 3)
            {
                inCheckout = true;
                buttonPrompt.SetActive(false);
                textPrompt.SetActive(false);
                movementScript.enabled = false;

                Vector3 pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 1f);
                player.position = pos;
                
                altMouse.enabled = true;
                mouseScript.enabled = false;
                Debug.Log("In checkout lane");
                //baggingCam.SetActive(true);
                //player.SetActive(false);
            }
        }
    }

    private void OnMouseExit()
    {
        buttonPrompt.SetActive(false);
        textPrompt.SetActive(false);
    }
}
