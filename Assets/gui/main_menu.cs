using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_menu : MonoBehaviour {


    public void GoToMainMenu()
    {
        Application.LoadLevel("main_menu");
    }

    public void GoToARCamera()
    {
        Application.LoadLevel("animasi");
    }
    public void GoToMenu()
    {
        Application.LoadLevel("menu");
    }
}
