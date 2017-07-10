using UnityEngine;
using System.Collections;

public class MvcController : MonoBehaviour {

	IEnumerator Start () {
		//ローディング中の表示を見せるためにスリープ（テスト用）
		yield return new WaitForSeconds (2);
		//ローディングアニメーションの解除
		Common.Instance.EndLoading();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClicButton(){
		HttpLogicWebRequestLogic.Instance.SetUrl ("http://scooterlabs.com/echo");
		StartCoroutine (HttpLogicWebRequestLogic.Instance.StartDownLoad ());
	}
}
