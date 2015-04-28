using UnityEngine;
using System.Collections;

public class MousePoint : MonoBehaviour {

	RaycastHit hit;

	private float raycastLength = 500;

	public GameObject Target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//GameObject Target = GameObject.Find ("Target");

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if (Physics.Raycast (ray, out hit, raycastLength)) {
			//Debug.Log (hit.collider.name);
			if(hit.collider.name == "TerrainMain") {
				//Target.transform.position = hit.point;

				// 0 left, 1 right, 2 middle
				if (Input.GetMouseButtonDown(1)) {

					GameObject TargetObj = Instantiate(Target, hit.point, Quaternion.identity) as GameObject;
					TargetObj.name = "Target Instantiated";

				}
			}
		}

			Debug.DrawRay(ray.origin, ray.direction * raycastLength, Color.yellow);
	}
}
