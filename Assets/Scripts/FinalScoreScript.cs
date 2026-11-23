using UnityEngine;
using TMPro;

public class FinalScoreScript : MonoBehaviour
{
    //creates TMP variable that can be set in Unity
    public TMP_Text endScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //sets the text for endScore
        endScore.text = "You scored " + GlobalVariables.finalScore + " points!";
    }
}
