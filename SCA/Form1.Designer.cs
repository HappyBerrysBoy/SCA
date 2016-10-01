namespace SCA
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrImage = new System.Windows.Forms.Timer(this.components);
            this.btnArrange = new System.Windows.Forms.Button();
            this.btnArrange3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnArrange4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(14, 50);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(175, 25);
            this.dtpDate.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(891, 710);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInput.MaxLength = 4;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(86, 25);
            this.txtInput.TabIndex = 1;
            this.txtInput.Visible = false;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(891, 744);
            this.btnInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(87, 26);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "입력";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Visible = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 15;
            this.lstList.Location = new System.Drawing.Point(798, 710);
            this.lstList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstList.Name = "lstList";
            this.lstList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstList.Size = new System.Drawing.Size(90, 439);
            this.lstList.TabIndex = 4;
            this.lstList.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(891, 778);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 26);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(891, 1055);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 26);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = " 저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(891, 1089);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(87, 26);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "불러오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCls
            // 
            this.btnCls.Location = new System.Drawing.Point(891, 846);
            this.btnCls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(87, 26);
            this.btnCls.TabIndex = 2;
            this.btnCls.Text = "CLS";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Visible = false;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(891, 1122);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(87, 26);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "월 정리";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Visible = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(254, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "성찬 프로그램 - Made by SC";
            // 
            // tmrImage
            // 
            this.tmrImage.Enabled = true;
            this.tmrImage.Interval = 3000;
            // 
            // btnArrange
            // 
            this.btnArrange.Location = new System.Drawing.Point(14, 84);
            this.btnArrange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(87, 26);
            this.btnArrange.TabIndex = 2;
            this.btnArrange.Text = "월 정리2";
            this.btnArrange.UseVisualStyleBackColor = true;
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // btnArrange3
            // 
            this.btnArrange3.Location = new System.Drawing.Point(14, 118);
            this.btnArrange3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArrange3.Name = "btnArrange3";
            this.btnArrange3.Size = new System.Drawing.Size(87, 26);
            this.btnArrange3.TabIndex = 2;
            this.btnArrange3.Text = "월 정리3";
            this.btnArrange3.UseVisualStyleBackColor = true;
            this.btnArrange3.Click += new System.EventHandler(this.btnArrange3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnArrange4
            // 
            this.btnArrange4.Location = new System.Drawing.Point(14, 152);
            this.btnArrange4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArrange4.Name = "btnArrange4";
            this.btnArrange4.Size = new System.Drawing.Size(116, 27);
            this.btnArrange4.TabIndex = 2;
            this.btnArrange4.Text = "월 정리4(최신)";
            this.btnArrange4.UseVisualStyleBackColor = true;
            this.btnArrange4.Click += new System.EventHandler(this.btnArrange4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCA.Properties.Resources.여행_해변을_달리다1;
            this.ClientSize = new System.Drawing.Size(840, 759);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.btnArrange4);
            this.Controls.Add(this.btnArrange3);
            this.Controls.Add(this.btnArrange);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.dtpDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "성찬 프로그램 - SC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrImage;
        private System.Windows.Forms.Button btnArrange;
        private System.Windows.Forms.Button btnArrange3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnArrange4;
    }
}

