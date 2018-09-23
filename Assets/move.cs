using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	private double GetAngle (Vector3 a, Vector3 b) {
		if (a.x == b.x && a.y >= b.y) return 0;
		b -= a;
		double angle = Mathf.Acos (-b.y / b.magnitude) * (180 / Mathf.PI);
		return (b.x < 0 ? -angle : angle);
	}
	public Transform model;
	private bool movestate = false;
	public float speed = 1;

	public Vector3 target = Camera.main.ScreenToWorldPoint (Input.mousePosition);
	// Use this for initialization
	void Start () {
		model = gameObject.GetComponent<Transform> ();

	}

	// Update is called once per frame
	void Update () {

		Vector3 obposition = transform.position;
		float z = (float) GetAngle (model.position, target);
		if (Input.GetMouseButtonDown (0)) {
			movestate = true;
			target = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			//transform.Rotate (new Vector3 (0, 0, z));
			Vector3 targetDir = target - model.position;
			float deltaZ = Vector3.Angle(targetDir, model.right);
			if(Vector3.Cross(targetDir, model.right).y < 0) deltaZ = -deltaZ;
			Debug.Log(model.right);
			Debug.Log(deltaZ);
			model.Rotate(new Vector3(0, 0, deltaZ));
		}
		float step = 2 * speed * Time.deltaTime;
		if (movestate) {
			if (Vector3.Distance (model.position, target) < 0.1f) {
				movestate = false;
			}
			model.position = Vector2.MoveTowards (model.position, target, step);
		}
	}
}