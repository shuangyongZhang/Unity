using UnityEngine;
using System.Collections;

public class FireScriptf : MonoBehaviour {
	public float fireTime =0f;
	Vector3 veor;
	// Use this for initialization
	void Start () {
		veor = new Vector3 (-0.83f, -2.8f, 12f);
	}
	void Fire(){
	
		GameObject obj = ObjectPoolerScriptf.obj.GetPooledObject ();
		if (obj == null) {
		
			return;
		}
		obj.SetActive (true);
		obj.transform.position = this.transform.position + veor;
	}

	void Update(){
		fireTime += Time.deltaTime;
		if (fireTime >= 12) {
		
			Fire ();

			fireTime = 0;
		}
	}
}
