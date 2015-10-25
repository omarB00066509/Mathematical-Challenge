﻿using UnityEngine;
using UnityEngine.UI;// we need this namespace in order to access UI elements within our script
using UnityEngine.Events;

public class menuScript : MonoBehaviour
{
 
    public Button startGame;
    public Button exitGame;
    public GetInput inputName1;
    public GetInput inputName2;
    public MultiplayerGame mode;
    public GameObject prefarb;
  
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sceneName"></param>
    public void MENU_ACTION_GoToPage(string sceneName)
    {
        if (mode.getGameMode())//if multiplayer is true
        {
            //check if both fields are not empty
            print("Multiplayer mode");
            if (string.IsNullOrEmpty(inputName1.getNickName1()) || string.IsNullOrEmpty(inputName2.getNickName2()))
            {
                print("You haven't type your nicknames 1:" + inputName1.getNickName1()+" 2:"+ inputName2.getNickName2());
            }
            else
            {
                Application.LoadLevel(sceneName);
            }/**/
        }
        else
        {
            print("Single mode");
            if (string.IsNullOrEmpty(inputName1.getNickName1()))
            { 
                print("You haven't type your nickname "+inputName1.getNickName1());
            }
            else
            {
                Application.LoadLevel(sceneName);
                print("NickName: " + inputName1.getNickName1());
            }/**/
        }
        
        
    }

    public void ExitGame()
    {
        Application.Quit();
        print("Game Exit");
    }
    
}