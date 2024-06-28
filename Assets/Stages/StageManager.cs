using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    //public static int stage=1;
    public int currentstage=1;
    public static int stage;
    public static int kills;
    public static int EnterType;
    [SerializeField] private Animator ani;
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private int[] stagekillrequiered;
    // Start is called before the first frame update
    void Start()
    {
        if (EnterType == 1)
        {
            RestartStage();
            EnterType = 3;
        }
        else if (EnterType == 2)
        {
            LoadStage();
            EnterType = 3;
        }
        StageStart();
    }

    private void Update()
    {
        if (kills == stagekillrequiered[currentstage - 1])
        {
            StageClear();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadStage();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(currentstage);
        }

    }

    // Update is called once per frame

    public void StageStart()
    {
        Debug.Log("Stage Start");
        Text.text = "스테이지 " + currentstage;
        ani.SetTrigger("NewStage");
        SaveStage();
    }

    public void StageClear()
    {
        Text.text = "스테이지 클리어";
        ani.SetTrigger("NewStage");
        kills = 0;
        Invoke("WaitForNext",5f);

    }

    public void SaveStage()
    {
        SaveSystem.SaveStage(this);
    }

    public void LoadStage()
    {
        StageData data = SaveSystem.LoadStage();
        Debug.Log(data.stage);
        currentstage = data.stage;
    }

    public void RestartStage()
    {
        SaveSystem.DeleteStage();
        StageData data = SaveSystem.LoadStage();
        Debug.Log(data.stage);
        currentstage = data.stage;
    }

    void WaitForNext()
    {
        currentstage++;
        StageStart();
    }
}
