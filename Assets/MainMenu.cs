using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
   public void ExitGame()
    {
        Debug.Log("The Game Closed ");
        Application.Quit();
    }
}