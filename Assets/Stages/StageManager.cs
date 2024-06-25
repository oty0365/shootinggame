using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public static int stage;
    public static int kills;
    [SerializeField] private Animator ani;
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private int[] stagekillrequiered;
    // Start is called before the first frame update
    void Start()
    {
        stage = 1;
        StageStart();
    }

    private void Update()
    {
        if (kills == stagekillrequiered[stage - 1])
        {
            Text.text = "스테이지 클리어";
            ani.SetTrigger("NewStage");
            kills = 0;
        }
    }

    // Update is called once per frame

    public void StageStart()
    {
        Text.text = "스테이지 " + stage;
        ani.SetTrigger("NewStage");
    }
}
