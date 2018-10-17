using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{

    float explosionMultiplier = 75;

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

}
