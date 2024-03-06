
namespace Gravies;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        Form1 f1 = new Form1();
        Button b1 = new Button();
        b1.Text = "Hallo";
        b1.Location = new Point(100, 100);
        f1.Controls.Add(b1);

        b1.Click += DoeIets;
        
        Application.Run(f1);
    }

    static void DoeIets(object? sender, EventArgs e)
    {
        Button? bx = sender as Button;
        bx!.BackColor = Color.Red;
    }
}