using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectable : MonoBehaviour

{

    public Image hammer;
    public Sprite with_hammer;
    public Sprite without_hammer;

    [SerializeField]
    private BoxCollider2D bc2d;




    // Start is called before the first frame update
    void Start()
    {
        hammer.sprite = without_hammer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.IsTouchingLayers(3))
        {
            hammer.sprite = with_hammer;
            Destroy(bc2d.gameObject);
        }
    }
}
