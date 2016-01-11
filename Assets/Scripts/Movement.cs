using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        // if left click mouse
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            int layerMask = 1 << 8;
            RaycastHit raycastInfo;
            if (Physics.Raycast(ray, out raycastInfo, 200, layerMask))
            {
                //Debug.Log("Hit at (" + raycastInfo.point.x + ", " + raycastInfo.point.y + ", " + raycastInfo.point.z + ")");
                agent.destination = raycastInfo.point;
            }
        }
	}
}
