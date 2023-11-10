using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
   public int currentScore = 0;
   public Text scoreText;

    [ContextMenu("Add Score")]
   public void addScore() {
       currentScore++;
       scoreText.text = currentScore.ToString();
   }
}
