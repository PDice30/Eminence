using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 currentMousePos;
    Vector3 previousMousePos;

    bool isMenuItemSelected;

    public float dragSpeed = .5F;
    private Vector3 dragOrigin;
    void Start()
    {
        isMenuItemSelected = false;
        currentMousePos = Input.mousePosition;
        previousMousePos = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMenuItemSelected) {
            if (Input.GetMouseButtonDown(0))
                {
                    dragOrigin = Input.mousePosition;
                    return;
                }
    
            if (!Input.GetMouseButton(0)) return;

            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
            Vector3 move = new Vector3(-pos.x * dragSpeed, 0, -pos.y * dragSpeed);
    
            Debug.Log(Input.mousePosition.y);
            //transform.position = Vector3.Lerp(pos, move, )
            transform.Translate(move, Space.World);  
        }
        
    }

    void OnMouseDrag() {
        // previousMousePos = currentMousePos;
        // currentMousePos = Input.mousePosition;

        // Vector3 movementVector = currentMousePos - previousMousePos;
        // Vector3 newCameraPos = transform.position - movementVector;
        
        // transform.Translate(newCameraPos, Space.World);
        // Debug.Log(newCameraPos);
    }
}
