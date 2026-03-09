using System;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "LevelData", menuName = "Configs/LevelData")]
    public class LevelsData : ScriptableObject
    {
        public Level[] levels;
        [Serializable]
        public struct Level
        {
            public int LevelID;
            public int Reward;
        }
    }
}
