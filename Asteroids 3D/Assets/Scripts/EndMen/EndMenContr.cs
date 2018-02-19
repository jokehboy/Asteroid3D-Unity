using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndMenContr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator StartDelay()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        SceneManager.LoadScene("Start");
    }

    IEnumerator EndDelay()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        Application.Quit();
    }

    public void OnClickStart()
    {
        StartCoroutine(StartDelay());
    }

    public void OnClickQuit()
    {
        StartCoroutine(EndDelay());
    }
}



