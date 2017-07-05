using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class HttpLogicWebRequestLogic : SingletonMonoBehaviour<HttpLogicWebRequestLogic> {
	string url;
	float downLoadProgress;
	bool isDownStart;
	UnityWebRequest www;

	public void SetUrl(string targetUrl){
		isDownStart = false;
		this.url = targetUrl;
	}

	public IEnumerator StartDownLoad(){
		isDownStart = true;
		using (www = UnityWebRequest.Get (this.url)) {
			yield return www.Send ();
			isDownStart = false;
			if(www.isError) {
				Debug.Log(www.error);
			}
			else {
				Debug.Log (www.responseCode.ToString () + ":" + www.downloadHandler.text);
			}
		}
	}

	public float currentProggress(){
		if (www == null) {
			return -1;
		} else {
			return www.downloadProgress;
		}

	}

	public bool isNowDownLoading(){
		return isDownStart;
	}



}
