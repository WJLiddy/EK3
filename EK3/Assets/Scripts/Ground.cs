using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{/**
    public void explode(Explosion te)
    {
        launched.SetActive(true);
        GameObject go = launched;
        go.transform.parent = this.transform.parent;
        go.transform.localPosition = this.transform.localPosition;
        Rigidbody2D r = go.GetComponent<Rigidbody2D>();
        float angle = Random.Range(.25f * 3.14f, .75f * 3.14f) - (3.14f / 2f);
        float dist = Vector2.Distance(te.origin, this.transform.localPosition);
        Vector2 dir = new Vector2(te.force * (te.demRadius- dist) * Mathf.Sin(angle), te.force * (te.demRadius - dist) * Mathf.Cos(angle));
        r.velocity = dir;
        r.freezeRotation = true;
        destroyNext = true;
        show(false);
        Invoke("Cleanup", 2);
    }
    */
}