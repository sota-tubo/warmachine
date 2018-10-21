using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vis_AllBulCount : MonoBehaviour {
	private Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Fire.weaponchange == 0)
			text.text = Fire.allbulcount.ToString();
		else if (Fire.weaponchange == 1)
			text.text = Fire.allbulcount2.ToString();
		else if (Fire.weaponchange == 2)
			text.text = Fire.allbulcount3.ToString();
	}
}
