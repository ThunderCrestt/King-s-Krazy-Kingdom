using System;
using System.Windows.Forms;
using System.Drawing;

public class VirtualInterface : Form
{
    private Label message;
    private Button fermer;

	public VirtualInterface()
	{
        SuspendLayout();
        Text = "King's Krazy Kingdom";
        Size = new Size(200, 150);
        MinimumSize = new Size(200, 150);

        message = new Label();
        message.Text = "Plus ou moins ?";
        message.AutoSize = true;
        message.Location = new Point(10, 100);

        fermer = new Button();
        fermer.Text = "Fin du jeu";
        message.Autosize = true;
        fermer.Location = new Point(150, 10);
        fermer.Click += new System.EventHandler(fermer_Click);

        Controls.Add(message);
        Controls.Add(fermer);

        ResumeLayout(false);
        PerformLayout();
            }

    private void fermer_click(object sender, EventArgs evt)
    {
        Application.Exit();
    }

    static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.Run(new VirtualInterface());

    }
}
