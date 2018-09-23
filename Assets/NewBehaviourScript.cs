using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{

	} 
 void OnMouseDown()
	{
		transform.localScale=new Vector2(0.5f,0.5f);
	}	 
void OnMouseDrag()
{
	transform.localScale=new Vector2(0.5f,0.5f);
}
void OnMouseUp()
{
	transform.localScale=new Vector2(1,1);
}
	
}
