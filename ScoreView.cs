using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreView : MonoBehaviour {

    public GameObject _scoreView;

    void Update()
    {
        if (PauseMenu._gamePaused == true)
        {
            _scoreView.SetActive(false);
        }
        else
        {
            _scoreView.SetActive(true);
        }
    }
}
