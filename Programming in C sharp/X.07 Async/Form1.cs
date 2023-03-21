using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X._007.Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            button1.Click += async (sender, e) =>
            {
                // ExampleMethodAsync returns a Task.
                await ExampleMethodAsync();
                textBox1.Text += "\r\nControl returned to Click event handler.\r\n";
            };
             * */

        }


        private async void button1_Click_1(object sender, EventArgs e)
        {
            // ExampleMethodAsync returns a Task.
            await ExampleMethodAsync();
            textBox1.Text += "\r\nControl returned to Click event handler.\r\n";
        }


        async Task ExampleMethodAsync()
        {
            // The following line simulates a task-returning asynchronous process.
            await Task.Delay(1000);
        }

    }
}
