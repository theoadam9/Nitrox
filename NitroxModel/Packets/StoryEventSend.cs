﻿using System;

namespace NitroxModel.Packets
{
    [Serializable]
    public class StoryEventSend : Packet
    {
        public StoryEventType StoryEventType { get; }
        public string Key { get; }

        public StoryEventSend(StoryEventType storyEventType, string key = "") : base()
        {
            UnityEngine.Debug.Log(key + " " + storyEventType.ToString());
            this.StoryEventType = storyEventType;
            this.Key = key;
        }
    }

    public enum StoryEventType
    {
        PDA,
        Radio,
        Encyclopedia,
        Story,
        Extra
    }
}
