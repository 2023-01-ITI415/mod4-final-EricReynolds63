using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletrigger : MonoBehaviour
{
	[Header("Inscribed")]
	public int parentPadNum = 0;
	//3 <-> 4
	//1 <-> 2
	public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
		Vector3 TeleSpot = Vector3.one;
		TeleSpot.y = 10;

		if (parentPadNum == 0) {
			
			//Something has gone wrong, there is no teleport 0
			Debug.Log("Flug");

		} else if (parentPadNum == 1) {

			//Teleport to corner near 2 |  X = 140 , Z = -5
			
			TeleSpot.x = (float)147.5;
			TeleSpot.z = (float)2.5;
			player.GetComponent<CharacterController>().enabled = false;
			player.transform.position = TeleSpot;
			player.GetComponent<CharacterController>().enabled = true;

		} else if (parentPadNum == 2) {

			//Teleport to corner near 1 |  X = -5 , Z = 140
			TeleSpot.x = (float)2.5;
			TeleSpot.z = (float)147.5;
			player.GetComponent<CharacterController>().enabled = false;
			player.transform.position = TeleSpot;
			player.GetComponent<CharacterController>().enabled = true;

		} else if (parentPadNum == 3) {

			//Teleport to corner near 4
			TeleSpot.x = (float)2.5;
			TeleSpot.z = (float)2.5;
			player.GetComponent<CharacterController>().enabled = false;
			player.transform.position = TeleSpot;
			player.GetComponent<CharacterController>().enabled = true;

		} else if (parentPadNum == 4) {

			//Teleport to corner near 3
			TeleSpot.x = (float)147.5;
			TeleSpot.z = (float)147.5;
			player.GetComponent<CharacterController>().enabled = false;
			player.transform.position = TeleSpot;
			player.GetComponent<CharacterController>().enabled = true;

		}

	}
}
