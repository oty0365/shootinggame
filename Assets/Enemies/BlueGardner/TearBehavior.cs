using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);
        }
        if (collider2D.gameObject.CompareTag("Player"))
        {
            PlayerStatus.playerhp--;
            Destroy(gameObject);
        }
    }
}
