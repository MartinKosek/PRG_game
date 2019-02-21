using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

    public float moveSpeed;
    
	void Start () {
        moveSpeed = 10f;
	}
	
	void Update () {
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f);
    }
}
