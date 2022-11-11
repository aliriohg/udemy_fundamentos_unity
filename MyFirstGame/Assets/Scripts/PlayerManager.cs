using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance
    {
        get;private set;
    }

    public Animator animator;
    public bool enemyCollision=false,grounded;
    private float startY;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        startY = transform.position.y;
    }

    private void Update()
    {
        grounded = transform.position.y == startY;
    }
    public void SetAnimation(string name)
    {
        animator.Play(name);
        if (name == "PlayerJump")
        {
            AudioManager.Instance.PlaySound("Jump");
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Enemy")
        {
            enemyCollision = true;
            GetComponent<BoxCollider2D>().enabled = false;
            AudioManager.Instance.PlaySound("Die");
            AudioManager.Instance.StopMusic();
        }else if (collider.tag == "Points")
        {
            ScoreManager.Instance.IncrasePoints();
            AudioManager.Instance.PlaySound("Point");
        }
    }

}
