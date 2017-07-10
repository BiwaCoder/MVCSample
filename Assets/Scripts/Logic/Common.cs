using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//共通で使うシステムを管理するクラス、アプリの起動時最初に生成し消さない想定
public class Common : SingletonMonoBehaviour<Common> {
	//ローディングバ用のマスク、表示の仕組み
	public GameObject LoadingPanel;
	public GameObject LoadingImage;

	void Awake() {
		base.Awake ();
		DontDestroyOnLoad(transform.gameObject);
	}

	public void StartLoading(){
		LoadingPanel.SetActive (true);
		LoadingImage.GetComponent<LodingAnimationLogic> ().StartLoading ();
	}

	public void EndLoading(){
		LoadingPanel.SetActive (false);
		LoadingImage.GetComponent<LodingAnimationLogic> ().EndLoading ();
	}

}
