﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common : MonoBehaviour
{
    public static Knight knight;
    public static WorldTiles worldTiles;
    public static GameObject detonationHolder;

    public Knight knight_inst;
    public WorldTiles worldTiles_inst;
    public GameObject detonationHolder_inst;

    public static int TILE_SIZE = 15; 

    public void Awake()
    {
        knight = knight_inst;
        worldTiles = worldTiles_inst;
        detonationHolder = detonationHolder_inst;
    }
}
