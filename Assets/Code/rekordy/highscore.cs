using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

public class highscore : MonoBehaviour {

	public int highScore;
	public TextMesh rank1;
	public TextMesh rank2;
	public TextMesh rank3;
	public TextMesh rank4;
	public TextMesh rank5;
	string highScoreKey = "HighScore";
	public int scoreId=0;
	
	void Start(){
	//	for(scoreId=0; scoreId<5;scoreId++)
	//	PlayerPrefs.SetInt (scoreId + highScoreKey, (scoreId * 100) + scoreId);

//		renderer.sortingOrder = 5;
		scoreId = 0;
		//highScore = 
		List<TextMesh> ranks = new List<TextMesh> (){rank1,rank2,rank3,rank4,rank5};
		ranks.OrderBy(a => a.text);//((a,b) => int.Parse(a.text).CompareTo(int.Parse(b.text)));
		ranks.Reverse ();
		foreach (TextMesh r in ranks) {
			r.renderer.sortingOrder = 5;
			r.text = PlayerPrefs.GetInt(scoreId+highScoreKey,0).ToString();
			scoreId++;
		}

	}
	
	// Update is called once per frame
	void Update () {
	}
}