namespace AccpuntapplicationDmoApp
{
    partial class AccountForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtBalance = new TextBox();
            btnCreate = new Button();
            btnSet = new Button();
            btnGet = new Button();
            btnDestroy = new Button();
            btnClear = new Button();
            btnGc = new Button();
            btnTemp = new Button();
            btnGetGeneration = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 19);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 19);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Balance";
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 51);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(147, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(283, 51);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(100, 23);
            txtBalance.TabIndex = 5;
            txtBalance.TextChanged += txtBalance_TextChanged;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 91);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 23);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(147, 91);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(100, 23);
            btnSet.TabIndex = 7;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(283, 91);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(100, 23);
            btnGet.TabIndex = 8;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnDestroy
            // 
            btnDestroy.Location = new Point(147, 120);
            btnDestroy.Name = "btnDestroy";
            btnDestroy.Size = new Size(100, 23);
            btnDestroy.TabIndex = 10;
            btnDestroy.Text = "Destroy";
            btnDestroy.UseVisualStyleBackColor = true;
            btnDestroy.Click += btnDestroy_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 120);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnGc
            // 
            btnGc.Location = new Point(283, 120);
            btnGc.Name = "btnGc";
            btnGc.Size = new Size(100, 23);
            btnGc.TabIndex = 11;
            btnGc.Text = "GC";
            btnGc.UseVisualStyleBackColor = true;
            btnGc.Click += btnGc_Click;
            // 
            // btnTemp
            // 
            btnTemp.Location = new Point(12, 155);
            btnTemp.Name = "btnTemp";
            btnTemp.Size = new Size(100, 23);
            btnTemp.TabIndex = 12;
            btnTemp.Text = "Temp";
            btnTemp.UseVisualStyleBackColor = true;
            btnTemp.Click += btnTemp_Click;
            // 
            // btnGetGeneration
            // 
            btnGetGeneration.Location = new Point(145, 155);
            btnGetGeneration.Name = "btnGetGeneration";
            btnGetGeneration.Size = new Size(236, 23);
            btnGetGeneration.TabIndex = 13;
            btnGetGeneration.Text = "Get Generation";
            btnGetGeneration.UseVisualStyleBackColor = true;
            btnGetGeneration.Click += btnGetGeneration_Click;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 194);
            Controls.Add(btnGetGeneration);
            Controls.Add(btnTemp);
            Controls.Add(btnGc);
            Controls.Add(btnClear);
            Controls.Add(btnDestroy);
            Controls.Add(btnGet);
            Controls.Add(btnSet);
            Controls.Add(btnCreate);
            Controls.Add(txtBalance);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "AccountForm";
            Text = "Account Form";
            Load += AccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtBalance;
        private Button btnCreate;
        private Button btnSet;
        private Button btnGet;
        private Button btnDestroy;
        private Button btnClear;
        private Button btnGc;
        private Button btnTemp;
        private Button btnGetGeneration;
    }
}