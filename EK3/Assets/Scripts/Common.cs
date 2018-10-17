using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common : MonoBehaviour
{
    public static Knight knight;

    public Knight knight_inst;
    public static GameObject tileAt(int x, int y)
    {
        return null;
    }

    public void Awake()
    {
        knight = knight_inst;
    }
}
