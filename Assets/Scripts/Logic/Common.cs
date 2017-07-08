using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common : SingletonMonoBehaviour<Common> {
	public GameObject LoadingPanel;
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
}
