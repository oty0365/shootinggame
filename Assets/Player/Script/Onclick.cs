using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Onclick : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject bulllet;
    public float fireduration;
    private bool leftactived;
    private bool rightactived;
    private bool isfiring;
    private bool canfire;

    private Rigidbody2D rb;
    //public static bool isinteractingbutton;
    //public int clickcount;
    private EventTrigger _eventTrigger;// Start is called before the first frame update
    void Start()
    {
        canfire = true;
        rb = player.GetComponent<Rigidbody2D>();
        _eventTrigger = gameObject.GetComponent<EventTrigger>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (rightactived)
        {
            rb.position += new Vector2(1.5f*Time.deltaTime, 0);
        }

        if (leftactived)
        {
            rb.position -= new Vector2(1.5f*Time.deltaTime, 0);
        }

        if (isfiring&&canfire)
        {
            StartCoroutine(OnFireFlow());
        }
    }

    public void OnRightClick()
    {
        rightactived = true;
    }

    public void OffRightClick()
    {
        rightactived = false;
    }
    public void OnLeftClick()
    {
        leftactived = true;
    }

    public void OffLeftClick()
    {
        leftactived = false;
    }

    public void OnFire()
    {
        isfiring = true;
    }

    public void OffFire()
    {
        isfiring = false;
    }

    IEnumerator OnFireFlow()
    {
        Instantiate(bulllet, player.transform.position,Quaternion.Euler(0,0,0));
        canfire = false;
        yield return new WaitForSeconds(fireduration);
        canfire = true;
    }
}
