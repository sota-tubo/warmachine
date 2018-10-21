using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour {
	private Text text;
	public static int resultscore;
	// Use this for initialization
	void Start () {
		resultscore = Vis_Score.score;
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score:" + resultscore.ToString();
	}
}
