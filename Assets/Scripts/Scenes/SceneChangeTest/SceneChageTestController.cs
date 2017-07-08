using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChageTestController : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}

	public void OnClickSceneChange(){
		StartCoroutine(LoadScene("MVC"));
	}

	private IEnumerator LoadScene(string sceneName)
	{		
		Common.Instance.LoadingPanel.SetActive (true);
		float start = Time.realtimeSinceStartup;

		AsyncOperation loadReq = SceneManager.LoadSceneAsync (sceneName, LoadSceneMode.Single);
		loadReq.allowSceneActivation = false;
		while (Time.realtimeSinceStartup - start < 1) {
			yield return null;
		}
		loadReq.allowSceneActivation = true;
	

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
