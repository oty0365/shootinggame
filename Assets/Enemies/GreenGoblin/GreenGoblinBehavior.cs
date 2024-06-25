using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGoblinBehavior : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 startpos;
    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        startpos.y = 14;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.down * movespeed;
        if (gameObject.transform.position.y <= -5)
        {
            rb.position = new Vector3(gameObject.transform.position.x,7,0);
        }
    }
}
