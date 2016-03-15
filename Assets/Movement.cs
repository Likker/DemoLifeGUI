using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {


	public float velocity = 1;
	private float tempTime;

	// Use this.gameObject for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow))
		{
				this.gameObject.gameObject.transform.localPosition = new Vector3 (this.gameObject.transform.localPosition.x - Time.deltaTime * velocity,
				this.gameObject.transform.localPosition.y,
				this.gameObject.transform.localPosition.z);	}

		if (Input.GetKey (KeyCode.RightArrow))
		{
			this.gameObject.transform.localPosition = new Vector3 (this.gameObject.transform.localPosition.x + Time.deltaTime * velocity,
				this.gameObject.transform.localPosition.y,
				this.gameObject.transform.localPosition.z);
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			processJump ();
		}

	}

	void processJump()
	{
		//GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
	}


}
