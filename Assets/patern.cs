using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patern : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rgbd;

    public BoxCollider2D pointA, pointB;

    public bool vaversladroite = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<BoxCollider2D>().IsTouching(pointB))
            vaversladroite = false;
        if (gameObject.GetComponent<BoxCollider2D>().IsTouching(pointA))
            vaversladroite = true;

        if (vaversladroite)
            rgbd.AddForce(Vector2.right * 2);
        else
            rgbd.AddForce(Vector2.left * 2);
    }
}
