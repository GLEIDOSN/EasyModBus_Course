using EasyModbus;

namespace ApplicationModBus
{
    public partial class Form1 : Form
    {
        private ModbusClient modbusClient;

        public Form1()
        {
            InitializeComponent();
            modbusClient = CreateModbusClient();
        }

        private ModbusClient CreateModbusClient()
        {
            // Create instance of easymodbus object
            modbusClient = new ModbusClient("127.0.0.1", 502);

            // Make a connection to the network
            modbusClient.Connect();

            return modbusClient;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Read the first holding register and return value to our array
            var holdingRegistersArray = modbusClient.ReadHoldingRegisters(0, 1);

            // Set value of label with value of holding register
            lblValueHR.Text = holdingRegistersArray[0].ToString();
            pBarHR.Value = holdingRegistersArray[0];

            // Read input register
            var inputRegisterArray = modbusClient.ReadInputRegisters(0, 1);

            // Set value of label with value of input register
            lblValueIR.Text = inputRegisterArray[0].ToString();

            pBarIR.Value = inputRegisterArray[0];

            // Read input status
            var inputStatusArray = modbusClient.ReadDiscreteInputs(0, 1);

            // Set value of label with value of input status
            lblStatus.Text = inputStatusArray[0] ? "ON" : "OFF";
            txtGraficStatus.BackColor = inputStatusArray[0] ? Color.Green : Color.Red;

            // Read Coil
            var inputCoilArray = modbusClient.ReadCoils(0, 1);

            // Set value of label with value of coil
            lblCoil.Text = inputCoilArray[0] ? "ON" : "OFF";
            txtGrafficCoil.BackColor = inputCoilArray[0] ? Color.Green : Color.Red;
        }

        private void btnSR_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleRegister(0, Convert.ToInt32(txtRegVal.Text));
        }

        private void chbWSC_CheckedChanged(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(0, chbWSC.Checked);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modbusClient.Connected)
            {
                // Disconnect from network
                modbusClient.Disconnect();
            }
        }
    }
}