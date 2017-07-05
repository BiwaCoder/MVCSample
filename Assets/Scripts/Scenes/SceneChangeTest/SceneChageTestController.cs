using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChageTestController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void OnClickSceneChange(){
		SceneManager.LoadScene ("MVC", LoadSceneMode.Single);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
