using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour 
{
	public GameObject axeDragger;
	public GameObject crawlingWoman;

    private void Start()
    {
		axeDragger.SetActive(false);
		crawlingWoman.SetActive(false);
    }

    void OnTriggerEnter(Collider coll)
	{
		if(coll.tag=="Player")
		{
			GetComponent<Animator>().Play("Door_open");
			this.enabled=false;
			axeDragger.SetActive(true);
			crawlingWoman.SetActive(true);
		}
	}
}
