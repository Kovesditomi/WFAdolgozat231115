namespace wfadoga
{
    public partial class Form1 : Form
    {
        static Button[] operatorko;
        public Form1()
        {
            InitializeComponent();
            btnWelcome.Click += BtnWelcome_Click;
            lblRed.Click += ColorChanger;
            lblGreen.Click += ColorChanger;
            lblBlue.Click += ColorChanger;
            operatorko = new Button[] { btnosszead, btnkivon, btnoszt, btnszorz };
            btnosszead.Click += btnosszead_Click;
            btnkivon.Click += btnosszead_Click;
            btnszorz.Click += btnszorz_Click;
            btnoszt.Click += btnszorz_Click;

            btnexit.Click += btnexit_Click; 
            btndefault.Click += btndefault_Click;

        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
                
                }
        private void btndefault_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void BtnWelcome_Click(object? sender, EventArgs e)
        {
            if (txtname.Text.Length != 0) lblwelcome.Text = $"Szia! {txtname.Text}!";
            else MessageBox.Show("Nemjo a mezõ!!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void ColorChanger(object? sender, EventArgs e)
        {
            if ((sender as Label).BackColor == Color.Red) this.BackColor = Color.Red;
            if ((sender as Label).BackColor == Color.Green) this.BackColor = Color.Green;
            if ((sender as Label).BackColor == Color.Blue) this.BackColor = Color.Blue;
        }
        private void btnszorz_Click(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Yellow;

            ChangeOthersToDef(sender as Button);

        }
        private void btnoszt_Click(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Yellow;

            ChangeOthersToDef(sender as Button);

        }
        private void btnosszead_Click(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Yellow;

            ChangeOthersToDef(sender as Button);

        }
        private void btnkivon_Click(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Yellow;

            ChangeOthersToDef(sender as Button);

        }


        private void ChangeOthersToDef(Button exception)
        {

            for (int i = 0; i < operatorko.Length; i++) if (operatorko[i] != exception) operatorko[i].BackColor = DefaultBackColor;
            {

            }
            {

            }

        }

    }
}