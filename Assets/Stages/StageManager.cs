using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    [SerializeField] private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        StageStart();
    }

    // Update is called once per frame

    public void StageStart()
    {
        ani.SetTrigger("NewStage");
    }
}
