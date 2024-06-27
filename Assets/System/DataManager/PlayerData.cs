using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int health;
    // Start is called before the first frame update

    public PlayerData()
    {
        health = PlayerStatus.playerhp;
    }
}
