using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patern : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rgbd;
    private BoxCollider2D col;

    public bool droite = true;


    // Start is called before the first frame update
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (droite)
        {
            rgbd.velocity = new Vector2(speed, rgbd.velocity.y);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (!droite)
        {
            rgbd.velocity = new Vector2(-speed, rgbd.velocity.y);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Limit_enemis"))
        {
            if (droite)
            {
                droite = false;
            } 
            else if (!droite)
            {
                droite = true;
            }
        }
    }
}

