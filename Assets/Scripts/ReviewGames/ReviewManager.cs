﻿using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class ReviewManager : MonoBehaviour {

    public GameObject[] ReviewGamePrefabs; //list of review games
    private static ReviewManager instance;
    public string levelToReview; // bad code smell, open to other options
    public Dictionary <string, string> reviewgamesAndGamesDict;
    int reviewLevelIndex;

    public static ReviewManager GetInstance() {
        return instance;
    }

    private void Awake() { //to establish as dontdestroyonload/singleton
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this);
        reviewgamesAndGamesDict = new Dictionary<string, string>(); // <review prefab name> <level to review name>

        reviewgamesAndGamesDict.Add("BrainbowReviewGame", "Brainbow");
        reviewgamesAndGamesDict.Add("MemoryMatchReviewGame", "MemoryMatch");
        reviewgamesAndGamesDict.Add("SensesReviewGame", "MonsterSenses");
        reviewgamesAndGamesDict.Add("EmotionsReviewGame", "MonsterEmotions");
        reviewgamesAndGamesDict.Add("BrainMazeReviewGame", "BrainMaze");

    }
    void OnEnable() {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnDisable() {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        print("scene loaded");
        for (int i = 0; i < ReviewGamePrefabs.Length; i++) { // traverse array
            if (ReviewGamePrefabs[i].name == levelToReview) { // check for match
                reviewLevelIndex = i; // set review game
            }
        }
            // if scene is game level and need review == true
		if (levelToReview != "") {
			if (GameManager.GetInstance ().GetNumStars (reviewgamesAndGamesDict [levelToReview]) != 2 && SceneManager.GetActiveScene ().buildIndex > 4) { 
				GameObject activeReviewGame = Instantiate (ReviewGamePrefabs [reviewLevelIndex], GameObject.Find ("Review").transform) as GameObject;
			}
        }
    }
}   
