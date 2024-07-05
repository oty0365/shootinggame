using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{

    public static int playerhp;

    [SerializeField] private Sprite[] _sprites;
    // Start is called before the first frame update
    void Start()
    {
        playerhp = 5;
    }
    
    // Update is called once per frame
    void Update()
    {
        switch (playerhp)
        {
            case 4:
                break;
            case 3:
                break;
            case 2:
                break;
            case 1:
                break;
            case 0:
                break;
        }   
    }
    
}
