using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public GameObject hexTilePrefab;
    public Material hexInvisible; // Convert to Array of Materials
    public Material hexFood;
    public Material hexIndustry;
    public Material hexEconomy;
    public Material hexMilitary;

    public GameObject lakePrefab;
    public GameObject foodTilePrefab;
    public GameObject industryTilePrefab;
    public GameObject militaryTilePrefab;

    public GameObject[,] tileGrid;
    
    private int width = 20;
    private int height = 20;

    private float rowOffset = .9f;
    // Start is called before the first frame update
    void Start()
    {
        tileGrid = new GameObject[width, height];
        GameObject newHexTile;
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {   
                if (y % 2 == 0) {
                    newHexTile = Instantiate(hexTilePrefab, new Vector3(x * 1.775f, 0, y * 1.55f), Quaternion.identity);
                } else {
                    newHexTile = Instantiate(hexTilePrefab, new Vector3((x * 1.775f) + rowOffset, 0, y * 1.55f), Quaternion.identity);
                }
                newHexTile.name = "Hex_" + x + "_" + y;

                // Hex has coordinates in terms of the grid
                newHexTile.GetComponent<HexTile>().x = x;
                newHexTile.GetComponent<HexTile>().y = y;

                // Cleaner hierarchy
                newHexTile.transform.SetParent(this.transform);
                
                tileGrid[x,y] = newHexTile;
                       
            }
        }

        selectStartPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void selectStartPosition() {
        tileGrid[5, 5].GetComponentInChildren<MeshRenderer>().material = hexFood;
        tileGrid[5, 4].GetComponentInChildren<MeshRenderer>().material = hexFood;
        tileGrid[5, 3].GetComponentInChildren<MeshRenderer>().material = hexIndustry;
        tileGrid[4, 5].GetComponentInChildren<MeshRenderer>().material = hexFood;
        tileGrid[6, 5].GetComponentInChildren<MeshRenderer>().material = hexEconomy;
        tileGrid[6, 4].GetComponentInChildren<MeshRenderer>().material = hexFood;
        tileGrid[6, 3].GetComponentInChildren<MeshRenderer>().material = hexFood;
        tileGrid[6, 6].GetComponentInChildren<MeshRenderer>().material = hexMilitary;

        // Transform newTile = tileGrid[6,7].transform;
        // GameObject.Destroy(tileGrid[6,7]);
        // Instantiate(lakePrefab, newTile.position, Quaternion.identity);

        // newTile = tileGrid[6,6].transform;
        // GameObject.Destroy(tileGrid[6,6]);
        // Instantiate(foodTilePrefab, newTile.position, Quaternion.identity);

        // newTile = tileGrid[5,7].transform;
        // GameObject.Destroy(tileGrid[5,7]);
        // Instantiate(militaryTilePrefab, newTile.position, Quaternion.identity);

        // newTile = tileGrid[4,6].transform;
        // GameObject.Destroy(tileGrid[4,6]);
        // Instantiate(industryTilePrefab, newTile.position, Quaternion.identity);

        // newTile = tileGrid[7,7].transform;
        // GameObject.Destroy(tileGrid[7,7]);
        // Instantiate(foodTilePrefab, newTile.position, Quaternion.identity);

        // newTile = tileGrid[5,5].transform;
        // GameObject.Destroy(tileGrid[5,5]);
        // Instantiate(foodTilePrefab, newTile.position, Quaternion.identity);

        // newTile = tileGrid[5,6].transform;
        // GameObject.Destroy(tileGrid[5,6]);
        // Instantiate(industryTilePrefab, newTile.position, Quaternion.identity);

        // newTile = tileGrid[5,4].transform;
        // GameObject.Destroy(tileGrid[5,4]);
        // Instantiate(foodTilePrefab, newTile.position, Quaternion.identity);
        // // tileGrid[6, 7].GetComponentInChildren<GameObject>() = lakePrefab;
    }
}
