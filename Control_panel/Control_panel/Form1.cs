using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Control_panel
{
    public partial class Form1 : Form
    {
        SerialPort port;
        delegate void Delegat1(); //tworzymy delegata do odbioru wiadomości
        Delegat1 pc;
        int[,] steps = new int[100,6];
        public Form1()
        {
            InitializeComponent();
            port = new SerialPort();
            port.ReadTimeout = 500;
            port.WriteTimeout = 50;
            port.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
            pc = new Delegat1(odebrane);
            options.Enter += new EventHandler(options_Enter); //linijka niekonieczna ze względu na przycisk odświeżania
            steps[0, 0] = 0;
        }
        void options_Enter(object sender, EventArgs e) //Funkcja wykorzystywana jako handler przy wchodzeniu do panelu opcji
        {
            //aktualizacja list
            this.cbport.Items.Clear();
            this.cbpair.Items.Clear();
            this.cbstop.Items.Clear();
            foreach (String s in SerialPort.GetPortNames()) this.cbport.Items.Add(s);
            foreach (String s in Enum.GetNames(typeof(Parity))) this.cbpair.Items.Add(s);
            foreach (String s in Enum.GetNames(typeof(StopBits))) this.cbstop.Items.Add(s);
            //aktualizacja nazw
            cbport.Text = port.PortName.ToString();
            cbspeed.Text = port.BaudRate.ToString();
            cbdata.Text = port.DataBits.ToString();
            cbpair.Text = port.Parity.ToString();
            cbstop.Text = port.StopBits.ToString();
        }

        private void brefresh_Click(object sender, EventArgs e){} //Przycisk Odśwież w panelu opcje

        private void bfabric_Click(object sender, EventArgs e) //Przycisk Domyślne w panelu opcje
        {
            this.cbport.Text = "COM6";
            this.cbspeed.Text = "9600";
            this.cbdata.Text = "8";
            this.cbpair.Text = "None";
            this.cbstop.Text = "One";
        }

        private void bcancel_Click(object sender, EventArgs e) //Przycisk Anuluj w panelu opcje
        {
            cbport.Text = port.PortName.ToString();
            cbspeed.Text = port.BaudRate.ToString();
            cbdata.Text = port.DataBits.ToString();
            cbpair.Text = port.Parity.ToString();
            cbstop.Text = port.StopBits.ToString();
        }

        private void status_Click(object sender, EventArgs e) //Otwieranie / zamykanie połączenia 
        {
            if (port.IsOpen) //połączenie 
            {
                status.BackColor = System.Drawing.Color.Red;
                port.Close();
                connection.Text = "Brak połączenia";
                dodajkolorowy(log, "\n Zakończono połączenie z " + port.PortName + "\n", System.Drawing.Color.Orange);
            }
            else
            {
                try
                {
                    //przypisujemy parametry z opcji
                    port.PortName = this.cbport.Text;
                    port.BaudRate = Int32.Parse(this.cbspeed.Text);
                    port.DataBits = Int32.Parse(this.cbdata.Text);
                    port.Parity = (Parity)Enum.Parse(typeof(Parity), this.cbpair.Text);
                    port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.cbstop.Text);
                    //otwieramy port
                    port.Open();
                    //zmieniamy elementy graficzne
                    status.BackColor = System.Drawing.Color.Green;
                    connection.Text = "Aktywne połączenie (port:" + port.PortName.ToString() + ", prędkość: " + port.BaudRate.ToString() + ", bity danych: " + port.DataBits.ToString() + "\n bity stopu: " + port.StopBits.ToString() + ", parzystosc: " + port.Parity.ToString() + ")";
                    dodajkolorowy(log, "Rozpoczęto połączenie z " + port.PortName + "\n", System.Drawing.Color.Orange);
                }
                catch (Exception exc) { MessageBox.Show("Błąd połączenie:\n" + exc.Message); }
            }
        }

        private void dodajkolorowy(System.Windows.Forms.RichTextBox log, string Text, System.Drawing.Color Color) //kolory w logu wpisów programu
        {
            var StartIndex = log.TextLength;
            log.AppendText(Text);
            var EndIndex = log.TextLength;
            log.Select(StartIndex, EndIndex - StartIndex);
            log.SelectionColor = Color;
        }

        private void odebrane() //dodanie przychodzących danych do pola logów
        {
            dodajkolorowy(log, port.ReadLine().ToString(), System.Drawing.Color.Blue);
        }

        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            log.Invoke(pc);
        }

        private void log_TextChanged(object sender, EventArgs e) //Okno logów
        {
            log.SelectionStart = log.Text.Length;
            log.ScrollToCaret();
            zmiana();
        }

        //sterowanie serwami     
        private void zmiana() //aktualizowanie suwakow poprzez potencjometry
        {
            if (port.IsOpen)
            {                
                try
                {
                    string serwo = port.ReadLine().ToString();
                    int wartosc = Int32.Parse(serwo.Split(':')[1].Substring(0,3));
                    string numer_serwa = serwo.Split(':')[0];

                    switch(numer_serwa)
                    {
                        case "Serwo1":
                            control1.Value = wartosc;
                            numeric1.Value = wartosc; 
                            break;
                        case "Serwo2":
                            control2.Value = wartosc;
                            numeric2.Value = wartosc;
                            break;
                        case "Serwo3":
                            control3.Value = wartosc;
                            numeric3.Value = wartosc;
                            break;
                        case "Serwo4":
                            control4.Value = wartosc;
                            numeric4.Value = wartosc;
                            break;
                        case "Serwo5":
                            control5.Value = wartosc;
                            numeric5.Value = wartosc;
                            break;
                        case "Serwo6":
                            control6.Value = wartosc;
                            numeric6.Value = wartosc;
                            break;
                        default:
                            break;
                    }

                }
                catch{ }
            }
        }

        private void control1_Scroll(object sender, ScrollEventArgs e)
        {
            if (port.IsOpen)
            {
                String serwo1 = "S1=" + (control1.Value).ToString() + " ";
                port.Write(serwo1);                    
                numeric1.Value = Int32.Parse((control1.Value).ToString());
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void numeric1_ValueChanged(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                String serwo1 = "S1=" + numeric1.Text + " ";
                port.Write(serwo1);
                control1.Value = Int32.Parse(numeric1.Text);
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void control2_Scroll(object sender, ScrollEventArgs e)
        {
            if (port.IsOpen)
            {
                String serwo2 = "S2=" + (control2.Value).ToString() + " ";
                port.Write(serwo2);
                numeric2.Value = Int32.Parse((control2.Value).ToString());
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void numeric2_ValueChanged(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                String serwo2 = "S2=" + numeric2.Text + " ";
                port.Write(serwo2);
                control2.Value = Int32.Parse(numeric2.Text);
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void control3_Scroll(object sender, ScrollEventArgs e)
        {
            if (port.IsOpen)
            {
                String serwo3 = "S3=" + (control3.Value).ToString() + " ";
                port.Write(serwo3);
                numeric3.Value = Int32.Parse((control3.Value).ToString());
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void numeric3_ValueChanged(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                String serwo3 = "S3=" + numeric3.Text + " ";
                port.Write(serwo3);
                control3.Value = Int32.Parse(numeric3.Text);
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void control4_Scroll(object sender, ScrollEventArgs e)
        {
            if (port.IsOpen)
            {
                String serwo4 = "S4=" + (control4.Value).ToString() + " ";
                port.Write(serwo4);
                numeric4.Value = Int32.Parse((control4.Value).ToString());
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void numeric4_ValueChanged(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                String serwo4 = "S4=" + numeric4.Text + " ";
                port.Write(serwo4);
                control4.Value = Int32.Parse(numeric4.Text);
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void control5_Scroll(object sender, ScrollEventArgs e)
        {
            if (port.IsOpen)
            {
                String serwo5 = "S5=" + (control5.Value).ToString() + " ";
                port.Write(serwo5);
                numeric5.Value = Int32.Parse((control5.Value).ToString());
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void numeric5_ValueChanged(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                String serwo5 = "S5=" + numeric5.Text + " ";
                port.Write(serwo5);
                control5.Value = Int32.Parse(numeric5.Text);
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void control6_Scroll(object sender, ScrollEventArgs e)
        {
            if (port.IsOpen)
            {
                String serwo6 = "S6=" + (control6.Value).ToString() + " ";
                port.Write(serwo6);
                numeric6.Value = Int32.Parse((control6.Value).ToString());
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void numeric6_ValueChanged(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                String serwo6 = "S6=" + numeric6.Text + " ";
                port.Write(serwo6);
                control6.Value = Int32.Parse(numeric6.Text);
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }
        
        private void clear_Click(object sender, EventArgs e)
        {
            log.Text = " ";
        }

        // kolejka ruchu

        private void add_Click(object sender, EventArgs e)
        {
            int dlugosc = steps[0, 0]+1;
            steps[dlugosc,0] = control1.Value;
            steps[dlugosc,1] = control2.Value;
            steps[dlugosc,2] = control3.Value;
            steps[dlugosc,3] = control4.Value;
            steps[dlugosc,4] = control5.Value;
            steps[dlugosc,5] = control6.Value;
            steps[0, 0] ++;

            //dodwanie elementow do listy
            ListViewItem step = new ListViewItem(dlugosc.ToString());
            step.SubItems.Add(control1.Value.ToString());
            step.SubItems.Add(control2.Value.ToString());
            step.SubItems.Add(control3.Value.ToString());
            step.SubItems.Add(control4.Value.ToString());
            step.SubItems.Add(control5.Value.ToString());
            step.SubItems.Add(control6.Value.ToString());
            stepbystep.Items.Add(step);
        }

        private void sub_Click(object sender, EventArgs e)
        {
            int dlugosc = steps[0, 0];
            steps[dlugosc, 0] = 0;
            steps[dlugosc, 1] = 0;
            steps[dlugosc, 2] = 0;
            steps[dlugosc, 3] = 0;
            steps[dlugosc, 4] = 0;
            steps[dlugosc, 5] = 0;
            steps[0, 0]--;
            //usuwanie elementow z listy
            if (stepbystep.SelectedItems.Count == 0) return;
            stepbystep.SelectedItems[0].Remove();
        }

        private void play_Click(object sender, EventArgs e)
        {
            string dl = steps[0, 0].ToString();
            int dlugosc = 0;
            bool succes = Int32.TryParse(dl, out dlugosc);
            dlugosc = steps[0, 0];
            String serwo1, serwo2, serwo3, serwo4, serwo5, serwo6;
            int milliseconds = speed.Value;
            for (int i = 1; i <= dlugosc; i++)
            {
                serwo1 = "S1=" + steps[i, 0] + " "; //serwo 1
                port.Write(serwo1);
                control1.Value = steps[i, 0];
                numeric1.Value = steps[i, 0];
                serwo2 = "S2=" + steps[i, 1] + " "; //serwo 2
                port.Write(serwo2);
                control2.Value = steps[i, 1];
                numeric2.Value = steps[i, 1];
                serwo3 = "S3=" + steps[i, 2] + " "; //serwo 3
                port.Write(serwo3);
                control3.Value = steps[i, 2];
                numeric3.Value = steps[i, 2];
                serwo4 = "S4=" + steps[i, 3] + " "; //serwo 4
                port.Write(serwo4);
                control4.Value = steps[i, 3];
                numeric4.Value = steps[i, 3];
                serwo5 = "S5=" + steps[i, 4] + " "; //serwo 5
                port.Write(serwo5);
                control5.Value = steps[i, 4];
                numeric5.Value = steps[i, 4];
                serwo6 = "S6=" + steps[i, 5] + " "; //serwo 5
                port.Write(serwo6);
                control6.Value = steps[i, 5];
                numeric6.Value = steps[i, 5];
                                
                System.Threading.Thread.Sleep(milliseconds);
            }
                serwo1 = "S1=" + steps[1, 0] + " "; //serwo 1
                port.Write(serwo1);
                control1.Value = steps[1, 0];
                numeric1.Value = steps[1, 0];
                serwo2 = "S2=" + steps[1, 1] + " "; //serwo 2
                port.Write(serwo2);
                control2.Value = steps[1, 1];
                numeric2.Value = steps[1, 1];
                serwo3 = "S3=" + steps[1, 2] + " "; //serwo 3
                port.Write(serwo3);
                control3.Value = steps[1, 2];
                numeric3.Value = steps[1, 2];
                serwo4 = "S4=" + steps[1, 3] + " "; //serwo 4
                port.Write(serwo4);
                control4.Value = steps[1, 3];
                numeric4.Value = steps[1, 3];
                serwo5 = "S5=" + steps[1, 4] + " "; //serwo 5
                port.Write(serwo5);
                control5.Value = steps[1, 4];
                numeric5.Value = steps[1, 4];
                serwo6 = "S6=" + steps[1, 5] + " "; //serwo 5
                port.Write(serwo6);
                control6.Value = steps[1, 5];
                numeric6.Value = steps[1, 5];

                System.Threading.Thread.Sleep(milliseconds);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
