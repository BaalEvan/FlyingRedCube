using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

public class highscore : MonoBehaviour
{

    public int highScore;
    public TextMesh rank1;
    public TextMesh rank2;
    public TextMesh rank3;
    public TextMesh rank4;
    public TextMesh rank5;
    string highScoreKey = "HighScore";
    public int scoreId = 0;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            int score = PlayerPrefs.GetInt(i + highScoreKey, 0);
            if (score == 0)
                PlayerPrefs.SetInt(i + highScoreKey, 0);

        }
        PlayerPrefs.Save();
        scoreId = 4;
        List<TextMesh> ranks = new List<TextMesh>() { rank1, rank2, rank3, rank4, rank5 };
        ranks.OrderBy(a => a.text);
        ranks.Reverse();
        foreach (TextMesh r in ranks)
        {
            r.GetComponent<Renderer>().sortingOrder = 5;
            r.text =/* (scoreId+1).ToString() +". "+ */PlayerPrefs.GetInt(scoreId + highScoreKey, 0).ToString();
            scoreId--;
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}