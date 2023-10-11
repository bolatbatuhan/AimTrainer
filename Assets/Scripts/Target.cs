using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    float health = 10.0f;
    private ScoreManager scoreManager;
    
    private void Start() {
        scoreManager = FindObjectOfType<ScoreManager>();
    }
    public void TakeDamage(float amount)
    {
        health -=amount;
        if(health <= 0f)
        {
            Die();

        if(gameObject.CompareTag("Ball"))
        {
            scoreManager.IncreaseScore(10);
        }  
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }

  
}
