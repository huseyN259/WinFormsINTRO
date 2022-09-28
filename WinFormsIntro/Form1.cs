using Timer = System.Windows.Forms.Timer;

namespace WinFormsIntro;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();

		Timer timer = new Timer();

		timer.Interval = 1000;
		timer.Tick += TimerTick;
		timer.Start();
	}

	private void TimerTick(object sender, EventArgs e)
	{
		label1.Text = DateTime.Now.ToString();
	}

	private void hsyn_nrn_Click(object sender, EventArgs e)
	{
		//MessageBox.Show("NH");
		DialogResult result = MessageBox.Show("Clicked", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

		if (result == DialogResult.Yes)
			hsyn_nrn.Text = "Yes";
		else if (result == DialogResult.No)
			hsyn_nrn.Text = "No";
	}

	private void hsyn_nrn_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
			this.BackColor = Color.SteelBlue;
		else if (e.Button == MouseButtons.Right)
			this.BackColor = Color.DarkRed;
		else
			//this.BackColor = Color.YellowGreen;
			BackColor = Color.FromArgb(5, 130, 14);
	}

	private void hsyn_nrn_MouseMove(object sender, MouseEventArgs e)
	{
		//Text = $"X : {e.X} Y : {e.Y}";
		Text = e.Location.ToString();
	}

	private void hsyn_nrn_MouseEnter(object sender, EventArgs e)
	{
		hsyn_nrn.BackColor = Color.Purple;
	}

	private void hsyn_nrn_MouseLeave(object sender, EventArgs e)
	{
		hsyn_nrn.BackColor = Color.Green;
	}

	private bool _state = false;
	private void button1_Click(object sender, EventArgs e)
	{
		/*if (_state)
			button1.BackColor = Color.Red;
		else
			button1.BackColor = Color.Blue;*/

		//button1.BackColor = _state ? Color.Red : Color.Green;

		button1.BackColor = _state switch
		{
			true => Color.Red,
			false => Color.Blue
		};

		_state = !_state;
	}

	private void radioButton1_Click(object sender, EventArgs e)
	{
		MessageBox.Show("i found my pillow");
	}

	private void button2_Click(object sender, EventArgs e)
	{
		int x = Random.Shared.Next(170, 500);
		int y = Random.Shared.Next(100, 300);

		Label label = new Label
		{
			BackColor = Color.Aquamarine,
			Location = new Point(x, y),
			Size = new Size(50, 30),
			Text = "NEW"
		};

		label.Click += (s, e) => (s as Label)?.Dispose();

		Controls.Add(label);
	}
}