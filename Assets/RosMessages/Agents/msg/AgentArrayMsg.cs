//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Agents
{
    [Serializable]
    public class AgentArrayMsg : Message
    {
        public const string k_RosMessageName = "agents_msgs/AgentArray";
        public override string RosMessageName => k_RosMessageName;

        public Std.HeaderMsg header;
        public AgentMsg[] agents;

        public AgentArrayMsg()
        {
            this.header = new Std.HeaderMsg();
            this.agents = new AgentMsg[0];
        }

        public AgentArrayMsg(Std.HeaderMsg header, AgentMsg[] agents)
        {
            this.header = header;
            this.agents = agents;
        }

        public static AgentArrayMsg Deserialize(MessageDeserializer deserializer) => new AgentArrayMsg(deserializer);

        private AgentArrayMsg(MessageDeserializer deserializer)
        {
            this.header = Std.HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.agents, AgentMsg.Deserialize, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.WriteLength(this.agents);
            serializer.Write(this.agents);
        }

        public override string ToString()
        {
            return "AgentArrayMsg: " +
            "\nheader: " + header.ToString() +
            "\nagents: " + System.String.Join(", ", agents.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}