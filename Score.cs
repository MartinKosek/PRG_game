using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public static int _numberOfEnemies;
    Text score;

    // Use this for initialization
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        _numberOfEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        score.text = "Počet nepřátel: " + _numberOfEnemies;

        if (_numberOfEnemies == 0)
        {
            LoadFirstScene();
        }


    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene("FirstScene");
    }
}
