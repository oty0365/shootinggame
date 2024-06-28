using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonOnhover : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] tmpro;

    public bool[] onhover;
    // Start is called before the first frame update

    public void OnHover0()
    {
        onhover[0] = true;
        tmpro[0].color = Color.blue;
    }

    public void ExitHover0()
    {
        onhover[0] = false;
        tmpro[0].color = Color.white;
    }
    public void OnHover1()
    {
        onhover[1] = true;
        tmpro[1].color = Color.green;
    }

    public void ExitHover1()
    {
        onhover[1] = false;
        tmpro[1].color = Color.white;
    }
    public void OnHover2()
    {
        onhover[2] = true;
        tmpro[2].color = Color.red;
    }

    public void ExitHover2()
    {
        onhover[2] = false;
        tmpro[2].color = Color.white;
    }
    public void OnHover3()
    {
        onhover[3] = true;
        tmpro[3].color = Color.red;
    }

    public void ExitHover3()
    {
        onhover[3] = false;
        tmpro[3].color = Color.white;
    }
    
}
