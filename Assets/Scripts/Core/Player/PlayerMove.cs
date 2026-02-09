using Core.Interfaces;
using UnityEngine;
using Zenject;

namespace Core.Player
{
    public class PlayerMove : IMovement
    {
        private float _moveSpeed = 1000;
        private JointMotor2D _motor;
        
        private int _currentDirection;
        private bool _isMoving;

        public WheelJoint2D _wheelJoint2D { get; set; }

        [Inject]
        public void Construct(WheelJoint2D wheelJoint2D)
        {
            _wheelJoint2D = wheelJoint2D;
            _motor = new JointMotor2D()
            {
                maxMotorTorque = 10000
            };
        }
        
        public void Move(float direction)
        {
            _motor.motorSpeed = _moveSpeed * direction;
            _wheelJoint2D.motor = _motor;
        }
    }
}
