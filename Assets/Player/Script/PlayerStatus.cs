using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{

    public static int playerhp;
    private SpriteRenderer sr;
    [SerializeField] private Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        playerhp = 5;
        sr.sprite = sprites[0];
    }
    
    // Update is called once per frame
    void Update()
    {
        switch (playerhp)
        {
            case 4:
                sr.sprite = sprites[1];
                break;
            case 3:
                sr.sprite = sprites[2];
                break;
            case 2:
                sr.sprite = sprites[3];
                break;
            case 1:
                sr.sprite = sprites[4];
                break;
            case 0:
                sr.sprite = sprites[5];
                break;
        }   
    }
    
    
}
