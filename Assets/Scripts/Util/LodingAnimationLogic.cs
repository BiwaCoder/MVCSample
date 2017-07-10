using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LodingAnimationLogic : MonoBehaviour {
	bool isLoadingStart = false;
	public void StartLoading(){
		GetComponent<Image> ().fillAmount = 0.0f;
		isLoadingStart = true;
	}

	void Update(){
		if (isLoadingStart == true) {
			GetComponent<Image> ().fillAmount += 0.001f;
		}
	}

	public void EndLoading(){
		GetComponent<Image> ().fillAmount = 1.0f;
		isLoadingStart = false;
	}


}
