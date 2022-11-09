using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState { 
Ready,Playing
}
public class GameManager : MonoBehaviour
{
    public RawImage backgroud, platform;
    public float parallaxSpeed=0.02f;
    public GameState gameState=GameState.Ready;
    public GameObject uiReady;

    void Start()
    {
        
    }

    void Update()
    {
        bool action = Input.GetKeyDown("space") || Input.GetMouseButtonDown(0);
        HandleJump(action);
        UpdateParallax();
        UpdateGameState(action);
    }
    void HandleJump(bool action)
    {
        if (action&& gameState == GameState.Playing)
        {
          PlayerManager.Instance.SetAnimation("PlayerJump");
        }
    }
    void UpdateGameState(bool action)
    {
        if (action && gameState == GameState.Ready)
        {
            gameState = GameState.Playing;
            uiReady.SetActive(false);

            PlayerManager.Instance.SetAnimation("PlayerRun");
            SpawnManager.Instance.StartSpawn();
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
}
