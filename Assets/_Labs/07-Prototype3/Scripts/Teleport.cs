using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	[Header("Inscribed")]
	public int padNum = 0;
	//3 <-> 4
	//1 <-> 2
	public GameObject player;
	public GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {
        GameObject myTrig = Instantiate<GameObject>(trigger);
		Teletrigger trig = myTrig.GetComponent<Teletrigger>();
		trig.parentPadNum = padNum;
		Vector3 TeleSpot = Vector3.one;
		TeleSpot = transform.position;

		//2 & 3 are reversed
		if (padNum == 2 || padNum == 3) {
			TeleSpot.z = TeleSpot.z - (float)2.5;
			TeleSpot.x = TeleSpot.x + (float)2.5;
		} else {
			TeleSpot.z = TeleSpot.z + (float)2.5;
		TeleSpot.x = TeleSpot.x - (float)2.5;
		}

		trig.transform.position = TeleSpot;
		trig.player = player;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
