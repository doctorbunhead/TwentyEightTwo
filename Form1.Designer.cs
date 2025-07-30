namespace TwentyEightTwo;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        lblTime = new Label();
        lblState = new Label();
        btnSkip = new Button();
        SuspendLayout();
        // 
        // lblTime
        // 
        lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTime.AutoSize = true;
        lblTime.Location = new Point(197, 134);
        lblTime.Name = "lblTime";
        lblTime.Size = new Size(194, 25);
        lblTime.TabIndex = 0;
        lblTime.Text = "Time Remaining=00:00";
        // 
        // lblState
        // 
        lblState.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblState.AutoSize = true;
        lblState.Location = new Point(235, 70);
        lblState.Name = "lblState";
        lblState.Size = new Size(119, 25);
        lblState.TabIndex = 1;
        lblState.Text = "State - Sitting";
        // 
        // btnSkip
        // 
        btnSkip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        btnSkip.Location = new Point(235, 188);
        btnSkip.Name = "btnSkip";
        btnSkip.Size = new Size(112, 34);
        btnSkip.TabIndex = 2;
        btnSkip.Text = "Skip";
        btnSkip.UseVisualStyleBackColor = true;
        btnSkip.Click += btnSkip_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(588, 234);
        Controls.Add(btnSkip);
        Controls.Add(lblState);
        Controls.Add(lblTime);
        DoubleBuffered = true;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(610, 290);
        MinimumSize = new Size(610, 290);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Twenty Eight Two Reminder";
        ResizeEnd += Form1_ResizeEnd;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTime;
    private Label lblState;
    private Button btnSkip;
}
