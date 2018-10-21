using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vis_Score : MonoBehaviour {
	public static int score;
	private Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		text.text = score.ToString();
		if (Player_Status.playerhp <= 0 || Base_Status.basehp <= 0)
		{
			ResultScore.resultscore = score;
		}
	}
}
