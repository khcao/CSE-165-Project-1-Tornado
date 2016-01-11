using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public GameObject tornado;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - tornado.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = tornado.transform.position + offset;
	}
}
