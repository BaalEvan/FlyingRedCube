using UnityEngine; 
using System.Collections;

public class Score : MonoBehaviour {
	public GameObject balon;
	public GameObject postac;
	public int pkt;
	public int highScore = 0;
	string highScoreKey = "HighScore";
	
	void Start(){
		//Get the highScore from player prefs if it is there, 0 otherwise.
		highScore = PlayerPrefs.GetInt(highScoreKey,0);    
	}
	
	void Update(){
		GetComponent<GUIText>().text = "Score:" + pkt.ToString();
		//pkt = pkt;
	}
	
	void OnDisable(){
		
		//If our scoree is greter than highscore, set new higscore and save.
		if(pkt>highScore){
			PlayerPrefs.SetInt(highScoreKey, pkt);
			PlayerPrefs.Save();
		}
	}
	
}