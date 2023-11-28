using LibreHardwareMonitor.Hardware;
using LibreHardwareMonitor.Hardware.Cpu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempUI.Classes;

namespace TempUI
{
    public partial class Form1 : Form
    {
        private Computer computer = new Computer
        {
            IsCpuEnabled = true,
            IsGpuEnabled = false,
            IsMemoryEnabled = false,
            IsMotherboardEnabled = false,
            IsControllerEnabled = false,
            IsNetworkEnabled = false,
            IsStorageEnabled = false,
            IsBatteryEnabled = false,
            IsPsuEnabled = false,            
        };

        public float[] tempSpread = new float[105];
        public float readings = 0;

        public List<SensorDataRow> sensorDataRows = new List<SensorDataRow>();
        public List<TempSpreadDataRow> tempSpreadDataRows = new List<TempSpreadDataRow>();
        public BindingSource sensorDataGridViewSource = new BindingSource();
        public BindingSource tempSpreadDataGridViewSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            computer.Open();

            timer1.Start();

            this.ReadSensors();

            // Sensor DataGridView.
            sensorDataGridViewSource.DataSource = sensorDataRows;
            sensorDataGridView.DataSource = sensorDataGridViewSource;

            sensorDataGridView.Columns[0].DefaultCellStyle = new DataGridViewCellStyle
            {
                ForeColor = Color.Green,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
            };
            sensorDataGridView.Columns[2].DefaultCellStyle = new DataGridViewCellStyle
            {
                ForeColor = Color.Black,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                
            };
            sensorDataGridView.Columns[3].DefaultCellStyle = new DataGridViewCellStyle
            {
                ForeColor = Color.Blue,
                Alignment = DataGridViewContentAlignment.MiddleCenter,

            };
            sensorDataGridView.Columns[4].DefaultCellStyle = new DataGridViewCellStyle
            {
                ForeColor = Color.Red,
                Alignment = DataGridViewContentAlignment.MiddleCenter,

            };
            sensorDataGridView.Columns[5].DefaultCellStyle = new DataGridViewCellStyle
            {
                ForeColor = Color.Orange,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "0.00",

            };

            // Temp spread DataGridView.
            for (int i = 1; i < 100; i = i + 5)
            {
                tempSpreadDataRows.Add(new TempSpreadDataRow
                {
                    Range = i.ToString() + " - " + (i + 4).ToString(),
                    Percentage = string.Empty,
                });
            };

            tempSpreadDataGridViewSource.DataSource = tempSpreadDataRows;
            tempSpreadDataGridView.DataSource = tempSpreadDataGridViewSource;

            tempSpreadDataGridView.Columns[0].DefaultCellStyle = new DataGridViewCellStyle
            {
                ForeColor = Color.Green,
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            tempSpreadDataGridView.Columns[1].DefaultCellStyle = new DataGridViewCellStyle
            {
                ForeColor = Color.Blue,
                Alignment = DataGridViewContentAlignment.MiddleRight
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ReadSensors();

            tempSpreadDataRows.Clear();

            for (int i = 1; i < 100; i = i + 5)
            {
                tempSpreadDataRows.Add(new TempSpreadDataRow
                {
                    Range = i.ToString() + " - " + (i + 4).ToString(),
                    Percentage = ((tempSpread[i] + tempSpread[i + 1] + tempSpread[i + 2] + tempSpread[i + 3] + tempSpread[i + 4]) / readings).ToString("0.00%"),
                });
            };

            sensorDataGridViewSource.ResetBindings(false);
            sensorDataGridView.Refresh();

            tempSpreadDataGridViewSource.ResetBindings(false);
            tempSpreadDataGridView.Refresh();
        }

        private void BtnResetAvgMinMax_Click(object sender, EventArgs e)
        {
            foreach (SensorDataRow sdr in sensorDataRows)
            {
                sdr.Reset();
            }
        }

        private void BtnResetTempSpread_Click(object sender, EventArgs e)
        {
            tempSpread = new float[105];
            readings = 0;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            computer.Close();
        }

        private void ReadSensors()
        {
            computer.Accept(new UpdateVisitor());

            int sensorRow = -1;

            bool firstTimePopulate = sensorDataRows.Count == 0;
            bool addSensor = false;

            foreach (IHardware hardware in computer.Hardware)
            {
                foreach (ISensor sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        if (!sensor.Name.Contains("Distance") && sensor.Name.Contains("CPU Core"))
                        {
                            int hashPosition = sensor.Name.IndexOf('#');
                            int length = sensor.Name.Length;
                            string coreNumber = sensor.Name.Substring(hashPosition + 1, length - hashPosition - 1);

                            if (Int32.TryParse(coreNumber, out int numValue))
                            {
                                sensorRow = numValue;
                                addSensor = true;
                            }
                        }
                        else if (sensor.Name.Contains("Package"))
                        {
                            sensorRow = 0;
                            addSensor = true;

                            if (sensor.Value != null)
                            {
                                tempSpread[(int)sensor.Value]++;
                                readings++;
                            }
                        }
                        else
                        {
                            addSensor = false;
                        }

                        if (addSensor)
                        {
                            if (firstTimePopulate)
                            {
                                sensorDataRows.Add(new SensorDataRow
                                {
                                    SensorId = sensorRow,
                                    Name = sensor.Name,
                                    Current = sensor.Value,
                                    Minimum = 0,
                                    Maximum = 0,
                                });
                            }
                            else
                            {
                                SensorDataRow sensorDataRow = sensorDataRows.Where(f => f.SensorId == sensorRow).FirstOrDefault();

                                if (sensorDataRow != null)
                                {
                                    sensorDataRow.Current = sensor.Value;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
