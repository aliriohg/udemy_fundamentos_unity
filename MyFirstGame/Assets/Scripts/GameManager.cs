using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum GameState { 
Ready,Playing,Ended
}
public class GameManager : MonoBehaviour
{
    public RawImage backgroud, platform;
    public float parallaxSpeed=0.02f;
    public GameState gameState=GameState.Ready;
    public GameObject uiReady,uiScore;
     
    void Start()
    {
        
    }

    void Update()
    {
        bool action = Input.GetKeyDown("space") || Input.GetMouseButtonDown(0);

        HandleJump(action);
        HandleCollisions();
        UpdateParallax();
        UpdateGameState(action);
        HandleExit();
    }
    void HandleJump(bool action)
    {
        if (action&& gameState == GameState.Playing&& PlayerManager.Instance.grounded)
        {
          PlayerManager.Instance.SetAnimation("PlayerJump");
        }
    }

    void HandleCollisions()
    {
        if (gameState == GameState.Playing && PlayerManager.Instance.enemyCollision)
        {
            gameState = GameState.Ended;
            PlayerManager.Instance.SetAnimation("PlayerDie");
            SpawnManager.Instance.StopSpawn();
            SpeedManager.Instance.ResetSpeed();
            ScoreManager.Instance.UpdateMaxPoints();
        }
    }
    void UpdateGameState(bool action)
    {
        if (action && gameState == GameState.Ready)
        {
            gameState = GameState.Playing;
            uiReady.SetActive(false);
            uiScore.SetActive(true);
            PlayerManager.Instance.SetAnimation("PlayerRun");
            SpawnManager.Instance.StartSpawn();
            SpeedManager.Instance.StartSpeedIncrease();

        }else if (action &&  gameState == GameState.Ended)
        {
            HandleRestart();
        }
    }
    void UpdateParallax()
    {
        if (gameState == GameState.Playing)
        {
            float finalSpeed = parallaxSpeed * Time.deltaTime;
            backgroud.uvRect = new Rect(backgroud.uvRect.x + finalSpeed, 0f, 1f, 1f);
            platform.uvRect = new Rect(platform.uvRect.x + finalSpeed * 4, 0f, 1f, 1f);
        }
    }
    void HandleRestart()
    {
        SceneManager.LoadScene("Main");
    }

    void HandleExit()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
}
