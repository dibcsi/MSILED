using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MSILED
{
    public partial class frmTest : Form
    {

        private LightControl lc = null;
        private RGBDevice[] rgbDevices = null;


        public frmTest()
        {
            InitializeComponent();
        }



        private void Form_rgbcontrol_Load(object sender, EventArgs e)
        {

            string err = "";

            if (lc == null)
            {
                lc = new LightControl();

                err = lc.LightControlInit();

                if (err == "") err = lc.GetRGBDevices(out rgbDevices);

                if (err != "")
                {
                    MessageBox.Show(err);
                    lc = null;
                }
                else
                {
                    //mb list
                    for (int i = 0; i < rgbDevices.Length; i++)
                    {
                        string mbname = rgbDevices[i].DevName;
                        comboBox_mbname.Items.Add(mbname);
                    }

                    if (comboBox_mbname.Items.Count > 0)
                    {
                        comboBox_mbname.SelectedIndex = 0;
                    }
                }

            }
        }







        private void setLedList()
        {
            int mbidx = comboBox_mbname.SelectedIndex;

            comboBox_ledlist.Items.Clear();


            //led list
            for (int i = 0; i < rgbDevices[mbidx].leddevices.Length; i++)
            {
                comboBox_ledlist.Items.Add(i);
            }

            if (comboBox_ledlist.Items.Count > 0)
            {
                comboBox_ledlist.SelectedIndex = 0;
            }

        }


        private void setLEDInfos()
        {
            int mbidx = comboBox_mbname.SelectedIndex;
            int ledidx = comboBox_ledlist.SelectedIndex;

            string[] stylelist = rgbDevices[mbidx].leddevices[ledidx].StyleList;

            comboBox_stylelist.Items.Clear();

            //style list
            for (int i = 0; i < stylelist.Length; i++)
            {
                string style = stylelist[i];
                comboBox_stylelist.Items.Add(style);
            }

            if (comboBox_stylelist.Items.Count > 0)
                setCombotocurrStyle(mbidx, ledidx);


            setButtontocurrColor(mbidx, ledidx);
        }

        private void setButtontocurrColor(int mbidx, int ledidx)
        {
            RGBColor currcolor = null;
            string err = lc.GetDevLed_Color(rgbDevices[mbidx], ledidx, out currcolor);

            button_color.BackColor = Color.FromArgb(Convert.ToInt32(currcolor.R), Convert.ToInt32(currcolor.G), Convert.ToInt32(currcolor.B));
        }

        private void setCombotocurrStyle(int mbidx, int ledidx)
        {
            string currstyle = "";
            string err = lc.GetDevLed_Style(rgbDevices[mbidx], ledidx, out currstyle);

            if (err != "")
            {
                MessageBox.Show(err);
            }
            else
            {
                comboBox_stylelist.SelectedItem = currstyle;
            }
        }

        private void comboBox_mbname_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLedList();
        }


        private void comboBox_ledlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLEDInfos();
        }



        private void button_color_Click(object sender, EventArgs e)
        {

            colorDialog_getcolor.Color = button_color.BackColor;
            
            DialogResult result = colorDialog_getcolor.ShowDialog();
            
            if (result == DialogResult.OK)
            {
               button_color.BackColor = colorDialog_getcolor.Color;
            }


        }


        private void button_apply_Click(object sender, EventArgs e)
        {
            if (lc != null)
            {

                int mbidx = comboBox_mbname.SelectedIndex;
                int ledidx = comboBox_ledlist.SelectedIndex;


                //set style (device, ledidx)
                string style = comboBox_stylelist.Text;
                string err = lc.SetDevLed_Style(rgbDevices[mbidx], ledidx, style);

                if (err != "")
                {
                    MessageBox.Show(err);
                }

                //set color (device, ledidx)
                RGBColor color = new RGBColor(Convert.ToUInt32(button_color.BackColor.R), Convert.ToUInt32(button_color.BackColor.G), Convert.ToUInt32(button_color.BackColor.B));
                err = lc.SetDevLed_Color(rgbDevices[mbidx], ledidx, color);

                if (err != "")
                {
                    if (!err.Contains("supported"))
                        MessageBox.Show(err);
                }
            }
            else
            {
                MessageBox.Show("NO change");
            }
        }









        private void btnTest_Click(object sender, EventArgs e)
        {

            //test to get and set some values

            string err = "";



            //GET

            //get current color (device, ledidx)
            RGBColor currcolor = null;
            err = lc.GetDevLed_Color(rgbDevices[0], 0, out currcolor);


            //get current style (device, ledidx)
            string currstyle = "";
            err = lc.GetDevLed_Style(rgbDevices[0], 0, out currstyle);


            //get current speed (device, ledidx)
            uint currspeed = 0;
            err = lc.GetDevLed_Speed(rgbDevices[0], 0, out currspeed);


            //get current brightness (device, ledidx)
            uint currbrightness = 0;
            err = lc.GetDevLed_Brightness(rgbDevices[0], 0, out currbrightness);




            //SET

            //set current speed (device, ledidx)
            uint brightness = 1;
            err = lc.SetDevLed_Brightness(rgbDevices[0], 0, brightness);


            //set current brightness (device, ledidx)
            uint speed = 1;
            err = lc.SetDevLed_Speed(rgbDevices[0], 0, speed);


            //set current style (device, ledidx)
            string style = rgbDevices[0].leddevices[0].StyleList[6];
            err = lc.SetDevLed_Style(rgbDevices[0], 0, style);


            //set current color (device, ledidx)  //blue
            RGBColor color = new RGBColor(0, 0, 255);
            err = lc.SetDevLed_Color(rgbDevices[0], 0, color);



        }

        private async  void btnColorList_Click(object sender, EventArgs e)
        {
            //test
            //known color list..

            string style = rgbDevices[0].leddevices[0].StyleList[7];  //steady
            lc.SetDevLed_Style(rgbDevices[0], 0, style);

            /*
                        KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                        foreach (KnownColor knowColor in colors)
                        {
                            Color color = Color.FromKnownColor(knowColor);
                            RGBColor c = new RGBColor(Convert.ToUInt32(color.R), Convert.ToUInt32(color.G), Convert.ToUInt32(color.B));

                            lc.SetDevLed_Color(rgbDevices[0], 0, c);
                            await Task.Delay(1000);
                        }

                        */


            Type colorType = typeof(System.Drawing.Color);
            System.Reflection.PropertyInfo[] propInfos = 
                colorType.GetProperties(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.DeclaredOnly | 
                System.Reflection.BindingFlags.Public);
            foreach (System.Reflection.PropertyInfo propInfo in propInfos)
            {
                //Console.WriteLine(propInfo.Name);

                Color color = Color.FromName(propInfo.Name);

                RGBColor c = new RGBColor(Convert.ToUInt32(color.R), Convert.ToUInt32(color.G), Convert.ToUInt32(color.B));

                lc.SetDevLed_Color(rgbDevices[0], 0, c);
                await Task.Delay(1000);
            }

            MessageBox.Show("end");

        }
        



        //*test set color from enums
        enum Colors
        {
            Red,
            Orange,
            Green,
            Blue
        };
        private async void btnTestEnum_Click(object sender, EventArgs e)
        {

            string style = rgbDevices[0].leddevices[0].StyleList[7];  //steady
            lc.SetDevLed_Style(rgbDevices[0], 0, style);


            foreach (string cn in Enum.GetNames(typeof(Colors)))
            {

                Color color = Color.FromName(cn);

                RGBColor c = new RGBColor(Convert.ToUInt32(color.R), Convert.ToUInt32(color.G), Convert.ToUInt32(color.B));

                lc.SetDevLed_Color(rgbDevices[0], 0, c);
                await Task.Delay(1000);
            }


            MessageBox.Show("end");

        }

      





        private void listBox_cyclecolor_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            ListBox lb = (ListBox)sender;
            string argb = lb.Items[e.Index].ToString();
            Color c = Color.FromArgb(Convert.ToInt32(argb));


            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(c), e.Bounds);
            
            g.DrawString(argb, e.Font, new SolidBrush(Color.Black), new PointF(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }

        private void button_addcolor_Click(object sender, EventArgs e)
        {
            int argb = button_color.BackColor.ToArgb();
            listBox_cyclecolor.Items.Add(argb);
        }

        private async void button_startcycle_Click(object sender, EventArgs e)
        {

            int mbidx = comboBox_mbname.SelectedIndex;
            int ledidx = comboBox_ledlist.SelectedIndex;

            if (button_startcycle.Text == "Start")
            {
                button_startcycle.Text = "Stop";

                string style = rgbDevices[mbidx].leddevices[ledidx].StyleList[7];  //steady
                lc.SetDevLed_Style(rgbDevices[mbidx], ledidx, style);


                while (button_startcycle.Text == "Stop")
                {

                    foreach (var li in listBox_cyclecolor.Items)
                    {

                        Color color = Color.FromArgb(Convert.ToInt32(li));

                        RGBColor c = new RGBColor(Convert.ToUInt32(color.R), Convert.ToUInt32(color.G), Convert.ToUInt32(color.B));

                        lc.SetDevLed_Color(rgbDevices[mbidx], ledidx, c);
                        await Task.Delay(1000);
                    }
                }
            }
            else
            {
                button_startcycle.Text = "Start";
            }

        }
    }
}
