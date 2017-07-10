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

	//シーン遷移メソッド
	private IEnumerator LoadScene(string sceneName)
	{		
		//ローディング・マスクの表示
		Common.Instance.StartLoading();
		float start = Time.realtimeSinceStartup;
		AsyncOperation loadReq = SceneManager.LoadSceneAsync (sceneName, LoadSceneMode.Single);

		//TODO 遷移前アニメーション＋ シーンロードの進捗チェック
		loadReq.allowSceneActivation = false;
		while (Time.realtimeSinceStartup - start < 1) {
			yield return null;
		}
		//TODO ロードのアニメーション終わったら遷移
		loadReq.allowSceneActivation = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
