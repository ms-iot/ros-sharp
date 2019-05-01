/*
© Siemens AG, 2017-2018
Author: Dr. Martin Bischoff (martin.bischoff@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Sensor
{
    public class LaserScan : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "sensor_msgs/LaserScan";
        public Standard.Header header;
        public double angle_min;
        public double angle_max;
        public double angle_increment;
        public double time_increment;
        public double range_min;
        public double range_max;
        public double?[] ranges;
        public double?[] intensities;

        public LaserScan()
        {
            header = new Standard.Header();
            angle_min = 0;
            angle_max = 0;
            angle_increment = 0;
            time_increment = 0;
            range_min = 0;
            range_max = 0;
            ranges = new double?[0];
            intensities = new double?[0];
        }
    }
}