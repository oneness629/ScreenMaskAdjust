namespace ScreenMask
{
    partial class Setting
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.windowsListComboBox = new System.Windows.Forms.ComboBox();
            this.transparentValueComboBox = new System.Windows.Forms.ComboBox();
            this.successButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.settingGroupBox = new System.Windows.Forms.GroupBox();
            this.settingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowsListComboBox
            // 
            this.windowsListComboBox.FormattingEnabled = true;
            this.windowsListComboBox.Location = new System.Drawing.Point(6, 20);
            this.windowsListComboBox.Name = "windowsListComboBox";
            this.windowsListComboBox.Size = new System.Drawing.Size(248, 20);
            this.windowsListComboBox.TabIndex = 0;
            this.windowsListComboBox.Text = "窗口列表";
            // 
            // transparentValueComboBox
            // 
            this.transparentValueComboBox.FormattingEnabled = true;
            this.transparentValueComboBox.Location = new System.Drawing.Point(6, 46);
            this.transparentValueComboBox.Name = "transparentValueComboBox";
            this.transparentValueComboBox.Size = new System.Drawing.Size(248, 20);
            this.transparentValueComboBox.TabIndex = 3;
            this.transparentValueComboBox.Text = "透明度选择";
            // 
            // successButton
            // 
            this.successButton.Location = new System.Drawing.Point(6, 72);
            this.successButton.Name = "successButton";
            this.successButton.Size = new System.Drawing.Size(123, 23);
            this.successButton.TabIndex = 4;
            this.successButton.Text = "确定";
            this.successButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(131, 72);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(123, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // settingGroupBox
            // 
            this.settingGroupBox.Controls.Add(this.successButton);
            this.settingGroupBox.Controls.Add(this.exitButton);
            this.settingGroupBox.Controls.Add(this.windowsListComboBox);
            this.settingGroupBox.Controls.Add(this.transparentValueComboBox);
            this.settingGroupBox.ForeColor = System.Drawing.Color.White;
            this.settingGroupBox.Location = new System.Drawing.Point(12, 5);
            this.settingGroupBox.Name = "settingGroupBox";
            this.settingGroupBox.Size = new System.Drawing.Size(260, 111);
            this.settingGroupBox.TabIndex = 6;
            this.settingGroupBox.TabStop = false;
            this.settingGroupBox.Text = "设置项目";
            // 
            // Setting
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.settingGroupBox);
            this.Name = "Setting";
            this.Text = "ScreenMask Setting";
            this.TopMost = true;
            this.settingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox windowsListComboBox;
        private System.Windows.Forms.ComboBox transparentValueComboBox;
        private System.Windows.Forms.Button successButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox settingGroupBox;
    }
}