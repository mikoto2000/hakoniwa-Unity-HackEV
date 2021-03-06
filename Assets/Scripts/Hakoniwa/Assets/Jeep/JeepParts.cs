﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Hakoniwa.Assets.EV3;

namespace Hakoniwa.Assets.Jeep

{
    public class JeepParts : MonoBehaviour, IEV3Parts
    {
        private string motor_a = "Jeep_Axle/Wheel_Front_Left";
        private string motor_b = "Jeep_Axle/Wheel_Front_Right";
        private string color_sensor = "Jeep_Axle/LineTraceSensorHolder/ColorSensor";
        private string ultra_sonic_sensor = "Jeep_Axle/UltrasonicSensor";

        public string GetColorSensor()
        {
            return color_sensor;
        }

        public string GetMotorA()
        {
            return motor_a;
        }

        public string GetMotorB()
        {
            return motor_b;
        }

        public string getUltraSonicSensor()
        {
            return ultra_sonic_sensor;
        }
    }
}
