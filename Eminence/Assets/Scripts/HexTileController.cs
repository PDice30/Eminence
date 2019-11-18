using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexTileController : MonoBehaviour
{
    // !!!!!!!!!! Don't Do it like this, Use a raycast to get the tile
    // It can still have coordinates and such, just dont use the logic here
    /////////////////////////////


    
    // Start is called before the first frame update
    private GameObject owner; // Will be a Type of Player
    private Vector3 originPos;
    private Vector3 raisedPos;
    void Start()
    {
        // Test Commit again
        originPos = this.transform.position;
        raisedPos = new Vector3(this.transform.position.x, this.transform.position.y + .5f, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void OnMouseEnter() {
        this.transform.position = raisedPos;
        
    }

    void OnMouseExit() {
       this.transform.position = originPos;
    }
}
