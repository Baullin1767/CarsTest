using System;
using System.Collections;
using Core.Interfaces;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace View
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private WheelJoint2D wheelJoint2D;
        
        [SerializeField] private float speedChangeTime = 2f;
        
        private float _speedChangeTimer;
        private float _speedMultiplier;
        
        [Inject]
        private IMovement _movement;
        
        private Coroutine _changeSpeedCoroutine;
        
        void Start()
        {
            _movement._wheelJoint2D = wheelJoint2D;
            _speedMultiplier = Random.Range(0.1f, 1f);
            _changeSpeedCoroutine = StartCoroutine(ChangeSpeed());
        }

        private void OnDestroy()
        {
            StopCoroutine(_changeSpeedCoroutine);
            _changeSpeedCoroutine = null;
        }

        void FixedUpdate()
        {
            _movement.Move(_speedMultiplier);
        }

        private IEnumerator ChangeSpeed()
        {
            while (Application.isPlaying)
            {
                yield return new WaitForSeconds(speedChangeTime);
                _speedMultiplier = Random.Range(0.1f, 1f);
            }
        }
    }
}
