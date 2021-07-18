
namespace VatsimATCHelper
{
    partial class FirstInfo
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
            this.welcome = new System.Windows.Forms.Label();
            this.typeYourInfo = new System.Windows.Forms.Label();
            this.CallSignTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepartureTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ArrivalTB = new System.Windows.Forms.TextBox();
            this.DepICAOTB = new System.Windows.Forms.TextBox();
            this.ArrICAOTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.doNotUse = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(140, 10);
            this.welcome.Margin = new System.Windows.Forms.Padding(0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(265, 30);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Vatsim ATC Helper";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeYourInfo
            // 
            this.typeYourInfo.AutoSize = true;
            this.typeYourInfo.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.typeYourInfo.Location = new System.Drawing.Point(205, 53);
            this.typeYourInfo.Name = "typeYourInfo";
            this.typeYourInfo.Size = new System.Drawing.Size(139, 15);
            this.typeYourInfo.TabIndex = 1;
            this.typeYourInfo.Text = "비행 정보를 입력하세요.";
            // 
            // CallSignTB
            // 
            this.CallSignTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CallSignTB.Location = new System.Drawing.Point(107, 104);
            this.CallSignTB.Name = "CallSignTB";
            this.CallSignTB.Size = new System.Drawing.Size(140, 21);
            this.CallSignTB.TabIndex = 2;
            this.CallSignTB.Enter += new System.EventHandler(this.CallSignTB_Enter);
            this.CallSignTB.Leave += new System.EventHandler(this.CallSignTB_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(45, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Call Sign";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(42, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Departure";
            // 
            // DepartureTB
            // 
            this.DepartureTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DepartureTB.Location = new System.Drawing.Point(107, 131);
            this.DepartureTB.Name = "DepartureTB";
            this.DepartureTB.Size = new System.Drawing.Size(200, 21);
            this.DepartureTB.TabIndex = 3;
            this.DepartureTB.Enter += new System.EventHandler(this.DepartureTB_Enter);
            this.DepartureTB.Leave += new System.EventHandler(this.DepartureTB_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(61, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Arrival";
            // 
            // ArrivalTB
            // 
            this.ArrivalTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ArrivalTB.Location = new System.Drawing.Point(107, 158);
            this.ArrivalTB.Name = "ArrivalTB";
            this.ArrivalTB.Size = new System.Drawing.Size(200, 21);
            this.ArrivalTB.TabIndex = 5;
            this.ArrivalTB.Enter += new System.EventHandler(this.ArrivalTB_Enter);
            this.ArrivalTB.Leave += new System.EventHandler(this.ArrivalTB_Leave);
            // 
            // DepICAOTB
            // 
            this.DepICAOTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DepICAOTB.Location = new System.Drawing.Point(363, 131);
            this.DepICAOTB.Name = "DepICAOTB";
            this.DepICAOTB.Size = new System.Drawing.Size(144, 21);
            this.DepICAOTB.TabIndex = 4;
            this.DepICAOTB.Enter += new System.EventHandler(this.DepICAOTB_Enter);
            this.DepICAOTB.Leave += new System.EventHandler(this.DepICAOTB_Leave);
            // 
            // ArrICAOTB
            // 
            this.ArrICAOTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ArrICAOTB.Location = new System.Drawing.Point(363, 158);
            this.ArrICAOTB.Name = "ArrICAOTB";
            this.ArrICAOTB.Size = new System.Drawing.Size(144, 21);
            this.ArrICAOTB.TabIndex = 6;
            this.ArrICAOTB.Enter += new System.EventHandler(this.ArrICAOTB_Enter);
            this.ArrICAOTB.Leave += new System.EventHandler(this.ArrICAOTB_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(313, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "- ICAO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(313, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "- ICAO";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startButton.Location = new System.Drawing.Point(206, 204);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(136, 36);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "시작하기";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // doNotUse
            // 
            this.doNotUse.AutoSize = true;
            this.doNotUse.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doNotUse.Location = new System.Drawing.Point(77, 287);
            this.doNotUse.Name = "doNotUse";
            this.doNotUse.Size = new System.Drawing.Size(395, 15);
            this.doNotUse.TabIndex = 13;
            this.doNotUse.Text = "본 프로그램은 가상관제 전용입니다. 절대 실제 비행에 사용하지 마세요.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(178, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "제작자 Discord : AstroJonny#0880";
            // 
            // FirstInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.doNotUse);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ArrICAOTB);
            this.Controls.Add(this.DepICAOTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArrivalTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepartureTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CallSignTB);
            this.Controls.Add(this.typeYourInfo);
            this.Controls.Add(this.welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FirstInfo";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label typeYourInfo;
        private System.Windows.Forms.TextBox CallSignTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DepartureTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ArrivalTB;
        private System.Windows.Forms.TextBox DepICAOTB;
        private System.Windows.Forms.TextBox ArrICAOTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label doNotUse;
        private System.Windows.Forms.Label label6;
    }
}