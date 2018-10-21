using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{

    public Sprite[] fallAnimStates;
    float explosionMultiplier = 75;

    public void Awake()
    {
        fallAnimStates = Resources.LoadAll<Sprite>("knight/falling/");
    }

    public Transform getCenter()
    {
        return transform.GetChild(1);
    }

    public void explode(Explosion exp)
    {
            Rigidbody2D r = GetComponent<Rigidbody2D>();
            float angle = Mathf.Atan2(getCenter().position.y - exp.origin.y,
                                      getCenter().position.x - exp.origin.x);

            float force = explosionMultiplier * exp.force * (1f-Mathf.Sqrt((Vector2.Distance(this.transform.position, exp.origin)/exp.launchRadius)));
            
            r.AddForce(new Vector2(force * Mathf.Cos(angle),force * Mathf.Sin(angle)), ForceMode2D.Impulse);    
    }

    public void setVelocitySprite()
    {
        var yvel = GetComponent<Rigidbody2D>().velocity.y;
        
        Sprite anim = null;

        var anim_spread_vel = 0.5;

        if (yvel > 0)
        {
            //
            //1, 2, 3, 4

            var frame = (4 - (yvel / anim_spread_vel));
            anim = fallAnimStates[Math.Max((int)frame, 2)];
        }
        else if (yvel == 0)
        {

            anim = fallAnimStates[0];
        }
        if (yvel < 0)
        {
            var frame = 5 + ((-yvel)/anim_spread_vel);
            anim = fallAnimStates[Math.Min((int)frame, 11)];
        }
        GetComponentInChildren<SpriteRenderer>().sprite = anim;
    }
    public void Update()
    {
        setVelocitySprite();
    }

}
