﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GUI : MonoBehaviour
{
    public Canvas craftUi;
    

    

    private void Update()
    {
        CraftUi();
    }

    public void CraftUi()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            craftUi.enabled = !craftUi.enabled;
        }
    }
    public void ButtonUI()
    {
        craftUi.enabled = !craftUi.enabled;
    }

    
}
