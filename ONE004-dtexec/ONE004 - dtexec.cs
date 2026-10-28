using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONE004_dtexec
{
    public partial class Title : Form
    {
        string dataod="";
        string datado="";
        string sciezka="";
        string komenda="";
        string nazwatB2 = "";


        public Title()
        {
            InitializeComponent();
        }

        private void TextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tB1.Text = fbd.SelectedPath;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sciezkatemp="";
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string dataodtemp = dTP1.Text.ToString().Remove(4, 1);
                string datadotemp = dTP2.Text.ToString().Remove(4, 1);
                dataod = dataodtemp.Remove(6, 1);
                datado = datadotemp.Remove(6, 1);
            }
            catch(Exception ex)
            {
                lb5.Text = "Źle wprowadzono datę.";
                MessageBox.Show("Błąd: " + ex);
                lb5.Visible = true;
                Cursor.Current = Cursors.Default;
                return;
            }
            if(tB1.Text == "Pulpit")
            {
                sciezka = "%UserProfile%\\Desktop";
            }
            else
            {
                sciezkatemp = tB1.Text;
                sciezka = sciezkatemp.Replace("\\", "\\\\");
            }
            nazwatB2 = tB2.Text;
            


            
            //MessageBox.Show(sciezka+" "+sciezkatemp);
            if(dataod=="" || datado =="" ||sciezka == "" || nazwatB2 == "")
            {
                lb5.Text = "Nie wszystkie pola zostały wypełnione.";
                Cursor.Current = Cursors.Default;
                return;
            }
            else if (Convert.ToInt32(dataod) > Convert.ToInt32(datado))
            {
                lb5.Text = "Data od nie może wskazywać na dzień po wskazanym przez Data do.";
                Cursor.Current = Cursors.Default;
                return;
            }
            else
            {


                komenda = "dtexec.exe /FILE \"\\\"C:\\onesupport\\SSIS\\OneSupport\\OneSupport\\Audyt.dtsx\\\"\" /DECRYPT g%GJ@8f$%idsF__GsdsAs /CHECKPOINTING OFF /REPORTING EWCDI /SET \"\\\"\\Package.Variables[User::DataOd].Value\\\"\";" + dataod + " /SET \"\\\"\\Package.Variables[User::DataDo].Value\\\"\";" + datado + " /SET \"\\\"\\Package.Variables[User::FilePath].Value\\\"\";\"\\\""+sciezka+"\\"+nazwatB2+".txt\\\"\" ";
                lb5.Text = "";
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                try
                {
                    process.Start();
                    process.StandardInput.WriteLine(komenda);
                    process.StandardInput.Flush();
                    process.StandardInput.Close();
                    process.Close();


                    



                    //MessageBox.Show(process.StandardOutput.ReadToEnd());

                }
                catch (Exception expe)
                {
                    MessageBox.Show("Błąd przy egzekwowaniu wpisu do wiersza poleceń: " + expe);
                }

                    MessageBox.Show("Generuję audyt w tle.");
                    Cursor.Current = Cursors.Default;

                    return;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tB1.Text = fbd.SelectedPath;
        }

        private void TB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|]"))
            {
                e.Handled = true;
            }
        }
    }
}
