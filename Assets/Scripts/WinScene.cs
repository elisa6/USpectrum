using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		Invoke("LoadMainMenu",10);
	}

	public void LoadMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
