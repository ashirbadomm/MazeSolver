using UnityEngine;
using System.Collections;

public class Autowalk : MonoBehaviour {
	public float speed = 2.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
	}


}
