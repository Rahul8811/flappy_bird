using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    private int score; //variable to store the score

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0; //initialize the score to 0
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreUp()  //public because it will be called from another  bird script 
    {
        score++; //increment the score by 1
        //You are using TextMeshPro, so GetComponent<Text>() will not work
        //You need to be using GetComponent<TextMeshPro.Text>()
        //One minute
        GetComponent<TMP_Text>().text = score.ToString(); //display the score on the screen //convert the score to string 
    }
}
