using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {

	public GameObject MousePile;

	public GameObject HamsterMerchant;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.Find ("Food").guiText.text = Status.Food + " Food";
		if (Status.Food >= 10) {
			MousePile.SetActive (true);
		}
		if (Status.ClickerMouseCount >= 15) {
			HamsterMerchant.SetActive(true);
		}

	}
}
