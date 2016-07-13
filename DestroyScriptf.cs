using UnityEngine;
using System.Collections;

public class DestroyScriptf : MonoBehaviour {
	void OnEnble(){

		Invoke ("Destroy", 12f);
	}
	void Destroy(){
	
		gameObject.SetActive (false);
	}
	void OnDisable(){
	
		CancelInvoke ("Destroy");
	}
	//xiugaidaima
	//修改操作事例
}
