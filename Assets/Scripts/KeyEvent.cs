using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyEvent : MonoBehaviour {

    public Animator Notification;

	// Use this for initialization
	void Start () {
        Notification = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Notification.Play("Information");
            Debug.Log("Information");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Notification.Play("Warning");
            Debug.Log("Warning");
        }
    }
}
