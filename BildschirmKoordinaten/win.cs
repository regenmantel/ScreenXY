namespace BildschirmKoordinaten
{
    public partial class win : Form
    {
        public win()
        {
            InitializeComponent();
        }

        private string koordinaten = "koordinatenSave.txt";
        private bool _isFirstKeyPressed = false;

        private int xPosition;
        private int yPosition;
        private string lblX;
        private string lblY; 
        
        private void win_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
            ControlExtension.Draggable(lblKoordinaten, true);

            readText(koordinaten);

            lblKoordinaten.Left = Convert.ToInt32(lblX);
            lblKoordinaten.Top = Convert.ToInt32(lblY);

        }
        private void win_MouseMove(object sender, MouseEventArgs e)
        {
            lblKoordinaten.Text = "X= " + e.X + "; Y= " + e.Y + ";";
        }

        private void win_MouseDown(object sender, MouseEventArgs e)
        {
            this.MouseMove += new MouseEventHandler(win_MouseMove);
            xPosition = e.X;
            yPosition = e.Y;
        }

        private void win_MouseClick(object sender, MouseEventArgs e) { }

        private void win_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.SetText(lblKoordinaten.Text);

            if (e.Control && e.KeyCode == Keys.ControlKey)
            {
                _isFirstKeyPressed = true;
            }
            if(_isFirstKeyPressed)
            {
                if(e.Control && e.KeyCode == Keys.C)
                {
                    notifyIcon1.Icon = SystemIcons.Application;
                    notifyIcon1.Visible = true;
                    notifyIcon1.ShowBalloonTip(999999, "Information", "Koordinaten kopiert", ToolTipIcon.Info);
                    
                }
            }
        }

        private void readText(string txt)
        {
            String line;
            StreamReader sr = new StreamReader(txt);
            line = sr.ReadLine();

            char[] split = new char[] { ';' };
            string[] p = line.Split(split);

            lblX = p[0].Substring(2);
            lblY = p[1].Substring(2);
            
            sr.Close();
        }

        private void writeText(string txt)
        {
            if(!File.Exists(txt))
            {
                File.Create(txt);
                MessageBox.Show("Datei " + txt + " erstellt.");
            }
            else
            {
                StreamWriter sw = new StreamWriter(txt);
                sw.WriteLine("x:" + lblKoordinaten.Left + ";y:" + lblKoordinaten.Top);
                sw.Close();
            }
        }

        private void win_FormClosing(object sender, FormClosingEventArgs e)
        {
            writeText(koordinaten);
        }
    }
} 