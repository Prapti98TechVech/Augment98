//this script is used in the demo.

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

using System;
using System.IO;

public class Capture_Example : MonoBehaviour {

    //the output UI Image
    public Image Output;

    //the output UI Image
    public Image Output2;

    //the location of the green cube to be stored
    private Vector3 CubesPos;

    public void Press()
    {
        //take a screenshot
        Capture.TakeScreenShot();

        //record the location of the cube
        CubesPos = GameObject.Find("Cube (1)").gameObject.transform.position;

        //you need to wait a small amount of time for the screenshot to be saved
        Invoke("Get",0.5f);

    }

    public void Get()
    {
        //get the screenshot as a sprite
        Output.sprite = Capture.GetScreenShot_Sprite();

        //get the corped screenshot as a sprite
        Output2.sprite = Capture.GetScreenShot_Sprite(CubesPos,100);
    }






}
