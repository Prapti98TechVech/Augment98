using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public GameObject FbButton;
    public GameObject LinkButton;
    



    public void UrlForFacebook()
    {
        Application.OpenURL("https://www.facebook.com/prapti.kundu.5");
    }

    public void UrlForLink()
    {
        Application.OpenURL("https://www.linkedin.com/in/prapti-kundu-1b700612b/");
    }

}
