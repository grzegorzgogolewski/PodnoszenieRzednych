using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PodnoszenieRzednych
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            rbtnAll.Checked = true;
            stsLabel.Text = "Ready";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK) {

                txtFileName.Text = dlgOpen.FileName;

                btnStart.Enabled = true;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            StreamWriter outputFile;
            StreamWriter txtFile;
            StreamWriter logFile;

            string line;

            double number_converted;
            double number_new;
            bool textIsNumeric;
            bool textIsFloating;

            int preciseNumber;

            string number_new_str;

            double number_big;
            int number_first;
            int number_second;
            int number_precise;

            string line_original;

            stsLabel.Text = "Reading file...";

            inputFile = new StreamReader(new FileStream(dlgOpen.FileName, FileMode.Open), Encoding.Default);

            outputFile = new StreamWriter(new FileStream(dlgOpen.FileName.Substring(0, dlgOpen.FileName.Length-4) + "_out.dxf", FileMode.Create), Encoding.Default);

            txtFile = new StreamWriter(new FileStream(dlgOpen.FileName.Substring(0, dlgOpen.FileName.Length - 4) + ".txt", FileMode.Create), Encoding.Default);

            logFile = new StreamWriter(new FileStream(dlgOpen.FileName.Substring(0, dlgOpen.FileName.Length - 4) + ".log", FileMode.Create), Encoding.Default);

            while ((line = inputFile.ReadLine()) != null)
            {

                if (line.Equals("AcDbText"))
                {
                    outputFile.WriteLine(line);

                    // find next 10
                    line = inputFile.ReadLine();

                    if (line.TrimStart(' ').Equals("10"))
                    {
                        outputFile.WriteLine(line);

                        line = inputFile.ReadLine(); // 10 value
                        outputFile.WriteLine(line);
                        line = inputFile.ReadLine(); // 20
                        outputFile.WriteLine(line);
                        line = inputFile.ReadLine(); // 20 value
                        outputFile.WriteLine(line);
                        line = inputFile.ReadLine(); // 30
                        outputFile.WriteLine(line);
                        line = inputFile.ReadLine(); // 30 value
                        outputFile.WriteLine(line);
                        line = inputFile.ReadLine(); // 40
                        outputFile.WriteLine(line);
                        line = inputFile.ReadLine(); // 40 value
                        outputFile.WriteLine(line);
                        line = inputFile.ReadLine(); // 1
                        outputFile.WriteLine(line);
                        line = inputFile.ReadLine(); // 1 value

                        txtFile.WriteLine(line);

                        line_original = line;

                        number_converted = 0;
                        textIsNumeric = double.TryParse(line.Replace(',', '.'), out number_converted);

                        if (textIsNumeric)
                        {
                            line = line.Replace(',', '.');
                                
                            textIsFloating = line.Contains(".");

                            if (textIsFloating)
                            {
                                preciseNumber = line.Substring(line.IndexOf('.') + 1 ).Length;
                            }
                            else
                            {
                                preciseNumber = 0;
                            }
                            
                            if (rbtnAll.Checked)    
                            {
                                if (preciseNumber == 2)
                                {
                                    number_new = number_converted + Convert.ToDouble(txtLevel.Text);

                                    outputFile.WriteLine(number_new.ToString("0.00"));
                                    logFile.WriteLine("liczba: " + line_original + "\t" + "nowa: " + number_new.ToString("0.00") + "\t" + "precyzja: " + preciseNumber);
                                }
                                else if (preciseNumber == 1)
                                {
                                    number_new = number_converted + Convert.ToDouble(txtLevel.Text);

                                    number_new_str = number_new.ToString();

                                    if (number_new_str.Contains("."))
                                    {
                                        number_precise = number_new_str.Substring(number_new_str.IndexOf('.') + 1).Length;

                                        if (number_precise==1)
                                        {
                                            outputFile.WriteLine(number_new.ToString("0.0"));
                                            logFile.WriteLine("liczba: " + line_original + "\t" + "nowa: " + number_new.ToString("0.0") + "\t" + "precyzja: " + preciseNumber);
                                        }
                                        else
                                        {

                                            number_big = Convert.ToDouble(number_new_str.Substring(0, number_new_str.IndexOf('.') + 2));
                                            number_first = Convert.ToInt32(number_new_str.Substring(number_new_str.IndexOf('.')+1, 1));
                                            number_second = Convert.ToInt32(number_new_str.Substring(number_new_str.IndexOf('.')+2, 1));

                                            if (number_second >=0 && number_second <=4)
                                            {
                                                number_new = number_big;
                                            }
                                            else if ((number_second >= 6 && number_second <= 9))
                                            {
                                                number_new = number_big + 0.1;
                                            }
                                            else
                                            {
                                                if (number_first== 1 || number_first == 3 || number_first == 5 || number_first == 7 || number_first == 9)
                                                {
                                                    number_new = number_big + 0.1;
                                                }
                                                else
                                                {
                                                    number_new = number_big;
                                                }
                                            }

                                            outputFile.WriteLine(number_new.ToString("0.0"));
                                            logFile.WriteLine("liczba: " + line_original + "\t" + "nowa: " + number_new.ToString("0.0") + "\t" + "precyzja: " + preciseNumber);

                                        }


                                    }
                                    else
                                    {
                                        outputFile.WriteLine(number_new.ToString("0.0"));
                                        logFile.WriteLine("liczba: " + line_original + "\t" + "nowa: " + number_new.ToString("0.0") + "\t" + "precyzja: " + preciseNumber);
                                    }

                                }
                                else
                                {
                                    outputFile.WriteLine(line);
                                    logFile.WriteLine("liczba: " + line_original + "\t" + "nowa: " + "-" + "\t" + "precyzja: " + preciseNumber);
                                }
                            }

                            if (rbtnPrecise.Checked)
                            {
                                if (preciseNumber == 2)
                                {
                                    number_new = number_converted + Convert.ToDouble(txtLevel.Text);

                                    outputFile.WriteLine(number_new.ToString("0.00"));
                                    logFile.WriteLine("liczba: " + line_original + "\t" + "nowa: " + number_new.ToString("0.00") + "\t" + "precyzja: " + preciseNumber);
                                }
                                else
                                {
                                    outputFile.WriteLine(line);
                                    logFile.WriteLine("liczba: " + line_original + "\t" + "nowa: " + "-" + "\t" + "precyzja: " + preciseNumber);
                                }
                            }
                                                        
                        }
                        else
                        {
                            outputFile.WriteLine(line);
                        }
                        
                    }
                    else
                    {
                        outputFile.WriteLine(line);
                    }
                }
                else
                {
                    outputFile.WriteLine(line);
                } 

            }

            logFile.Close();
            txtFile.Close();
            outputFile.Close();
            inputFile.Close();

            stsLabel.Text = "Ready";

            MessageBox.Show("Przetwarzanie zakończone!");

        }
    }
}
