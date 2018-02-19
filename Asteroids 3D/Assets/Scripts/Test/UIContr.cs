using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIContr : MonoBehaviour {

    public Text score;
    public int currentScore;

	// Use this for initialization
	void Start () {

        GameObject Score = GameObject.Find("Score");
        score.text = "Score: " + currentScore.ToString();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        score.text = "Score: " + currentScore.ToString();

        if(currentScore == 80)
        {
            SceneManager.LoadScene("EndMen");
        }
    }
}
