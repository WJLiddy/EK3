using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapCollidePopulator : MonoBehaviour
{
    public Tilemap tm;

	// Use this for initialization
	void Start ()
    {
        GameObject go = Resources.Load<GameObject>("ground/GroundCollider");
        tm.ClearAllTiles();
        for (int x = 0; x != tm.size.x; ++x)
        {
            for (int y = 0; y != tm.size.y; ++y)
            {
            }
        } 
	}

    //tilemap.SetTile(new Vector3Int(0,0,0), null); // Remove tile at 0,0,0
	
	// Update is called once per frame
	void Update () {
		
	}
}
