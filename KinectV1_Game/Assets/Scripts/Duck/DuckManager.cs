﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuckManager : MonoBehaviour
{

    // left duck variables
    public GameObject leftDuckPrefab;
    private List<DuckLT> allDucksLT = new List<DuckLT>();
    private Vector2 centerLeft, topLeft = Vector2.zero;


    // right duck variables
    public GameObject rightDuckPrefab;
    private List<DuckRT> allDucksRT = new List<DuckRT>();
    private Vector2 centerRight, topRight = Vector2.zero;

    public Text scoreText;
    public int score;
    public int highScore = 0;

    private void Awake()
    {
        topLeft = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth - 1500, Camera.main.pixelHeight - 200, Camera.main.farClipPlane));
        centerLeft = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth - 1500, Camera.main.pixelHeight - 350, Camera.main.farClipPlane));
        
        topRight = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth - 200, Camera.main.pixelHeight - 200, Camera.main.farClipPlane));
        centerRight = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth - 200, Camera.main.pixelHeight - 350, Camera.main.farClipPlane));
        
    }

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            if (Application.loadedLevel == 0) {
                PlayerPrefs.DeleteKey("Score");
                score = 0;
            }else
            {
                score = PlayerPrefs.GetInt("Score");
            }
        }
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        
        UpdateScore();
        StartCoroutine(CreateDucks());
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth - 1500, Camera.main.pixelHeight - 200, Camera.main.farClipPlane)), 0.5f);
        Gizmos.DrawSphere(Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth - 1500, Camera.main.pixelHeight - 350, Camera.main.farClipPlane)), 0.5f);

        Gizmos.DrawSphere(Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth - 200, Camera.main.pixelHeight - 200, Camera.main.farClipPlane)), 0.5f);
        Gizmos.DrawSphere(Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth - 200, Camera.main.pixelHeight - 350, Camera.main.farClipPlane)), 0.5f);

    }

    public Vector3 GetPlanePositionLeft()
    {

        // Random position
        float targetX = Random.Range(centerLeft.x, topLeft.x);
        float targetY = Random.Range(centerLeft.y, topLeft.y);

        return new Vector3(targetX, targetY, 0);
    }


    public Vector3 GetPlanePositionRight()
    {

        // Random position
        float targetX = Random.Range(centerRight.x, topRight.x);
        float targetY = Random.Range(centerRight.y, topRight.y);

        return new Vector3(targetX, targetY, 0);
    }

    private IEnumerator CreateDucks()
    {
        while (allDucksLT.Count < 2 || allDucksRT.Count < 2)
        {

            // Create and add the ducks
            // Left
            GameObject newDuckObjLeft = Instantiate(leftDuckPrefab, GetPlanePositionLeft(), Quaternion.identity, transform);
            DuckLT newDuckLeft = newDuckObjLeft.GetComponent<DuckLT>();

            // Right
            // Create and add the ducks
            GameObject newDuckObjRight = Instantiate(rightDuckPrefab, GetPlanePositionRight(), Quaternion.identity, transform);
            DuckRT newDuckRight = newDuckObjRight.GetComponent<DuckRT>();

            // Set up Ducks
            // Left
            newDuckLeft.mDuckManager = this;
            allDucksLT.Add(newDuckLeft);

            // Right
            newDuckRight.mDuckManager = this;
            allDucksRT.Add(newDuckRight);

            yield return new WaitForSeconds(5f);
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

}