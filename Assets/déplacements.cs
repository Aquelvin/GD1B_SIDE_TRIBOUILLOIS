using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class déplacements : MonoBehaviour
{
    [SerializeField]
    private KeyCode leftKey = KeyCode.LeftArrow, rightKey = KeyCode.RightArrow, upkey = KeyCode.UpArrow;

    [SerializeField]
    private Rigidbody2D rgbd;

    private SpriteRenderer marche;

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

        }
        if (Input.GetKey(rightKey))
        {
            rgbd.AddForce(Vector2.right);

        }
        if (Input.GetKey(upkey))
        {
            rgbd.AddForce(Vector2.up*2);
        }
    }
}