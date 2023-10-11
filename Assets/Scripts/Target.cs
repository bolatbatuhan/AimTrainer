using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    float health = 10.0f;
    private int score = 0;
    public Text score_Text;
    
    public void TakeDamage(float amount)
    {
        health -=amount;
        if(health <= 0f)
        {
            Die();

        if(gameObject.CompareTag("Ball"))
        {
            IncreaseScore(10);
        }  
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }

    private void IncreaseScore(int amount)
    {
        score += amount;

        score_Text.text = score.ToString();
    }
}
