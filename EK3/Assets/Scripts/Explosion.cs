using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion
{
    public float demRadius;
    public float launchRadius;
    public float force;
    public Vector2 origin;
    public Explosion(Explosive e)
    {
        demRadius = e.getDemolitionRadius();
        launchRadius = e.getLaunchRadius();
        force = e.getForce();
        origin = e.transform.localPosition;
    }
}

public abstract class Explosive : MonoBehaviour
{
    public abstract float getDemolitionRadius();
    public abstract float getLaunchRadius();
    public abstract float getForce();

    bool explosionColliderTrigger;

    public void Detonate()
    {
        Explosion e = new Explosion(this);
        // in "tile" coords.
        int xmin = (int)((e.origin.x + -e.demRadius) / ((float)Common.TILE_SIZE * 0.01));
        int xmax = 1 + (int)((e.origin.x + e.demRadius) / ((float)Common.TILE_SIZE * 0.01));
        int ymin = (int)((e.origin.y + -e.demRadius) / ((float)Common.TILE_SIZE * 0.01));
        int ymax = 1 + (int)((e.origin.y + e.demRadius) / ((float)Common.TILE_SIZE * 0.01));
        for (int x = xmin; x <= xmax; ++x)
        {
            for (int y = ymin; y <= ymax; ++y)
            {
                var tile_mid = new Vector2(x * ((float)(Common.TILE_SIZE * 0.01)), y * ((float)(Common.TILE_SIZE * 0.01)));
                if (Common.worldTiles.tileExists(x, y) && Vector2.Distance(tile_mid, e.origin) < e.demRadius)
                {
                    Common.worldTiles.destroyTile(x, y);
                }
            }
        }
   

        Knight n = Common.knight.GetComponent<Knight>();
        if(Vector2.Distance(n.transform.localPosition,e.origin) < e.launchRadius)
        {
            n.explode(e);
        }

    }
}