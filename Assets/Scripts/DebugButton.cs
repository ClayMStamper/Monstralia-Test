using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugButton : MonoBehaviour {

	public void AddStars(string gameName) {
        GameManager.GetInstance().LevelUp(gameName);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
