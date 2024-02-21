using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class déplacements : MonoBehaviour
{
    [SerializeField]
    private KeyCode leftKey = KeyCode.LeftArrow, rightKey = KeyCode.RightArrow, upkey = KeyCode.UpArrow;

    [SerializeField]
    private Rigidbody2D rgbd;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftKey))
        {
            rgbd.AddForce(Vector2.left);
                if (rgbd.velocity.x < -15f)
                {
                    rgbd.velocity = new Vector2(-15f, rgbd.velocity.y);
                }
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetKey(rightKey))
        {
            rgbd.AddForce(Vector2.right);

                if (rgbd.velocity.x > 15f)
                {
                    rgbd.velocity = new Vector2(15f, rgbd.velocity.y);
                }
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        else
        {
            rgbd.velocity = new Vector2(0f, rgbd.velocity.y);
        }
        if (Input.GetKey(upkey))
        {
            rgbd.AddForce(Vector2.up*2);
        }
    }
}