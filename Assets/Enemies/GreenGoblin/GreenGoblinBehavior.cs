using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GreenGoblinBehavior : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 startpos;
    public float movespeed;
    private SpriteRenderer sr;
    [SerializeField] private Sprite[] sprites;  
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        startpos.y = 14;
        startpos.x = gameObject.transform.position.x;
        rb.position = startpos;
        sr.sprite = sprites[0];
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

    void OnTriggerEnter2D(Collider2D _collider2D)
    {
        if (_collider2D.gameObject.CompareTag("bullet"))
        {
            Debug.Log("!");
        }
    }
}
