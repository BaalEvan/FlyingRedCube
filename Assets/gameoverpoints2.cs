using System;
using UnityEngine;
using System.Collections;

public class gameoverpoints2 : MonoBehaviour
{
	public TextMesh tmpunktacja;
	public postac frcf;
	public int startpoints;
	public int currentpoint=0;
	public int zdobyte;
	public int maxpoint;
	public clicktoshowpoints ctsp;
	
	
	public int mnoznik;
	void Start()
	{
		GetComponent<Renderer>().sortingOrder = 10;
		Debug.Log("wtf");
		startpoints = Convert.ToInt32( PlayerPrefs.GetInt("punktacja").ToString());
		maxpoint = startpoints;
		zdobyte = Convert.ToInt32(frcf.Pkt.ToString());
		startpoints -= zdobyte;
		tmpunktacja.text = zdobyte.ToString();
		mnoznik = maxpoint/100;
		StartCoroutine("zwiekszaniepunktowczas");
		
	}
	
	void Update()
	{

		
	}
	
	IEnumerator odczekanie(float time)
	{
		if (ctsp.presspointbutton == true)
		{
		Debug.Log("waiting");
		yield return new WaitForSeconds(time);
		Debug.Log("wait end");
		if (zdobyte < maxpoint)
		{
			if (zdobyte + mnoznik < maxpoint)
				zdobyte += mnoznik;
			else
				zdobyte++;
			tmpunktacja.text = zdobyte.ToString();
			Debug.Log(time);
			
			StartCoroutine("odczekanie", time/1.1f);
			 }
		}
		
	}
	
	IEnumerator zwiekszaniepunktowczas()
	{
		yield return new WaitForSeconds(2f);
		StartCoroutine("odczekanie", 0.1f);
		
	}

	 


	
}