namespace WinFormsAppKeyboard.Components
{
    partial class MyButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button = new Button();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(3, 3);
            button.Name = "button";
            button.Size = new Size(64, 64);
            button.TabIndex = 0;
            button.Text = "button";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // MyButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button);
            Name = "MyButton";
            Size = new Size(70, 70);
            ResumeLayout(false);
        }

        #endregion

        private Button button;
    }
}
