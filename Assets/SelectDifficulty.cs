using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    public TextMeshProUGUI gameMode_Text;


    void ChangeText()
    {
        gameMode_Text.text = "game mode: ";
    }
}
