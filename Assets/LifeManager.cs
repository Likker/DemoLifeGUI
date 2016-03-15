using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {

	private Slider lifeSlider;

	// Use this for initialization
	void Start () {
		lifeSlider = this.transform.GetChild (0).GetComponentInChildren<Slider> ();
		Debug.Log (lifeSlider.value);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addLife()
	{
		lifeSlider.value += 0.2f;
	}

	public void removeLife()
	{
		lifeSlider.value -= 0.2f;
	}
}
