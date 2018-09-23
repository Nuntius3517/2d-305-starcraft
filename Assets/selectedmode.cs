using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
	public GameObject myself;
	public Sprite greencircle;
	public bool selected = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (selected == true) {
			greencircle = Resources.Load<Sprite>("tank1 選取");
			gameObject.GetComponent<SpriteRenderer> ();
		}

	}
	void OnMouseDown () {
		selected = true;

	}
}