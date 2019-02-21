using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCount : MonoBehaviour {
    private float _timeLeft = 30f;
    Text time;



    // Use this for initialization
    void Start () {
        time = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        _timeLeft -= Time.deltaTime;
        _timeLeft = Mathf.Round(_timeLeft * 100f) / 100f;
        time.text = "Zbývající čas: " + _timeLeft;

        if (_timeLeft <= 0)
        {
            LoadFirstScene();
        }


	}

    public void LoadFirstScene()
    {
        SceneManager.LoadScene("FirstScene");
    }
}
