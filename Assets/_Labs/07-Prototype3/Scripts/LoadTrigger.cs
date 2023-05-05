using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
		if (other.GetComponent<CharacterController>() != null) {
			SceneManager.LoadScene("07-Prototype3c");
		}
    }

}
