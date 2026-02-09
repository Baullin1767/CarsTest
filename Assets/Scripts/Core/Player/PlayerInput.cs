using Core.Player.Interfaces;
using UnityEngine;

namespace Core.Player
{
    public class PlayerInput : IPlayerInput
    {
        public float GetInput()
        { 
            return Input.GetAxis("Horizontal");
        }
    }
}
