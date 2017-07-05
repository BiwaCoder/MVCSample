using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MvcView : MonoBehaviour {
	public Image LoadingBar;
	public Text  LoadingText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (HttpLogic.Instance.isNowDownLoading ()) {
			//LoadingBar.fillAmount = HttpLogic.Instance.currentProggress ();
			//LoadingText.text = HttpLogic.Instance.currentProggress ().ToString();
		//}
	}
}
