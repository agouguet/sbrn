//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Gizmo
{
    public class MAwake : Message
    {
        public const string RosMessageName = "gizmo_msgs/Awake";

        public Geometry.MVector3 direction;
        public ushort relative_angle;
        public float score;

        public MAwake()
        {
            this.direction = new Geometry.MVector3();
            this.relative_angle = 0;
            this.score = 0.0f;
        }

        public MAwake(Geometry.MVector3 direction, ushort relative_angle, float score)
        {
            this.direction = direction;
            this.relative_angle = relative_angle;
            this.score = score;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(direction.SerializationStatements());
            listOfSerializations.Add(BitConverter.GetBytes(this.relative_angle));
            listOfSerializations.Add(BitConverter.GetBytes(this.score));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.direction.Deserialize(data, offset);
            this.relative_angle = BitConverter.ToUInt16(data, offset);
            offset += 2;
            this.score = BitConverter.ToSingle(data, offset);
            offset += 4;

            return offset;
        }

        public override string ToString()
        {
            return "MAwake: " +
            "\ndirection: " + direction.ToString() +
            "\nrelative_angle: " + relative_angle.ToString() +
            "\nscore: " + score.ToString();
        }
    }
}