using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StageData
{
    public int stage;
    // Start is called before the first frame update

    public StageData(StageManager stageManager)
    {
        stage = stageManager.currentstage;
    }
}
