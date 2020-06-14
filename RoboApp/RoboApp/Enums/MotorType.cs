using System;
using System.ComponentModel;

namespace RoboApp.Enums
{
    public enum MotorType
    {
        [Description("Head")]
        Head = 0,
        [Description("Neck")]
        Neck = 1,
        [Description("Right_Shoulder")]
        Right_Shoulder = 2,
        [Description("Left_Shoulder")]
        Left_Shoulder = 3,
        [Description("Right_Elbow")]
        Right_Elbow = 4,
        [Description("Left_Elbow")]
        Left_Elbow = 5,
        [Description("Right_Wrist")]
        Right_Wrist = 6,
        [Description("Left_Wrist")]
        Left_Wrist = 7,
        [Description("Right_Leg")]
        Right_Leg = 8,
        [Description("Left_Leg")]
        Left_Leg = 9,
    }
}
