using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Project : MonoBehaviour {

    [SerializeField] Transform Projet;
    [SerializeField] GameObject NewProject;

    public Vector3 location;

    void Start () {

	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject project = Instantiate(NewProject, location, Quaternion.identity) as GameObject;
            project.transform.parent = Projet;
            project.transform.localScale = new Vector3(1, 1, 1);
 
            Debug.Log("NewProject");
        }
    }
}
