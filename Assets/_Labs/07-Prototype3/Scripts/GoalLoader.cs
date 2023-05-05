using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalLoader: MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
		if (other.GetComponent<CharacterController>() != null) {
			SceneManager.LoadScene("MainMenu");
		}
    }

}
