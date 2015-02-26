using UnityEngine;
using System.Collections;

public class score : MonoBehaviour
{
    public GameObject flyredcubefly;
    public postac Flyredcubefly;
    public int pkt;
    public int highscore = 0;
    string highScorekey = "HighScore";

    // Use this for initialization
    void Start()
    {
        highscore = PlayerPrefs.GetInt(highScorekey, 0);
    }

    // Update is called once per frame
    void Update()
    {
        guiText.text = "Score" + Flyredcubefly.Pkt.ToString();
        pkt = Flyredcubefly.Pkt;
    }

    void OnDisable()
    {
        System.Collections.Generic.List<int> listawynikow = new System.Collections.Generic.List<int>();

        for (int i = 0; i < 5; i++)
        {
            int score = PlayerPrefs.GetInt(i + "HighScore", 0);
            listawynikow.Add(score);
           // if (score == 0)
             //   PlayerPrefs.SetInt(i + highScoreKey, 0);

        }

        Debug.Log("ondisable");
        Debug.Log(Flyredcubefly.Pkt + " > " + highscore);
         if (Flyredcubefly.Pkt > highscore)
        {
            Debug.Log("saved");
            listawynikow.Add(Flyredcubefly.Pkt);
            //PlayerPrefs.SetInt(highScorekey, Flyredcubefly.Pkt);
            listawynikow.Sort();
            listawynikow.Reverse();

            for (int i = 0; i < 5; i++)
            {
                PlayerPrefs.SetInt(i + "HighScore", listawynikow[i]);
                //listawynikow.Add(score);
                // if (score == 0)
                //   PlayerPrefs.SetInt(i + highScoreKey, 0);

            }


            PlayerPrefs.Save();
        }

    }

}
