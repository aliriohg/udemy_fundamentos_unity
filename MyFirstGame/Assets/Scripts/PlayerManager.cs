using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance
    {
        get;private set;
    }

    private void Awake()
    {
        Instance = this;
    }
    public Animator animator;
    public void SetAnimation(string name)
    {
        animator.Play(name);
    }

}
