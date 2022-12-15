using System.Linq;

namespace logistica_gpo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region autoinserimento

        private void crea_matrice_Click(object sender, EventArgs e)
        {
            // controlli
            if(nud_colonne.Value == 1) {
                MessageBox.Show("non è possibile creare una tabella 1x1");
                return;
            }

            if (nud_righe.Value == 1)
            {
                MessageBox.Show("non è possibile creare una tabella 1x1");
                return;
            }

            tab.Rows.Clear();
            tab.Columns.Clear();

            //colums
            if (nud_colonne.Value == 0) { return; }
            tab.Columns.Add(" ", " ");
            for (int i = 0; i <= nud_colonne.Value - 1; i++)
            {
                tab.Columns.Add($"P{i}", $"P{i}");
            }

            // rows
            if (nud_righe.Value == 0) { return; }
            for (int i = 0; i <= nud_righe.Value - 1; i++)
            {
                tab.Rows.Add($"D{i}");
            }


            tab.Columns.Add("tot UP", "tot UP");
            tab.Rows.Add("tot D");

            for (int i = 0; i < tab.RowCount; i++)
                for (int j = 1; j < tab.ColumnCount; j++)
                    tab[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            tab.Columns[" "].ReadOnly = true;

            //----------------------------------------------------------------------------


            tab2.Rows.Clear();
            tab2.Columns.Clear();

            //colums
            if (nud_colonne.Value == 0) { return; }
            tab2.Columns.Add(" ", " ");
            for (int i = 0; i <= nud_colonne.Value - 1; i++)
            {
                tab2.Columns.Add($"P{i}", $"P{i}");
            }

            // rows
            if (nud_righe.Value == 0) { return; }
            for (int i = 0; i <= nud_righe.Value - 1; i++)
            {
                tab2.Rows.Add($"D{i}");
            }


            tab2.Columns.Add("tot UP", "tot UP");
            tab2.Rows.Add("tot D");

            for (int i = 0; i < tab2.RowCount; i++)
                for (int j = 1; j < tab2.ColumnCount; j++)
                    tab2[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            tab2.Columns[" "].ReadOnly = true;
        }

        private void auto_inserimento_Click(object sender, EventArgs e)
        {
            if (nud_colonne.Value == null || nud_colonne.Value == 0)
            {
                MessageBox.Show("crea prima una tabella per preinserire i dati");
                return;
            }

            Random numberGenerator = new Random();
            for (int col = 1; col < tab.Columns.Count - 1; col++)
            {
                for (int row = 0; row < tab.Rows.Count - 1; row++)
                {
                    tab.Rows[row].Cells[col].Value = numberGenerator.Next(1, 100);
                    tab2.Rows[row].Cells[col].Value = tab.Rows[row].Cells[col].Value;
                }
            }

            // totali
            Random randNum = new Random();
            // var index_totd = dataGridView1.Rows.Count;
            int totaleIncrociato = randNum.Next(400, 600);

            int righe = tab.Rows.Count - 1;
            int colonne = tab.Columns.Count - 2;

            int[] b = randomList(tab.Columns.Count - 2, totaleIncrociato);
            int[] a = randomList(tab.Rows.Count - 1, totaleIncrociato);

            for (int col = 0; col < colonne; col++)
            {
                for (int row = 0; row < righe; row++)
                {
                    // colonne
                    tab.Rows[tab.Rows.Count - 1].Cells[col + 1].Value = b[col];
                    tab2.Rows[tab.Rows.Count - 1].Cells[col + 1].Value = tab.Rows[tab.Rows.Count - 1].Cells[col + 1].Value;

                    //righe
                    tab[tab.Columns.Count - 1, row].Value = a[row];
                    tab2[tab.Columns.Count - 1, row].Value = tab[tab.Columns.Count - 1, row].Value;
                }

                // dato nell'angolo
                tab.Rows[tab.Rows.Count - 1].Cells[tab.Columns.Count - 1].Value = totaleIncrociato;
                tab2.Rows[tab.Rows.Count - 1].Cells[tab.Columns.Count - 1].Value = tab.Rows[tab.Rows.Count - 1].Cells[tab.Columns.Count - 1].Value;
            }
            

        }
        #endregion

        #region tool
        public Point searchIndex(int min)
        {
            Point p = new Point();
            p.X = 0;
            p.Y = 0;


            for (int col = 1; col < tab2.Columns.Count - 1; col++)
            {
                for (int row = 0; row < tab2.Rows.Count - 1; row++)
                {
                    if (int.Parse(tab2.Rows[row].Cells[col].Value.ToString()) == min)
                    {
                        p.X = col;
                        p.Y = row;

                        return p;
                    }
                }
            }

            return p;
        }

        public int[] randomList(int m, int n)
        {
            int[] arr = new int[m];
            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();

                arr[rnd.Next(1, n) % m]++;
            }
            return (arr);
        }

        public void whiteBackColor()
        {
            for (int col = 1; col < tab.Columns.Count; col++)
            {
                for (int row = 0; row < tab.Rows.Count; row++)
                {
                    tab.Invoke(new Action(() =>
                    {
                        tab.Rows[row].DefaultCellStyle.BackColor = Color.White;
                        tab.Columns[col].DefaultCellStyle.BackColor = Color.White;
                        tab.Refresh();
                    }));
                }
            }
            for (int col = 1; col < tab2.Columns.Count; col++)
            {
                for (int row = 0; row < tab2.Rows.Count; row++)
                {
                    tab2.Invoke(new Action(() =>
                    {
                        tab2.Rows[row].DefaultCellStyle.BackColor = Color.White;
                        tab2.Columns[col].DefaultCellStyle.BackColor = Color.White;
                        tab2.Refresh();
                    }));
                }
            }
            return;
        }

        #endregion

        #region algorithm

        public void nordOvestalgorithm()
        {

            tab.Invoke(new Action(() =>
            {
                tab.Refresh();
            }));

            int totaleRighe = default;
            int totaleColonne = default;

            int valore_totale = int.Parse(tab.Rows[tab.Rows.Count - 1].Cells[tab.Columns.Count - 1].Value.ToString());

            for (int i = 0; i < tab.Rows.Count - 1; ++i)
            {
                totaleRighe = totaleRighe + int.Parse(tab.Rows[i].Cells[tab.Columns.Count - 1].Value.ToString());
            }

            for (int i = 1; i < tab.Columns.Count - 1; ++i)
            {
                totaleColonne = totaleColonne + int.Parse(tab.Rows[tab.Rows.Count - 1].Cells[i].Value.ToString());
            }

            if (totaleRighe != valore_totale || totaleColonne != valore_totale)
            {
                MessageBox.Show("totale sbagliato");
                return;
            }


            int guadagno = 0;

            log.Invoke(new Action(() =>
            {
                log.AppendText("\n#####################");
                log.AppendText("\nALGORITMO NORD-OVEST");
                log.AppendText("\n#####################");
            }));

            while (tab.Columns.Count > 2 || tab.Rows.Count > 2)
            {
                int primaCasella = int.Parse(tab.Rows[0].Cells[1].Value.ToString());
                int totUp = int.Parse(tab[tab.Columns.Count - 1, 0].Value.ToString());
                int totD = int.Parse(tab.Rows[tab.Rows.Count - 1].Cells[1].Value.ToString());

                // righe
                if (totD > totUp)
                {
                    for (int i = 0; i < tab.Rows.Count; i++)
                    {
                        tab.Invoke(new Action(() =>
                        {
                            tab.Rows[i].Cells[1].Style.BackColor = Color.YellowGreen;
                            tab.Refresh();
                        }));
                    }

                    guadagno = guadagno + (totUp * primaCasella);

                    tab.Invoke(new Action(() =>
                    {
                        int resto = totD - totUp;
                        tab.Rows[tab.Rows.Count - 1].Cells[1].Value = resto;
                        tab.Refresh();
                        System.Threading.Thread.Sleep(900);
                    }));


                    log.Invoke(new Action(() =>
                    {
                        log.AppendText($"\n{tab.Rows[0].Cells[0].Value} => {tab.Columns[1].Name}:  {totUp} * {primaCasella} = {totUp * primaCasella}");
                        log.Refresh();
                    }));

                    System.Threading.Thread.Sleep(900);

                    tab.Invoke(new Action(() =>
                    {
                        tab.Rows.Remove(tab.Rows[0]);
                        tab.Refresh();
                    }));

                    whiteBackColor();
                }

                // colonne
                if (totUp > totD)
                {
                    for (int i = 1; i < tab.Columns.Count; i++)
                    {
                        tab.Invoke(new Action(() =>
                        {
                            tab.Rows[0].Cells[i].Style.BackColor = Color.YellowGreen;
                            tab.Refresh();

                        }));
                    }

                    guadagno = guadagno + (totD * primaCasella);

                    tab.Invoke(new Action(() =>
                    {
                        int resto = totUp - totD;
                        tab[tab.Columns.Count - 1, 0].Value = resto;
                        tab.Refresh();
                        System.Threading.Thread.Sleep(900);
                    }));

                    log.Invoke(new Action(() =>
                    {
                        log.AppendText($"\n{tab.Rows[0].Cells[0].Value} => {tab.Columns[1].Name}:  {totD} * {primaCasella} = {totD * primaCasella}");
                        log.Refresh();
                    }));

                    System.Threading.Thread.Sleep(900);

                    tab.Invoke(new Action(() =>
                    {
                        tab.Columns.Remove(tab.Columns[1]);
                        tab.Refresh();
                    }));

                    whiteBackColor();
                }

                if (totUp == totD)
                {
                    tab.Invoke(new Action(() =>
                    {
                        tab.Rows[0].DefaultCellStyle.BackColor = Color.YellowGreen;
                        tab.Columns[1].DefaultCellStyle.BackColor = Color.YellowGreen;
                        tab.Refresh();
                    }));

                    guadagno = guadagno + (totD * primaCasella);

                    log.Invoke(new Action(() =>
                    {
                        log.AppendText($"\n{tab.Rows[0].Cells[0].Value} => {tab.Columns[1].Name}:  {totD} * {primaCasella} = {totD * primaCasella}");
                        log.Refresh();
                    }));

                    System.Threading.Thread.Sleep(900);

                    tab.Invoke(new Action(() =>
                    {
                        tab.Columns.Remove(tab.Columns[1]);
                        tab.Rows.Remove(tab.Rows[0]);
                        tab.Refresh();
                    }));
                }
                whiteBackColor();
            }

            log.Invoke(new Action(() =>
            {
                log.AppendText($"\n guadagno = {guadagno}");
                log.Refresh();
            }));
        }

        public void minimiCostiAlgorithm()
        {
            tab2.Invoke(new Action(() =>
            {
                tab2.Refresh();
            }));

            int totaleRighe = default;
            int totaleColonne = default;

            int valore_totale = int.Parse(tab2.Rows[tab2.Rows.Count - 1].Cells[tab2.Columns.Count - 1].Value.ToString());

            for (int i = 0; i < tab2.Rows.Count - 1; ++i)
            {
                totaleRighe = totaleRighe + int.Parse(tab2.Rows[i].Cells[tab2.Columns.Count - 1].Value.ToString());
            }

            for (int i = 1; i < tab2.Columns.Count - 1; ++i)
            {
                totaleColonne = totaleColonne + int.Parse(tab2.Rows[tab2.Rows.Count - 1].Cells[i].Value.ToString());
            }
            if (totaleRighe != valore_totale || totaleColonne != valore_totale)
            {
                MessageBox.Show("totale sbagliato");
                return;
            }

            int guadagno = 0;

            log.Invoke(new Action(() =>
            {
                log.AppendText("\n#####################");
                log.AppendText("\nALGORITMO MINIMI COSTI");
                log.AppendText("\n#####################");
            }));

            while (tab2.Columns.Count > 2 || tab2.Rows.Count > 2)
            {
                #region dichiarazioni
                var valoriTabella = new List<int>();

                for (int col = 1; col < tab2.Columns.Count - 1; col++)
                {
                    for (int row = 0; row < tab2.Rows.Count - 1; row++)
                    {
                        valoriTabella.Add(int.Parse(tab2.Rows[row].Cells[col].Value.ToString()));
                    }
                }

                var minimo = valoriTabella.Min();
                var index = searchIndex(minimo);

                int colonna = index.Y;
                int righa = index.X;



                int valoreMinore = int.Parse(tab2[righa, colonna].Value.ToString());
                int totUp = int.Parse(tab2[tab2.Columns.Count - 1, colonna].Value.ToString());
                int totD = int.Parse(tab2[righa, tab2.Rows.Count - 1].Value.ToString());

                #endregion

                if (totD > totUp)
                {
                    for (int i = 1; i < tab2.Columns.Count; i++)
                    {
                        tab2.Invoke(new Action(() =>
                        {
                            tab2.Rows[colonna].Cells[i].Style.BackColor = Color.YellowGreen;
                            tab2.Refresh();
                        }));
                    }


                    guadagno = guadagno + (totUp * valoreMinore);

                    tab2.Invoke(new Action(() =>
                    {
                        int resto = totD - totUp;
                        tab2.Rows[tab2.Rows.Count - 1].Cells[righa].Value = resto;
                        tab2.Refresh();
                        System.Threading.Thread.Sleep(900);
                    }));


                    log.Invoke(new Action(() =>
                    {
                        log.AppendText($"\n{tab2.Rows[colonna].Cells[0].Value} => {tab2.Columns[righa].Name}:  {totUp} * {valoreMinore} = {totUp * valoreMinore}");
                        log.Refresh();
                    }));

                    System.Threading.Thread.Sleep(900);

                    tab2.Invoke(new Action(() =>
                    {
                        tab2.Rows.Remove(tab2.Rows[colonna]);
                        tab2.Refresh();
                    }));

                    for (int col = 1; col < tab2.Columns.Count; col++)
                    {
                        for (int row = 0; row < tab2.Rows.Count; row++)
                        {
                            tab2.Invoke(new Action(() =>
                            {
                                tab2.Rows[row].Cells[col].Style.BackColor = Color.White;
                                tab2.Refresh();
                            }));
                        }
                    }
                }

                if (totUp > totD)
                {
                    for (int i = 0; i < tab2.Rows.Count -1; i++)
                    {
                        tab2.Invoke(new Action(() =>
                        {
                            tab2.Rows[i].Cells[righa].Style.BackColor = Color.YellowGreen;
                            tab2.Refresh();
                        }));
                    
                    }

                    guadagno = guadagno + (totD * valoreMinore);

                    tab2.Invoke(new Action(() =>
                    {
                        int resto = totUp - totD;
                        tab2[tab2.Columns.Count - 1, colonna].Value = resto;
                        tab2.Refresh();
                        System.Threading.Thread.Sleep(900);
                    }));


                    log.Invoke(new Action(() =>
                    {
                        log.AppendText($"\n{tab2.Rows[colonna].Cells[0].Value} => {tab2.Columns[righa].Name}:  {totD} * {valoreMinore} = {totUp * valoreMinore}");
                        log.Refresh();
                    }));

                    System.Threading.Thread.Sleep(900);

                    tab2.Invoke(new Action(() =>
                    {
                        tab2.Columns.Remove(tab2.Columns[righa]);
                        tab2.Refresh();
                    }));

                    for (int col = 1; col < tab2.Columns.Count; col++)
                    {
                        for (int row = 0; row < tab2.Rows.Count; row++)
                        {
                            tab2.Invoke(new Action(() =>
                            {
                                tab2.Rows[row].Cells[col].Style.BackColor = Color.White;
                                tab2.Refresh();
                            }));
                        }
                    }
                }

                if (totUp == totD)
                {
                    for (int col = 0; col < tab2.Columns.Count - 1; col++)
                    {
                        for (int row = 0; row < tab2.Rows.Count; row++)
                        {
                            tab2.Invoke(new Action(() =>
                            {
                                tab2.Rows[colonna].Cells[row].Style.BackColor = Color.YellowGreen;
                                tab2.Rows[col].Cells[righa].Style.BackColor = Color.YellowGreen;
                                tab2.Refresh();
                            }));
                        }
                    }

                    guadagno = guadagno + (totUp * valoreMinore);

                    log.Invoke(new Action(() =>
                    {
                        log.AppendText($"\n{tab2.Rows[colonna].Cells[0].Value} => {tab2.Columns[righa].Name}:  {totUp} * {valoreMinore} = {totUp * valoreMinore}");
                        log.Refresh();
                    }));

                    System.Threading.Thread.Sleep(900);

                    tab2.Invoke(new Action(() =>
                    {
                        tab2.Columns.Remove(tab2.Columns[1]);
                        tab2.Rows.Remove(tab2.Rows[0]);
                        tab2.Refresh();
                    }));

                    whiteBackColor();
                }

                valoriTabella.Clear();
            }

            log.Invoke(new Action(() =>
            {
                log.AppendText($"\n guadagno = {guadagno}");
                log.Refresh();
            }));
        }

        private void btn_NordOvest_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            Task.Run(() => { nordOvestalgorithm(); });
        }

        private void btn_minimiCosti_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            Task.Run(() => { minimiCostiAlgorithm(); });
        }

        #endregion

        private void tab_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            e.Control.KeyPress += new KeyPressEventHandler(lettereInserite);
        }

        private void tab2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(lettereInserite);
        }

        private void lettereInserite(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_clearLog_Click(object sender, EventArgs e)
        {
            log.Clear();
        }

        private void tab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tab2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
