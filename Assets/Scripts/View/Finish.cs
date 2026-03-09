using System;
using UnityEngine;
using Zenject;

public class Finish : MonoBehaviour
{
    [Inject] private LevelManager _levelManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _levelManager.OnWin();
            gameObject.SetActive(false);
        }
        else if (other.CompareTag("Enemy"))
        {
            _levelManager.OnLose();
            gameObject.SetActive(false);
        }
    }
}
