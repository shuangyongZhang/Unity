using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ObjectPoolerScriptf : MonoBehaviour {

	public static ObjectPoolerScriptf obj;
	public GameObject poolerObject;
	private int pooledAmout = 5;
	public bool willGrow = true;
//	public GameObject parents;
	List<GameObject>pooledObjects;

	void Awake(){
	
		obj = this;
	}
	void Start(){
	
		pooledObjects = new List<GameObject> ();
		for (int i = 0; i < pooledAmout; i++) {
		
			GameObject obj1 = (GameObject)Instantiate (poolerObject);
			obj1.SetActive (false);
			obj1.transform.parent = this.transform;
			obj1.transform.position = this.transform.position;
			pooledObjects.Add (obj1);
		}
	}
	public GameObject GetPooledObject(){
	
		for (int i = 0; i < pooledObjects.Count; ++i) {
		
			if (!pooledObjects[i].activeInHierarchy) {
			
				return pooledObjects[i];
			}
		}
		if (willGrow) {
		
			GameObject obj1 = (GameObject)Instantiate (poolerObject);
			pooledObjects.Add (obj1);
			return obj1;
		}
		return null;
	}
	//A分支，提交到A分支
}
