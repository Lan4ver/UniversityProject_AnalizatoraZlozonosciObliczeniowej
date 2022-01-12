using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Projekt2_Podorozhnyi50402
{
    public partial class AnalizatorAlgorytmowSortowania : Form
    {
        const int mPMargines = 20;
        int mPProbaBadawcza = 100;
        int mPMaxRozmiarTabl = 50;
        double mPDolnaGranicaWartosci = 20.0d;
        double mPGornaGranicaWartosci = 300000.0d;

        double[] mPTabl;
        int[] mPTablInt;
        int[] mPLewaTabl;
        int[] mPPrawaTabl;
        float[] mPWynikiZpomiaru;
        float[] mPWynikiAnalityczne;
        int[] mPTablicaLOD;

        public AnalizatorAlgorytmowSortowania()
        {
            InitializeComponent();

            txtMinimalnaProbaBadawcza.Text = mPProbaBadawcza.ToString();
            txtMaxRozmiarSortTabl.Text = mPMaxRozmiarTabl.ToString();
            txtDolnaGranica.Text = mPDolnaGranicaWartosci.ToString();
            txtGornaGranica.Text = mPGornaGranicaWartosci.ToString();
            cmbAlgorytmSortowania.SelectedIndex = 0;

        }

        bool mPPobieranieDanych(out int mPProbaBadawczan, out int mPMaxRozmiarTabl, out double mPDolnaGranicaWartosci, out double mPGornaGranicaWartosci) 
        {
            mPProbaBadawczan = 0;
            mPMaxRozmiarTabl = 0;
            mPDolnaGranicaWartosci = 0;
            mPGornaGranicaWartosci = 0;

            if (!Int32.TryParse(txtMinimalnaProbaBadawcza.Text, out mPProbaBadawcza))
            {
                errorProvider1.SetError(txtMinimalnaProbaBadawcza, "ERROR: Wystąpił niedozwolony znak w zapisie");
                return false;
            }
            else
            {
                errorProvider1.Dispose();
            }

            if (!Int32.TryParse(txtMaxRozmiarSortTabl.Text, out mPMaxRozmiarTabl))
            {
                errorProvider1.SetError(txtMaxRozmiarSortTabl, "ERROR: Wystąpił niedozwolony znak w zapisie");
                return false;
            }
            else
            {
                errorProvider1.Dispose();
            }

            if (!Double.TryParse(txtDolnaGranica.Text, out mPDolnaGranicaWartosci))
            {
                errorProvider1.SetError(txtDolnaGranica, "ERROR: Wystąpił niedozwolony znak w zapisie");
                return false;
            }
            else
            {
                errorProvider1.Dispose();
            }

            if (!Double.TryParse(txtGornaGranica.Text, out mPGornaGranicaWartosci))
            {
                errorProvider1.SetError(txtGornaGranica, "ERROR: Wystąpił niedozwolony znak w zapisie");
                return false;
            }
            else
            {
                errorProvider1.Dispose();
            }


            return true;
        }


        private void btnAkceptacjaDanych_Click(object sender, EventArgs e)
        {

            if (!mPPobieranieDanych(out int mPProbaBadawczan, out int mPMaxRozmiarTabl, out double mPDolnaGranicaWartosci, out double mPGornaGranicaWartosci)) 
            {
                return;
            }
            
            mPTabl = new double[mPMaxRozmiarTabl];
            mPTablInt = new int[mPMaxRozmiarTabl];
            mPLewaTabl = new int[mPMaxRozmiarTabl / 2];
            mPPrawaTabl = new int[mPMaxRozmiarTabl / 2];
            mPWynikiZpomiaru = new float[mPMaxRozmiarTabl];
            mPWynikiAnalityczne = new float[mPMaxRozmiarTabl];
            mPTablicaLOD = new int[mPProbaBadawcza];

            btnWynikiTabelaryczne.Enabled = true;
            btnWynikiWykresowe.Enabled = true;
            btnResetuj.Enabled = true;

            btnAkceptacjaDanych.Enabled = false;

        }

        private void btnWynikiTabelaryczne_Click(object sender, EventArgs e)
        {
            int mPLicznikOD;
            float mPSumaOD, mPSredniaOD;
            Random mPRnd = new Random();

            Sortowanie AlgorymySortowania = new Sortowanie();

            for (int l = 0; l < mPMaxRozmiarTabl; l++)
            {
                for (int k = 0; k < mPProbaBadawcza; k++)
                {
                    for (int i = 0; i < mPMaxRozmiarTabl; i++)
                    {
                        mPTabl[i] = mPRnd.NextDouble() * (mPGornaGranicaWartosci - mPDolnaGranicaWartosci) + mPDolnaGranicaWartosci;
                        mPTablInt[i] = Convert.ToInt32(Math.Round(mPTabl[i]));
                    }
                    switch (cmbAlgorytmSortowania.SelectedIndex)
                    {
                        case 0:
                            mPLicznikOD = AlgorymySortowania.SelectSort(ref mPTabl);
                            break;
                        case 1:
                            mPLicznikOD = AlgorymySortowania.InsertSort(ref mPTabl);
                            break;
                        case 2:
                            mPLicznikOD = AlgorymySortowania.ShellSort(ref mPTabl);
                            break;
                        case 3:
                            mPLicznikOD = AlgorymySortowania.HeapSort(ref mPTabl);
                            break;

                        default:
                            errorProvider1.SetError(btnWynikiTabelaryczne, "UWAGA: jeszcze nie ukończyłem prac nad tym algorytmem");
                            return;

                    }
                    mPTablicaLOD[k] = mPLicznikOD;
                }

                mPSumaOD = 0.0F;
                for (int j = 0; j < mPProbaBadawcza; j++)
                {
                    mPSumaOD += mPTablicaLOD[j];

                    mPSredniaOD = mPSumaOD / mPProbaBadawcza;

                    mPWynikiZpomiaru[l] = mPSredniaOD;
                }

                switch (cmbAlgorytmSortowania.SelectedIndex)
                {
                    case 0:
                        mPWynikiAnalityczne[l] = (l * (l - 1)) / 2;
                        break;
                    case 1:
                        mPWynikiAnalityczne[l] = (l * (l - 1));
                        break;
                    case 2:
                        mPWynikiAnalityczne[l] = (float)(l * Math.Log(l));
                        break;
                    case 3:
                        mPWynikiAnalityczne[l] = (float)((l + 10) * Math.Log10(50));
                        break;
                    case 4:
                        mPWynikiAnalityczne[l] = (float)(l * Math.Log(l));
                        break;
                    case 5:
                        mPWynikiAnalityczne[l] = (float)(l * Math.Log(l));
                        break;
                    case 6:
                        mPWynikiAnalityczne[l] = (float)(l * Math.Log(l));
                        break;
                    case 7:
                        mPWynikiAnalityczne[l] = (float)(l + Math.Pow(l,2)/mPTablicaLOD[l] + mPTablicaLOD[l]);
                        break;
                    default:
                        errorProvider1.SetError(btnWynikiTabelaryczne, "UWAGA: jeszcze nie ukończyłem prac nad tym algorytmem");
                        return;
                }
            }

            dgvTabelaWynikow.Location = new Point(300, 150);
            dgvTabelaWynikow.Width = (int)(this.Width * 0.55F);
            dgvTabelaWynikow.Height = (int)(this.Height * 0.5F);

            for (int i = 0; i < mPMaxRozmiarTabl; i++)
            {
                dgvTabelaWynikow.Rows.Add();
                dgvTabelaWynikow.Rows[i].Cells[0].Value = i;
                dgvTabelaWynikow.Rows[i].Cells[1].Value = String.Format("{0:F2}", mPWynikiZpomiaru[i]);
                dgvTabelaWynikow.Rows[i].Cells[2].Value = String.Format("{0:F2}", mPWynikiAnalityczne[i]);
                dgvTabelaWynikow.Rows[i].Cells[3].Value = i;

                if (i % 2 == 0)
                {
                    dgvTabelaWynikow.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
                    dgvTabelaWynikow.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                    dgvTabelaWynikow.Rows[i].Cells[2].Style.BackColor = Color.LightGray;
                    dgvTabelaWynikow.Rows[i].Cells[3].Style.BackColor = Color.LightGray;
                }
                else
                {
                    dgvTabelaWynikow.Rows[i].Cells[0].Style.BackColor = Color.White;
                    dgvTabelaWynikow.Rows[i].Cells[1].Style.BackColor = Color.White;
                    dgvTabelaWynikow.Rows[i].Cells[2].Style.BackColor = Color.White;
                    dgvTabelaWynikow.Rows[i].Cells[3].Style.BackColor = Color.White;
                }

                dgvTabelaWynikow.Rows[i].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTabelaWynikow.Rows[i].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTabelaWynikow.Rows[i].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTabelaWynikow.Rows[i].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgvTabelaWynikow.Visible = true;
            btnWynikiTabelaryczne.Enabled = false;
            chart1.Visible = false;
        }

        private void txtMinimalnaProbaBadawcza_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMinimalnaProbaBadawcza.Text, out mPProbaBadawcza))
            {
                errorProvider1.SetError(txtMinimalnaProbaBadawcza, "ERROR: wpodanej liczności Próby Badawczej wystąpił niedozwolony znak");
            }
        }

        private void btnWynikiWykresowe_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;

            chart1.Series.Clear();
            chart1.Series.Add("Koszt czasowy z pomiaru");
            chart1.Series.Add("Analityczny koszt czasowy");
            chart1.Series.Add("Koszt pamięciowy");
            chart1.ChartAreas[0].AxisX.Title = "Operation";
            chart1.ChartAreas[0].AxisY.Title = "Time";


            chart1.Series[0].Name = "Koszt czasowy z pomiaru";
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series[0].Color = Color.Black;
            chart1.Series[0].BorderDashStyle = ChartDashStyle.Solid;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0].IsVisibleInLegend = true;

            chart1.Series[1].Name = "Koszt czasowy wg. wzoru";
            chart1.Series[1].ChartType = SeriesChartType.Spline;
            chart1.Series[1].Color = Color.Red;
            chart1.Series[1].BorderDashStyle = ChartDashStyle.DashDot;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[1].IsVisibleInLegend = true;

            chart1.Series[2].Name = "Koszt pamięci";
            chart1.Series[2].ChartType = SeriesChartType.Spline;
            chart1.Series[2].Color = Color.Green;
            chart1.Series[2].BorderDashStyle = ChartDashStyle.Dash;
            chart1.Series[2].BorderWidth = 2;
            chart1.Series[2].IsVisibleInLegend = true;

            for (int i = 0; i < mPMaxRozmiarTabl; i++)
            {
                chart1.Series[0].Points.AddXY(i, mPWynikiZpomiaru[i]);
                chart1.Series[1].Points.AddXY(i, mPWynikiAnalityczne[i]);
                chart1.Series[2].Points.AddXY(i, i);
            }

            btnWynikiWykresowe.Enabled = false;
            dgvTabelaWynikow.Visible = false;
            btnWybierzKolorLinii.Enabled = true;
            btnWybierzKolorTłaDlaWykresu.Enabled = true;
            cmbStylLinii.Enabled = true;
            trcGrubosc.Enabled = true;
            txtGrubosc.Enabled = true;
        }

        private void btnWybierzKolorLinii_Click(object sender, EventArgs e)
        {
            ColorDialog colorLinii = new ColorDialog();
            colorLinii.Color = chart1.Series[0].Color;
            if (colorLinii.ShowDialog() == DialogResult.OK)
            {
                chart1.Series[0].Color = colorLinii.Color;
                btnColor.BackColor = colorLinii.Color;
            }
        }

        private void btnWybierzKolorTłaDlaWykresu_Click(object sender, EventArgs e)
        {
            ColorDialog colorTla = new ColorDialog();
            colorTla.Color = chart1.BackColor;
            if (colorTla.ShowDialog() == DialogResult.OK)
            {
                chart1.BackColor = colorTla.Color;
                btnKolorTła.BackColor = colorTla.Color;
            }
        }

        private void cmbStylLinii_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbStylLinii.SelectedIndex)
            {
                case 0:                    
                     chart1.Series[0].BorderDashStyle = ChartDashStyle.Dash;
                     break;                   
                case 1:
                    chart1.Series[0].BorderDashStyle = ChartDashStyle.Dot;
                    break;
                case 2:
                    chart1.Series[0].BorderDashStyle = ChartDashStyle.DashDot;
                    break;
                case 3:
                    chart1.Series[0].BorderDashStyle = ChartDashStyle.DashDotDot;
                    break;
                case 4:
                    chart1.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                    break;
                default:
                    chart1.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                    break;
            }
        }

        private void trcGrubosc_Scroll(object sender, EventArgs e)
        {
            chart1.Series[0].BorderWidth = trcGrubosc.Value;
            txtGrubosc.Text = trcGrubosc.Value.ToString();
        }

        private void txtGrubosc_TextChanged(object sender, EventArgs e)
        {
            string mPGrubosc = txtGrubosc.Text;

            chart1.Series[0].BorderWidth = Int32.Parse(mPGrubosc);

            trcGrubosc.Value = Int32.Parse(mPGrubosc);
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            btnAkceptacjaDanych.Enabled = true;
            btnColor.Enabled = false;
            btnKolorTła.Enabled = false;
            btnWybierzKolorLinii.Enabled = false;
            btnWybierzKolorTłaDlaWykresu.Enabled = false;
            btnWynikiTabelaryczne.Enabled = false;
            btnWynikiWykresowe.Enabled = false;
            dgvTabelaWynikow.Visible = false;
            chart1.Visible = false;
            trcGrubosc.Enabled = false;
            cmbStylLinii.Enabled = false;
            txtGrubosc.Enabled = false;
           
            txtMinimalnaProbaBadawcza.Text = mPProbaBadawcza.ToString();
            txtMaxRozmiarSortTabl.Text = mPMaxRozmiarTabl.ToString();
            txtDolnaGranica.Text = mPDolnaGranicaWartosci.ToString();
            txtGornaGranica.Text = mPGornaGranicaWartosci.ToString();
            cmbAlgorytmSortowania.SelectedIndex = 0;
            btnColor.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var libraryForm = new FiszkaKsiozki();
            libraryForm.Show();
        }


    }
}
