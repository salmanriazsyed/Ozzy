using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doors : MonoBehaviour 
{
	//public GameObject axeDragger;
	//public GameObject crawlingWoman;
	public GameObject typingWoman;
	public GameObject textBox;
	private Text txt;
	
	private void Start()
    {
		txt = textBox.GetComponent<Text>();
		typingWoman.SetActive(false);
		//axeDragger.SetActive(false);
		//crawlingWoman.SetActive(false);
    }

    void OnTriggerEnter(Collider coll)
	{
		if(coll.tag=="Player")
		{
			GetComponent<Animator>().Play("Door_open");
			this.enabled = false;
			txt.text = "Kill your alter ego to break the loop!";
			typingWoman.SetActive(true);
			//axeDragger.SetActive(true);
			//crawlingWoman.SetActive(true);
		}
	}
}
