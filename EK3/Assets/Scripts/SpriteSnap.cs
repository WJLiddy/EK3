﻿using UnityEngine;


public class SpriteSnap : MonoBehaviour
{
    private static float PPU = 1; // pixels per unit (your tile size)

    private void LateUpdate()
    {
        Vector3 position = transform.localPosition;
        position.x = (Mathf.Round(transform.parent.position.x * PPU) / PPU) - transform.parent.position.x;
        position.y = (Mathf.Round(transform.parent.position.y * PPU) / PPU) - transform.parent.position.y;
        transform.localPosition = position;
    }
}