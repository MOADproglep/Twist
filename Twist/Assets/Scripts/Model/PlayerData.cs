using System;

namespace Assets.Scripts.Model
{
    [Serializable]
    public class PlayerData
    {
        public string lastUsedLevel;
        public bool muteMusic;

        public PlayerData(string currentLevel, bool muteMusicRecord)
        {
            lastUsedLevel = currentLevel;
            muteMusic = muteMusicRecord;
        }
    }
}
