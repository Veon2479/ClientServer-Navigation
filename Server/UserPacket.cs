﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public struct UserPacket
    {
        public int userID;
        public double x;
        public double y;
        public long time;

        public UserPacket(int uID, double uX, double uY, long uTime)
        {
            userID = uID;
            x = uX;
            y = uY;
            time = uTime;
        }

        public static UserPacket getStruct(byte[] data)
        {
            UserPacket packet = new UserPacket();
            try
            {
                packet.userID = BitConverter.ToInt32(data, 0);
                packet.x = BitConverter.ToDouble(data, 4);
                packet.y = BitConverter.ToDouble(data, 12);
                packet.time = BitConverter.ToInt64(data, 20);
            }
            catch (Exception e)
            {
                packet.userID = -1;
                packet.x = -1;
                packet.y= -1;
                packet.time= -1;
            }
            return packet;
        }

        public static byte[] getBytes(UserPacket packet)
        {
            byte[] data = new byte[28];
            byte[] uID = BitConverter.GetBytes(packet.userID);
            byte[] uX = BitConverter.GetBytes(packet.x);
            byte[] uY = BitConverter.GetBytes(packet.y);
            byte[] uTime = BitConverter.GetBytes(packet.time);
            uID.CopyTo(data, 0);
            uX.CopyTo(data, 4);
            uY.CopyTo(data, 12);
            uTime.CopyTo(data, 20);
            return data;
        }

        public override string ToString()
        {
            return $"userID: {userID}, x: {x}, y: {y}, time:{time}";
        }
    }
}