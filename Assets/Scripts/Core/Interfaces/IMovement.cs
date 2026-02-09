using UnityEngine;

namespace Core.Interfaces
{
    public interface IMovement
    {
        WheelJoint2D _wheelJoint2D { get; set; }
        void Move(float direction);
    }
}
