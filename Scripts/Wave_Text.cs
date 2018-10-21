using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wave_Text : MonoBehaviour {
	private Text text;
	public static int curwave;
	//private bool wavecount;
	// Use this for initialization
	void Start () {
		curwave = 1;
		text = GetComponent<Text>();
		//wavecount = false;
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Wave" + curwave.ToString();
        /*
		if (Wave.enecount == 0 && wavecount == false)
		{
			wavecount = true;
			Invoke("count", 0.5f);
		}
		*/
	}

    /*
    void count()
	{
		curwave++;
		wavecount = false;
	}
	*/
}
