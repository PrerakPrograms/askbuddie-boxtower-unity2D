﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void Play_btn()
    {
        Application.LoadLevel(0);
    }
    public void restart()
    {
        Application.LoadLevel(0);
    }
    public void mainmenu()
    {
        Application.LoadLevel(1);
    }
}
