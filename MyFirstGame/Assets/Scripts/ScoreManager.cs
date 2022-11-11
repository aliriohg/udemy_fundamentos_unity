using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager Instance
    {
        get; private set;
    }

    [SerializeField] private int points;
    public Text pointText,maxPointText;

    void Start()
    {
        UpdateMaxPoints();
    }
    void Awake()
    {
        Instance = this;
    }

    public void IncrasePoints()
    {
        points++;
        pointText.text = points.ToString();
    }

    public void UpdateMaxPoints()
    {
        int maxPoints = PlayerPrefs.GetInt("Max",0);
        if(points >= maxPoints)
        {
            maxPoints = points;
            PlayerPrefs.SetInt("Max", points);
        }
        maxPointText.text = "BEST: " + maxPoints;
    }
}
