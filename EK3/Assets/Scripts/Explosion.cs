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
        /**
        for (int x = (int)this.transform.localPosition.x + -getDemolitionRadius(); x != (int)this.transform.localPosition.x + getDemolitionRadius(); ++x)
        {
            for (int y = (int)this.transform.localPosition.y +-getDemolitionRadius(); y != (int)this.transform.localPosition.y + getDemolitionRadius(); ++y)
            {
                if (Common.tileAt(x, y) != null && Vector2.Distance(Common.tileAt(x,y).transform.localPosition, e.origin) < e.demRadius)
                {
                    //Common.tileAt(x, y).GetComponent<Ground>().explode(e);
                }
            }
        }
    */

        Knight n = Common.knight.GetComponent<Knight>();
        if(Vector2.Distance(n.transform.localPosition,e.origin) < e.launchRadius)
        {
            n.explode(e);
        }

    }
}