using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public bool isInteracting;
    public Camera fpsCam;
    public LayerMask puzzlerLayer;
    public PlayerMove playerMove;
    public PlayerLook playerLook;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isInteracting)
        {
            isInteracting = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (isInteracting)
        {
            playerMove.enabled = false;
            playerLook.enabled = false;
        }

        else
        {
            playerMove.enabled = true;
            playerLook.enabled = true;
        }

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, 50, puzzlerLayer))
            {
                InteractWithPuzzle1();
                Cursor.lockState = CursorLockMode.None;
            }
        }

    
        
        




    }

    void InteractWithPuzzle1()
    {
        isInteracting = true;
        Debug.Log("Interact");

    }
}
