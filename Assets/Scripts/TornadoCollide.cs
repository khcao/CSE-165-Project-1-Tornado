using UnityEngine;
using System.Collections;

public class TornadoCollide : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("BrickTag"))
        {
            Rigidbody collidedRB = collisionInfo.gameObject.GetComponent<Rigidbody>();
            NavMeshAgent thisNMA = this.GetComponent<NavMeshAgent>();
            Debug.Log("Tornado velocity: " + thisNMA.velocity.normalized);
            collidedRB.AddForce(thisNMA.velocity.normalized * speed);
        }
    }

}
