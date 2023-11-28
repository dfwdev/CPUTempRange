using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempUI.Classes
{
    public class SensorDataRow
    {
        private float? current = 0;

        public int SensorId { get; set; }
        public string Name { get; set; }
        public float? Current 
        { 
            get
            {
                return current;
            }

            set
            {
                current = value;
                SetExtremes(value);
                AddToHistory(value);
            } 
        }
        public float? Minimum { get; set; } = null;
        public float? Maximum { get; set; } = null;
        public float? Average 
        {
            get
            {
                return History.Count() > 0 ? (History.Sum() / (float)History.Count()) : 0;
            }
                
        }
        public List<float?> History { get; set; } = new List<float?>();

        public void Reset()
        {
            Minimum = 0;
            Maximum = 0;
            History.Clear();
        }

        private void SetExtremes(float? sensorReading)
        {
            if (sensorReading != null && sensorReading.HasValue)
            {
                if (Minimum == null || Minimum == 0 || sensorReading < Minimum)
                {
                    Minimum = sensorReading.Value;
                }

                if (Maximum == null || sensorReading > Maximum)
                {
                    Maximum = sensorReading.Value;
                }
            }
        }

        private void AddToHistory(float? sensorReading)
        {
            History.Add(sensorReading);
        }
    }
}
