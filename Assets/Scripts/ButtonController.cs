using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonController : MonoBehaviour {

	public void OnClickQuit ()
	{
		Debug.Log ("CARALHOO");

		#if UNITY_EDITOR
		// set the PlayMode to stop
		#else
		Application.Quit();
		#endif 
	}

	public void OnClickStart()
	{
		SceneManager.LoadScene ("TestScene1");

	}

}
