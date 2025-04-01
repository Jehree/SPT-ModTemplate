﻿using LiteNetLib.Utils;

namespace ModTemplate.FikaModule.Packets;

public struct DoorLockedStatePacket : INetSerializable
{
    public string DoorId;
    public bool IsLocked;

    public void Deserialize(NetDataReader reader)
    {
        DoorId = reader.GetString();
        IsLocked = reader.GetBool();
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(DoorId);
        writer.Put(IsLocked);
    }
}
