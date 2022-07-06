using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public static class StaticEventHandler
{
    public static event Action<RoomChangeEventArgs> OnRoomChange;

    public static void CallRoomChangeEvent(Room room)
    {
        OnRoomChange?.Invoke(new RoomChangeEventArgs() { room = room });
    }
}

public class RoomChangeEventArgs : EventArgs
{
    public Room room;
}
