using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
	public Animator anim;
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();

	}
	void Update()
	{
		float move = Input.GetAxis ("Vertical");
		anim.SetFloat ("Speed", move);
		if (Input.GetKey(KeyCode.UpArrow))
		{
			Vector2 position = this.transform.position;
			position.y++;
			this.transform.position = position;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			Vector2 position = this.transform.position;
			position.y--;
			this.transform.position = position;
		}
	}


}