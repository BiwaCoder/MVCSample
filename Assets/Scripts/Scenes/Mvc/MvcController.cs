using UnityEngine;
using System.Collections;

public class MvcController : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (2);
		Common.Instance.LoadingPanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClicButton(){
		HttpLogicWebRequestLogic.Instance.SetUrl ("http://scooterlabs.com/echo");
		StartCoroutine (HttpLogicWebRequestLogic.Instance.StartDownLoad ());
	}
}
