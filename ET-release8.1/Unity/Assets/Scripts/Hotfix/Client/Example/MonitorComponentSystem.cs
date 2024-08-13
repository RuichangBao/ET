﻿namespace ET.Client
{
    [EntitySystemOf(typeof(MonitorComponent))]
    [FriendOfAttribute(typeof(ET.Client.MonitorComponent))]
    public static partial class MonitorComponentSystem
    {
        [EntitySystem]
        private static void Awake(this ET.Client.MonitorComponent self, int value)
        {
            Log.Debug("MonitorComponent Awake");
            self.Brightness = value;
        }
        [EntitySystem]
        private static void Destroy(this ET.Client.MonitorComponent self)
        {
            Log.Debug("MonitorComponent Destroy");
        }

        public static void ChangeBrightness(this MonitorComponent self,int value)
        {
            Log.Debug("MonitorComponent ChangeBrightness");
            self.Brightness = value;
        }
    }
}
