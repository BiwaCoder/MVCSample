using UnityEngine;
using System.Collections;

public class HttpLogic : SingletonMonoBehaviour<HttpLogic> {
	string url;
	float downLoadProgress;
	bool isDownStart;

	public void SetUrl(string targetUrl){
		isDownStart = false;
		this.url = targetUrl;
	}

	public IEnumerator StartDownLoad(){
		isDownStart = true;
		using(WWW www = new WWW(url)){

			while (!www.isDone) {
				downLoadProgress = www.progress;
				yield return www;
			}
		
			if (!string.IsNullOrEmpty (www.error)) {
				downLoadProgress = -1;
				Debug.Log (www.error);
			} 
			else {
				downLoadProgress = 1;
				Debug.Log (www.text);
			}

		}
	}

	public float currentProggress(){
		return downLoadProgress;
	}

	public bool isNowDownLoading(){
		return isDownStart;
	}



}
