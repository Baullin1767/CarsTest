using System;

namespace Data.Events
{
    public class LevelEvents
    {
        public Action<int> OnPlayerWin;
        public Action OnPlayerLose;
    }
}
