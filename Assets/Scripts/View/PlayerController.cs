using Core.Interfaces;
using Core.Player.Interfaces;
using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private WheelJoint2D wheelJoint2D;
    
    [Inject]
    private IPlayerInput _playerInput;
    [Inject]
    private IMovement _movement;

    private void Start()
    {
        _movement._wheelJoint2D = wheelJoint2D;
    }

    private void FixedUpdate()
    {
        _movement.Move(_playerInput.GetInput());
    }
}
