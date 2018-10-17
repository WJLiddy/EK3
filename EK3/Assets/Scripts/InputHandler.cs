
using UnityEngine;

public class InputHandler: MonoBehaviour
{

    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var mouseEnd = Input.mousePosition;
            float angle = -Mathf.Atan2((Screen.height / 2) - mouseEnd.y, mouseEnd.x - (Screen.width / 2));
            GameObject grenade = Instantiate(Resources.Load<GameObject>("explosives/grenade"));
            grenade.transform.parent = Common.knight.transform.parent;
            grenade.transform.position = Common.knight.transform.GetChild(1).position;
            float force = 1;
            grenade.GetComponent<Rigidbody2D>().velocity = Common.knight.GetComponent<Rigidbody2D>().velocity;
            grenade.GetComponent<Rigidbody2D>().AddForce(new Vector2(force * Mathf.Cos(angle), force * Mathf.Sin(angle)), ForceMode2D.Impulse);

        }
    }
}