using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldTiles : MonoBehaviour
{
    public Tilemap tm;

    public void Awake()
    {
        tm = GetComponent<Tilemap>();
    }
    public void destroyTile(int x, int y)
    {

        if (x > tm.cellBounds.xMin && x < tm.cellBounds.xMax && y > tm.cellBounds.yMin && y < tm.cellBounds.yMax)
        {
            
            tm.SetTile(new Vector3Int(x, y, 0), null);
        }
    }

    public bool tileExists(int x, int y)
    {
        return tm.GetTile(new Vector3Int(x, y, 0)) != null;
    }
}
