using System.Timers;
using Timer = System.Timers.Timer;

namespace TwentyEightTwo;

public partial class Form1 : Form
{
    private Timer timer;
    private Timer timerDisplay;
    private DateTime datetimeEnd = DateTime.Now;

    public Form1()
    {
        InitializeComponent();
        timer = new Timer
        {
            AutoReset = false,
            Interval = (20 * 60000) + 10000
        };
        this.Shown += form_shown;
        timer.Elapsed += timer_elapsed;

        timerDisplay = new Timer
        {
            AutoReset = true,
            Interval = 500
        };
        timerDisplay.Elapsed += (o, e) =>
        {
            var time = TimeSpan.FromMilliseconds(datetimeEnd.TimeOfDay.TotalMilliseconds - DateTime.Now.TimeOfDay.TotalMilliseconds);
            BeginInvoke((MethodInvoker)delegate () { lblTime.Text = $"Time Remaining={time.ToString("mm\\:ss")}"; lblTime.Left = (ClientSize.Width - lblTime.Width) / 2; });
        };
    }

    private void form_shown(Object sender, EventArgs e)
    {
        datetimeEnd = DateTime.Now.AddMilliseconds(timer.Interval);
        timer.Start();
        timerDisplay.Start();
    }

    private void timer_elapsed(object sender, ElapsedEventArgs e)
    {
        BeginInvoke((MethodInvoker)delegate ()
        {
            if (WindowState == FormWindowState.Minimized) WindowState = FormWindowState.Normal;
            this.TopMost = true;
            this.CenterToScreen();
        });
        var message = "";
        switch (timer.Interval)
        {
            case (20 * 60000)+10000:
                timer.Interval = (8 * 60000) + 10000;
                message = "Standing Up";
                break;

            case (8 * 60000)+10000:
                timer.Interval = (2 * 60000) + 10000;
                message = "Moving Around";
                break;

            case (2 * 60000) + 10000:
                timer.Interval = (20 * 60000) + 10000;
                message = "Sitting";
                break;
        }
        datetimeEnd = DateTime.Now.AddMilliseconds(timer.Interval);
        timer.Start();
        BeginInvoke((MethodInvoker)delegate ()
        {
            TopMost = false; lblState.Text = $"State - {message}";
            lblState.Left = (ClientSize.Width - lblState.Width) / 2;
        });
        Console.Beep(500, 200);
        Thread.Sleep(200);
        Console.Beep(500, 200);
        Thread.Sleep(200);
        Console.Beep(500, 200);
    }

    private void Form1_ResizeEnd(object sender, EventArgs e)
    {
        Refresh();
    }

    private void btnSkip_Click(object sender, EventArgs e)
    {
        timer.Stop();
        timer_elapsed(null, null);
    }
}