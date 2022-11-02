using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScoreManager : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private ParticleSystem firework;
    /*private void On(Collision other)
    {
        if (other.gameObject.TryGetComponent(out Paper paper))
        {
            addScore();
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Paper paper))
        {
            addScore();
        }
    }

    public void addScore()
    {
        score++;
        firework.Play();
    }

    public int getScore()
    {
        return score;
    }
}

