using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour

{

    [SerializeField]
    private BoxCollider2D bc2d;

    [SerializeField]
    private BoxCollider2D bc2d2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.IsTouchingLayers(3))
        {
            Destroy(bc2d.gameObject);
            Destroy(bc2d2.gameObject);
        }
    }
}
