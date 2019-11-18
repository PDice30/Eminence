using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexTileController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter() {
        
        Component halo = GetComponent("Halo");
        halo.GetType().GetProperty("enabled").SetValue(halo, true, null);
    }

    void OnMouseExit() {
        Component halo = GetComponent("Halo");
        halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
    }
}
