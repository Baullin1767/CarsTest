using System;
using UnityEngine;

public class TestBehaviourScript : MonoBehaviour
{
    private Enemy _enemy;
    
    private void Start()
    {
        _enemy?.TakeDamage(10);
        
        _enemy = new Enemy(name:"Alister", health: 100);
        
        _enemy.TakeDamage(10);

        var enemyName = _enemy?.Name ?? "Unknown";
        
        Debug.Log($"{enemyName} get damage. Current health {_enemy?.Health}");
    }

    private class Enemy
    {
        public string Name;
        public int Health;

        public Enemy(string name = null, int health = 10)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
        }
    }
}
