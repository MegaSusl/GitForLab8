namespace winformsForPractice2
{
    partial class Form1
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            LayersBox = new System.Windows.Forms.TextBox();
            PickPaint = new System.Windows.Forms.ComboBox();
            heightBox = new System.Windows.Forms.TextBox();
            widthBox = new System.Windows.Forms.TextBox();
            PaintFinal = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            CalcBtn = new System.Windows.Forms.Button();
            paintFinalM = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(LayersBox, 0, 3);
            tableLayoutPanel1.Controls.Add(PickPaint, 0, 2);
            tableLayoutPanel1.Controls.Add(heightBox, 0, 1);
            tableLayoutPanel1.Controls.Add(widthBox, 0, 0);
            tableLayoutPanel1.Controls.Add(PaintFinal, 0, 5);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 3);
            tableLayoutPanel1.Controls.Add(CalcBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(paintFinalM, 0, 6);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(14);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1045, 650);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LayersBox
            // 
            LayersBox.Dock = System.Windows.Forms.DockStyle.Fill;
            LayersBox.Location = new System.Drawing.Point(17, 281);
            LayersBox.Name = "LayersBox";
            LayersBox.Size = new System.Drawing.Size(858, 31);
            LayersBox.TabIndex = 3;
            // 
            // PickPaint
            // 
            PickPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            PickPaint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            PickPaint.FormattingEnabled = true;
            PickPaint.Location = new System.Drawing.Point(17, 193);
            PickPaint.Name = "PickPaint";
            PickPaint.Size = new System.Drawing.Size(858, 33);
            PickPaint.TabIndex = 0;
            PickPaint.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // heightBox
            // 
            heightBox.Dock = System.Windows.Forms.DockStyle.Fill;
            heightBox.Location = new System.Drawing.Point(17, 105);
            heightBox.Name = "heightBox";
            heightBox.Size = new System.Drawing.Size(858, 31);
            heightBox.TabIndex = 2;
            // 
            // widthBox
            // 
            widthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            widthBox.Location = new System.Drawing.Point(17, 17);
            widthBox.Name = "widthBox";
            widthBox.Size = new System.Drawing.Size(858, 31);
            widthBox.TabIndex = 1;
            // 
            // PaintFinal
            // 
            PaintFinal.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(PaintFinal, 2);
            PaintFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            PaintFinal.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            PaintFinal.Location = new System.Drawing.Point(17, 454);
            PaintFinal.Name = "PaintFinal";
            PaintFinal.Size = new System.Drawing.Size(1011, 88);
            PaintFinal.TabIndex = 4;
            PaintFinal.Text = "--- (л)";
            PaintFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(881, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 25);
            label1.TabIndex = 5;
            label1.Text = "Ширина (м)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(881, 102);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 25);
            label2.TabIndex = 6;
            label2.Text = "Высота (м)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(881, 190);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 25);
            label3.TabIndex = 7;
            label3.Text = "Тип краски";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(881, 278);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(122, 25);
            label4.TabIndex = 8;
            label4.Text = "Кол-во слоёв";
            // 
            // CalcBtn
            // 
            tableLayoutPanel1.SetColumnSpan(CalcBtn, 2);
            CalcBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            CalcBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            CalcBtn.Location = new System.Drawing.Point(17, 369);
            CalcBtn.Name = "CalcBtn";
            CalcBtn.Size = new System.Drawing.Size(1011, 82);
            CalcBtn.TabIndex = 0;
            CalcBtn.Text = "Рассчитать расход";
            CalcBtn.UseVisualStyleBackColor = true;
            CalcBtn.Click += CalcBtn_Click;
            // 
            // paintFinalM
            // 
            paintFinalM.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(paintFinalM, 2);
            paintFinalM.Dock = System.Windows.Forms.DockStyle.Fill;
            paintFinalM.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            paintFinalM.Location = new System.Drawing.Point(17, 542);
            paintFinalM.Name = "paintFinalM";
            paintFinalM.Size = new System.Drawing.Size(1011, 94);
            paintFinalM.TabIndex = 9;
            paintFinalM.Text = "--- (л/м2)";
            paintFinalM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1045, 650);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox PickPaint;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label PaintFinal;
        private System.Windows.Forms.TextBox LayersBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label paintFinalM;
    }
}

