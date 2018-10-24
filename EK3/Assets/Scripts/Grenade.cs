using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : Explosive
{
    public float explosionTime = 1f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddTorque(UnityEngine.Random.Range(-1f, 1f));
    }
    // Update is called once per frame
    void Update ()
    {
        explosionTime -= Time.deltaTime;
        if (explosionTime <= 0f)
        {
            Detonate();
            Destroy(this.gameObject);
            return;
        }
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Detonate();
        Destroy(this.gameObject);
        return;
    }

    public override float getDemolitionRadius()
    {
        return .25f;
    }

    // MUST be greater than demolition radius.
    public override float getLaunchRadius()
    {
        return 1.5f;
    }

    public override float getForce()
    {
        return 15f;
    }
}
