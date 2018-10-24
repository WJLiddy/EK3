using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decal : MonoBehaviour
{
    string type;
    int speed;
    float time = 0;
    Sprite[] anim;

    public void setType(string type, int speed)
    {
        this.type = type;
        this.speed = speed;
        anim = Resources.LoadAll<Sprite>("decal/" + type + "/");
    }

    public void Update()
    {
        time += Time.deltaTime;
        int idx = (int)(time * (float)speed);
        if(idx >= anim.Length)
        {
            Destroy(this.gameObject);
            return;
        }
        GetComponent<SpriteRenderer>().sprite = anim[idx];
    }
}
