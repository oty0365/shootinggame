using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlueGardenerBehavior : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 startpos;
    private SpriteRenderer sr;
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private GameObject gardianstear;
    public int hp;
    private bool isdistroid;
    private float fireduration;
    private bool canshoot;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = sprites[0];
        rb.gravityScale = 0;
        isdistroid = false;
        canshoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canshoot)
        {
            StartCoroutine(Fire());
        }
 
    }

    void OnTriggerEnter2D(Collider2D _collider2D)
    {
        if (_collider2D.gameObject.CompareTag("bullet"))
        {
            hp--;
        }

        if (_collider2D.gameObject.CompareTag("end"))
        {
            StageManager.kills++;
            Destroy(gameObject);
        }

        switch (hp)
        {
            case 3:
                sr.sprite = sprites[1];
                break;
            case 2:
                sr.sprite = sprites[2];
                break;
            case 1:
                sr.sprite = sprites[3];
                break;
            case 0:
                isdistroid = true;
                sr.sprite = sprites[4];
                rb.gravityScale = 14f;
                break;
        }
    }

    IEnumerator Fire()
    {
        canshoot = false;
        fireduration=Random.Range(1f, 6f);
        yield return new WaitForSeconds(fireduration);
        Instantiate(gardianstear,gameObject.transform.position,Quaternion.Euler(0,0,0));
        canshoot = true;
    }


}
