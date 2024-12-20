﻿public struct Parameters
{
    public const float DESIRED_SPEED = 0.7f;
    public const float PERCEPTION_RADIUS_AGENT = 2.5f;
    public const float T = 0.5f;
    public const float A = 1500f / 4; //2000
    public const float B = 0.08f * 2;
    public const float K = 1.2E5f;
    public const float KAPPA = 2.4E5f;

    public const float WALL_A = 600f * 4; // 600
    public const float WALL_B = 0.04f * 3; //0.08
    public const float WALL_K = 1.2E5f;
    public const float WALL_KAPPA = 2.4E5f;

    public const float TAN_A = 2000f;
    public const float TAN_B = 0.08f;

    public const float MAX_VEL = 1f;//0.5f / 0.02f;
    public const float NEXT_NAV_MIN_DIST = 0.3f;
    public const float CLOSE_ENOUGH_MIN_DIST = 0.2f;
    public const float BACKWARD_DAMPENING = 20;
    public const float LATERAL_DAMPENING = 5;
    public const float ROBOT_REPULSION_DAMPENING_MIN = 0.5f;
    public const float ROBOT_REPULSION_DAMPENING_MAX = 1.0f;
}