using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LittleManComputer
{
    public partial class Form1 : Form
    {
        bool bEnabled = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            for (int i = 0; i <= 10000; i += 500)
            {
                cbDelay.Items.Add(i);
            }
            cbDelay.SelectedIndex = 0;
            ResetDisplay();
        }

        private void ResetDisplay()
        {
            bEnabled = false;

            DataTable table = new DataTable();
            DataTable table1 = new DataTable();

            table.Columns.Add("source", typeof(string));
            table1.Columns.Add("source", typeof(string));

            for (int i = 0; i < 100; i++)
            {
                DataRow row = table.NewRow();
                DataRow row1 = table1.NewRow();
                if (i == 0)
                {
                    row.ItemArray = new object[] { "1" };
                    row1.ItemArray = new object[] { "1" };
                }
                else if (i == 99)
                {
                    row.ItemArray = new object[] { "0" };
                    row1.ItemArray = new object[] { "0" };
                }
                else
                {
                    row.ItemArray = new object[] { "HRS 1" };
                    row1.ItemArray = new object[] {"901" };
                }
                table.Rows.Add(row);
                table1.Rows.Add(row1);
            }

            dgvSrc.DataSource = table;
            dgvAsm.DataSource = table1;

            for (int i = 0; i < 100; i++)
            {
                dgvSrc.Rows[i].HeaderCell.Value = String.Format("{0}", i);
                dgvAsm.Rows[i].HeaderCell.Value = String.Format("{0}", i);
            }

            dgvSrc.CurrentCell = dgvSrc.Rows[1].Cells[0];
            dgvAsm.CurrentCell = dgvAsm.Rows[1].Cells[0];
            bEnabled = true;
        }


        private void dgvAsm_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(!bEnabled)
                return;

            int row = e.RowIndex;

            string s = (string)dgvAsm.Rows[row].Cells[0].Value;
            int sv = 0;
            try
            {
                sv = int.Parse(s, System.Globalization.NumberStyles.Integer);
            }
            catch (Exception)
            {
            }
            dgvAsm.Rows[row].Cells[0].Value = sv.ToString();

            Disassemble(row);
        }

        private void dgvSrc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!bEnabled)
                return;

            int row = e.RowIndex;
            string s = dgvSrc.Rows[row].Cells[0].Value.ToString();
            s = s.ToUpper();
            s = s.Trim();
            dgvSrc.Rows[row].Cells[0].Value = s;
            Assemble(row);
        }

        bool bDiasm = true;
        private void Disassemble(int row)
        {
            if (bDiasm == false)
                return;
            bAsm = false;

            WriteLine("Diassembling box #" + row.ToString());
            int code = 0;
            try
            {
                code = int.Parse(dgvAsm.Rows[row].Cells[0].Value.ToString(), System.Globalization.NumberStyles.Integer);
            }
            catch (Exception)
            {
            }

            code = (code > 0) ? code : (-code);
            string cmd = "";

            int d0 = code % 10;
            int d1 = (code / 10) % 10;
            int op = (code / 100) % 10;

            switch (op)
            {
                case 0:
                    cmd = String.Format("INP {0}{1}", d1, d0);
                    break;
                case 1:
                    cmd = String.Format("CLA {0}{1}", d1, d0);
                    break;
                case 2:
                    cmd = String.Format("ADD {0}{1}", d1, d0);
                    break;
                case 3:
                    cmd = String.Format("TAC {0}{1}", d1, d0);
                    break;
                case 4:
                    cmd = String.Format("SFT {0}{1}", d1, d0);
                    break;
                case 5:
                    cmd = String.Format("OUT {0}{1}", d1, d0);
                    break;
                case 6:
                    cmd = String.Format("STO {0}{1}", d1, d0);
                    break;
                case 7:
                    cmd = String.Format("SUB {0}{1}", d1, d0);
                    break;
                case 8:
                    cmd = String.Format("JMP {0}{1}", d1, d0);
                    break;
                case 9:
                    cmd = String.Format("HRS {0}{1}", d1, d0);
                    break;
            }

            dgvSrc.Rows[row].Cells[0].Value = cmd;
            dgvSrc.CurrentCell = dgvSrc.Rows[row].Cells[0];
            bAsm = true;
            WriteLine(String.Format("Box #{0} diassembled successfully", row));
        }

        private bool bAsm = true;
        private void Assemble(int row)
        {
            if (bAsm == false)
                return;

            bDiasm = false;
            WriteLine("Assembling box #" + row.ToString());
            string cmd = dgvSrc.Rows[row].Cells[0].Value.ToString();
            cmd = cmd.ToUpper().Trim();
            int asm = 0;

            string data;

            if ((IsCmd(cmd, "INP", out data)))
                asm = 0 + (ParseInt(data) % 100);
            else if ((IsCmd(cmd, "CLA", out data)))
                asm = 100 + (ParseInt(data) % 100);
            else if ((IsCmd(cmd, "ADD", out data)))
                asm = 200 + (ParseInt(data) % 100);
            else if ((IsCmd(cmd, "TAC", out data)))
                asm = 300 + (ParseInt(data) % 100);
            else if ((IsCmd(cmd, "SFT", out data)))
                asm = 400 + (ParseInt(data) % 100);
            else if ((IsCmd(cmd, "OUT", out data)))
                asm = 500 + (ParseInt(data) % 100);
            else if ((IsCmd(cmd, "STO", out data)))
                asm = 600 + (ParseInt(data) % 100);
            else if ((IsCmd(cmd, "SUB", out data)))
                asm = 700 + (ParseInt(data) % 100);
            else if ((IsCmd(cmd, "JMP", out data)))
                asm = 800 + (ParseInt(data) % 100);
            else if ((IsCmd(cmd, "HRS", out data)))
                asm = 900 + (ParseInt(data) % 100);
            else
            {
                asm = ParseInt(cmd);
                if ((asm >= 0) && (asm < 1000))
                {

                }
                else
                {
                    WriteLine("ERROR: Data must be within 3 digit and positive. Data will be truncated. Check data in box #" + row.ToString());
                    asm = asm > 0 ? asm : (-asm);
                    asm = asm % 1000;
                }
            }
            dgvAsm.Rows[row].Cells[0].Value = asm.ToString();
            dgvAsm.CurrentCell = dgvAsm.Rows[row].Cells[0];
            bDiasm = true;
            WriteLine(String.Format("Box #{0} assembled successfully", row));
        }

        private int ParseInt(string s)
        {
            s = s.Trim();
            try
            {
                return int.Parse(s, System.Globalization.NumberStyles.Integer);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private bool IsCmd(string s, string cmd, out string rm)
        {
            rm = "";
            s = s.Trim();

            int idx = s.IndexOf(cmd);
            if (idx == -1)
                return false;
            else if(idx > 0 )
                return false;

            rm = s.Remove(idx, cmd.Length);
            if(rm.Length > 0 )
            {
                if(rm.ToCharArray()[0] != ' ')
                {
                    return false;
                }
            }
            rm = rm.Trim();
            return true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CleanAll();
        }

        private void CleanAll()
        {
            for (int i = 1; i < 99; i++)
            {
                dgvSrc.Rows[i].Cells[0].Value = "HRS 1";
            }
            dgvSrc.CurrentCell = dgvSrc.Rows[1].Cells[0];
            dgvAsm.CurrentCell = dgvAsm.Rows[1].Cells[0];

        }

        private void WriteLine(String s)
        {
            try
            {
                rtbReport.Text += s + "\n";
                rtbReport.SelectionStart = rtbReport.Text.Length;
                rtbReport.ScrollToCaret();
            }
            catch (Exception)
            {
            }
        }

        private void ClearReport()
        {
            rtbReport.Clear();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Load Source File";
                dlg.Multiselect = false;
                dlg.Filter = "CARDIAC Source Program (*.crds) |*.crds|Text File (*.txt)|*.txt|All files (*.*)|*.*||";
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CleanAll();

                    System.IO.StreamReader sr = new System.IO.StreamReader(dlg.FileName);
                    for (int i = 1; i < 99; i++)
                    {
                        if (sr.EndOfStream == true)
                            break;
                        dgvSrc.Rows[i].Cells[0].Value = sr.ReadLine();
                    }
                    sr.Close();
                    dgvSrc.CurrentCell = dgvSrc.Rows[1].Cells[0];
                    dgvAsm.CurrentCell = dgvAsm.Rows[1].Cells[0];
                    WriteLine("Loaded source from file named " + dlg.FileName);
                }
            }
            catch (Exception)
            {
            }
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Title = "Save Source File";
                dlg.Filter = "CARDIAC Source Program (*.crds) |*.crds|Text File (*.txt)|*.txt|All files (*.*)|*.*||";
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < 99; i++)
                    {
                        sb.Append(dgvSrc.Rows[i].Cells[0].Value.ToString());
                        sb.Append("\n");
                    }
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(dlg.FileName, false, Encoding.ASCII);
                    sw.Write(sb.ToString());
                    sw.Flush();
                    sw.Close();
                    WriteLine("Saved source to file named " + dlg.FileName);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (btnRun.Text.ToLower().Trim() == "run")
            {
                Stop();
                Start();
            }
            else
            {
                Stop();
                btnRun.Text = "Run";
            }
        }

        private void PerformDelay()
        {
            int d = GetDelay();
            if (d > 0)
            {
                Thread.Sleep(d);
            }
        }
        private int GetDelay()
        {
            int del = 0;
            try
            {
                del = int.Parse(cbDelay.Text);
                del *= (del < 0) ? (-1) : 1;
            }
            catch (Exception)
            {
            }

            return del;
        }


        private Thread th = null;

        private void Start()
        {
            if (th != null)
                Stop();

            th = new Thread(new ThreadStart(ThreadProc));
            th.Start();
            while (!th.IsAlive) ;
        }

        private void Stop()
        {
            if(th == null)
                return;

            if (!th.IsAlive)
            {
                th = null; 
                return;
            }

            th.Abort();
            th.Join();
            th = null;
        }

        private delegate void dProcessProc();
        private int pc = 1;
        private int ac = 0;

        private void ThreadProc()
        {
            btnRun.Text = "Stop";
            WriteLine("Execution started...");
            try
            {
                while (true)
                {
                    Invoke(new dProcessProc(ProcessProc));
                    PerformDelay();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                try
                {
                    btnRun.Text = "Run";
                }
                catch (Exception)
                {
                }
                finally
                {
                    WriteLine("Execution ended.");
                }
            }
        }

        private void UpdateAC()
        {
            lbAC.Text = ac.ToString();
            if (ac == 0)
                lbFlag.Text = "Zero";
            else if (ac > 0)
                lbFlag.Text = "+";
            else
                lbFlag.Text = "-";

        }

        private void UpdatePC()
        {
            lbPC.Text = pc.ToString();
        }

        private void UpdateState()
        {
            UpdateAC();
            UpdatePC();
        }

        private int GetValueAt(int loc)
        {
            int v = 0;
            loc = loc % 100;
            try
            {
                v = int.Parse(dgvAsm.Rows[loc].Cells[0].Value.ToString(), System.Globalization.NumberStyles.Integer);
            }
            catch (Exception)
            {
            }
            return v;
        }

        private void SetValueAt(int loc, int v)
        {
            loc = loc % 100;
            try
            {
                dgvAsm.Rows[loc].Cells[0].Value = v.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void Hilite(int row)
        {
            dgvSrc.CurrentCell = dgvSrc.Rows[pc].Cells[0];
            dgvAsm.CurrentCell = dgvAsm.Rows[pc].Cells[0];
        }

        private void ProcessProc()
        {
            pc = pc % 100;
            int cmd = GetValueAt(pc);

            int d0 = cmd % 10;
            int d1 = (cmd/10) % 10;
            int op = (cmd/100) % 10;

            Hilite(pc);
            int v;
            switch (op)
            {
                case 0:
                    try
                    {
                        v = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter a value: ", "Inbox", "0"), 
                                           System.Globalization.NumberStyles.Integer);
                        SetValueAt(d1 * 10 + d0, v%1000);
                        WriteLine(String.Format("INBOX [{0}]: {1}", d1*10+d0, v%1000));
                    }
                    catch (Exception)
                    {
                        SetValueAt(d1 * 10 + d0, 0);
                    }
                    pc += 1;
                    break;
                case 1:
                    ac = 0;
                    ac += GetValueAt(d1 * 10 + d0);
                    pc += 1;
                    break;
                case 2:
                    ac += GetValueAt(d1 * 10 + d0);
                    pc += 1;
                    break;
                case 3:
                    if (ac < 0)
                        pc = d1 * 10 + d0;
                    else
                        pc += 1;
                    break;
                case 4:
                    ac = ac << d1;
                    ac = ac >> d0;
                    pc += 1;
                    break;
                case 5:
                    v = d1 * 10 + d0;
                    MessageBox.Show(String.Format("The value at cell {0} is {1}",
                                    v, GetValueAt(v)), "Outbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WriteLine(String.Format("OUTBOX [{0}]: {1}", v, GetValueAt(v)));
                    pc += 1;
                    break;
                case 6:
                    v = d1 * 10 + d0;
                    SetValueAt(v, ac);
                    pc += 1;
                    break;
                case 7:
                    v = d1 * 10 + d0;
                    ac -= GetValueAt(v);
                    pc += 1;
                    break;
                case 8:
                    SetValueAt(99, pc);
                    pc = d1 * 10 + d0;
                    break;
                case 9:
                    pc = d1 * 10 + d0;
                    Stop();
                    break;

            }
            UpdateState();
        }

        private void lkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cardiac (CARDboard Illustrative Aid to Computation) was a learning aid developed by David Hagelbarger ");
            sb.Append("and Saul Fingerman for Bell Telephone Laboratories in 1968 (Copyright 1966, 1968) to teach high ");
            sb.Append("school students how computers work. The kit consisted of an instruction manual and a die-cut ");
            sb.Append("cardboard \"computer\".\n");
            sb.Append("The computer \"operated\" by means of pencil and sliding cards. Any arithmetic was done in the ");
            sb.Append("head of the person operating the computer. The computer operated in base 10 and had 100 memory ");
            sb.Append("cells which could hold signed numbers from ±0 to ±999. It had an instruction set of 10 instructions ");
            sb.Append("which allowed CARDIAC to add, subtract, test, shift, input, output and jump.");
            sb.Append("\n");
            sb.Append("This is a simulator designed for designing and executing CARDIAC assembly codes.");
            sb.Append("\n\n");
            sb.Append("Author: Arnav Mukhopadhyay\n");
            sb.Append("Home Page: http://arnavguddu.6te.net/\n");
            sb.Append("Mail: gudduarnav@gmail.com\n");
            MessageBox.Show(sb.ToString(), "About Little Man Computer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenBrowser("http://arnavguddu.6te.net/");
        }

        private void OpenBrowser(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception)
            {
            }
        }

        private void lkLMC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenBrowser("http://en.wikipedia.org/wiki/CARDboard_Illustrative_Aid_to_Computation");
        }

        private void dgvSrc_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex == 0)
                e.Cancel = true;
            if (e.RowIndex == 99)
                e.Cancel = true;
        }

        private void dgvAsm_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex == 0)
                e.Cancel = true;
            if (e.RowIndex == 99)
                e.Cancel = true;
        }
    
    }

    

    

}
