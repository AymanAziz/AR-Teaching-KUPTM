using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memenu : MonoBehaviour {

    public void GoToMainMenu()
    {
        Application.LoadLevel("main_menu");
    }
    public void GoToHelp()
    {
        Application.LoadLevel("help");
    }
    public void GoToPrivacyPolicy()
    {
        Application.OpenURL("https://www.freeprivacypolicy.com/privacy/view/11b230e5cdb3bc26ff5bcd3170462422");
    }
    public void GoToAppInfo()
    {
        Application.LoadLevel("app_info");
    }

}


