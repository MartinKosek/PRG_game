using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    private GameObject _enemy;
    private bool _canBeDestroyed = false;
    public AudioSource _audio;
    

    void Start () {
        AudioSource _audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space) && _canBeDestroyed)
        {
            Destroy(_enemy);
            _audio.Play();
            _canBeDestroyed = false;
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("Collision detected.");
            _canBeDestroyed = true;
            _enemy = col.gameObject;
        }
    }

    
}
