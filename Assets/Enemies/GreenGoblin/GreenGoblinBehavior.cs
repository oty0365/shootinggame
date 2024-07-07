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
    public int hp;
    private bool isdistroid;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        startpos.y = 14;
        startpos.x = gameObject.transform.position.x;
        rb.position = startpos;
        sr.sprite = sprites[0];
        rb.gravityScale = 0;
        isdistroid = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.down * movespeed;
        if (gameObject.transform.position.y <= -5)
        {
            if (hp <= 0)
            {
                StageManager.kills++;
                Destroy(gameObject);
            }
            rb.position = new Vector3(gameObject.transform.position.x,7,0);
        }
        
    }

    void OnTriggerEnter2D(Collider2D _collider2D)
    {
        if (_collider2D.gameObject.CompareTag("bullet"))
        {
            hp--;
        }

        switch (hp)
        {
            case 2:
                sr.sprite = sprites[1];
                break;
            case 1:
                sr.sprite = sprites[2];
                break;
            case 0:
                isdistroid = true;
                sr.sprite = sprites[3];
                rb.gravityScale = 14f;
                break;
        }
    }
}
