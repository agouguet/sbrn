﻿// Copyright (c) 2021, Members of Yale Interactive Machines Group, Yale University,
// Nathan Tsoi
// All rights reserved.
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree. 

using UnityEngine;
using Unity.Robotics.ROSTCPConnector;

namespace SEAN.Scenario
{

    public class GroupPublisher : MonoBehaviour
    {
        private ROSConnection ros;
        private SEAN sean;

        public string topicName = "/social_sim/group_positions";
        public string frame = "map";

        void Start()
        {
            ros = ROSConnection.GetOrCreateInstance();
            ros.RegisterPublisher<RosMessageTypes.Geometry.PoseArrayMsg>(topicName);
            sean = SEAN.instance;
        }

        private void Update()
        {
            RosMessageTypes.Geometry.PoseArrayMsg message = new RosMessageTypes.Geometry.PoseArrayMsg();
            message.header.frame_id = frame;
            message.header.stamp = sean.clock.LastPublishedTime();
            Trajectory.TrackedGroup[] groups = sean.pedestrianBehavior.groups;
            message.poses = new RosMessageTypes.Geometry.PoseMsg[groups.Length];
            int i = 0;
            foreach (Trajectory.TrackedGroup group in groups)
            {
                message.poses[i++] = Util.Geometry.GetMPose(group.gameObject.transform);
            }
            ros.Publish(topicName, message);
        }
    }
}
