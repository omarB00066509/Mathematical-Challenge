﻿using UnityEngine;
using System.Collections;

public class PlayerGui : MonoBehaviour {

    //Horizontal position of the needed number on the screen
    private int NeedLabelY = Screen.width / 2;

    //Horizontal position of the wanted number on the screen
    private int HaveLabelY = (Screen.width * 10) / 100;

    //Vertical position of both labels
    private int LabelX = ((Screen.height * 5) / 100) + 50;

    //Size of both labels
    private int LabelWidth = 200;
    private int LabelHeight = 100;

    //Various Variables
    //These used to edit on-screen label
    int numberNeeded;
    string numbersCollected;

    //These used to determine what was collected 
    //and add to "numbersCollected" String
    int numberColl;
    string opColl;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update () {
        
        GUI.Label(new Rect(NeedLabelY, LabelX, LabelWidth, LabelHeight), numberNeeded.ToString());
        GUI.Label(new Rect(HaveLabelY, LabelX, LabelWidth, LabelHeight), numbersCollected);

    }
}
