using System.Windows.Forms;
using System.Drawing;

Form form = new Form();

form.Text = "HuseynNuran";
form.Size = new Size(925, 259);

//EventHandler (delegate)
//EventArgs (class)

// With Lambda
/*form.MouseClick += (s, e) =>
{
	Console.WriteLine($"{e.Location}");
};*/

form.MouseClick += Form_MouseClick;

void Form_MouseClick(object? sender, MouseEventArgs e)
{
	Console.WriteLine($"{e.Location}");
	MessageBox.Show(e.Location.ToString());
}

Button button1 = new Button
{
	Text = "Btn 1",
	Size = new Size(50, 50),
	Location = new Point(100, 150),
	BackColor = Color.RebeccaPurple
};

Button button2 = new Button
{
	Text = "Btn 2",
	Size = new Size(80, 20),
	Location = new Point(60, 100),
	BackColor = Color.SeaGreen
};

button1.Click += Button_Click;
button2.Click += Button_Click;

void Button_Click(object? sender, EventArgs e)
{
	Console.WriteLine("MyselfWolfcum");
}

button1.Click += Button_Click_DescriptionSender;
button2.Click += Button_Click_DescriptionSender;

//description of sender
void Button_Click_DescriptionSender(object? sender, EventArgs e)
{
	Console.WriteLine((sender as Button).Text);
}

form.Controls.Add(button1);
form.Controls.Add(button2);

//form.Show(); // modal window
form.ShowDialog();

//Application.Run(new Form());