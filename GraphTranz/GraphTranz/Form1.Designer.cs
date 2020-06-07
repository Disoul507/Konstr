namespace GraphTranz
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.createClosure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transitClosure = new System.Windows.Forms.RichTextBox();
            this.matrixGraph = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // createClosure
            // 
            this.createClosure.Location = new System.Drawing.Point(323, 338);
            this.createClosure.Name = "createClosure";
            this.createClosure.Size = new System.Drawing.Size(143, 50);
            this.createClosure.TabIndex = 0;
            this.createClosure.Text = "Создать транзитивное замыкание";
            this.createClosure.UseVisualStyleBackColor = true;
            this.createClosure.Click += new System.EventHandler(this.createClosure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Транзитивное замыкание графа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Матрица смежности графа";
            // 
            // transitClosure
            // 
            this.transitClosure.Location = new System.Drawing.Point(545, 133);
            this.transitClosure.Name = "transitClosure";
            this.transitClosure.Size = new System.Drawing.Size(170, 163);
            this.transitClosure.TabIndex = 3;
            this.transitClosure.Text = "";
            // 
            // matrixGraph
            // 
            this.matrixGraph.Location = new System.Drawing.Point(54, 133);
            this.matrixGraph.Name = "matrixGraph";
            this.matrixGraph.Size = new System.Drawing.Size(179, 163);
            this.matrixGraph.TabIndex = 4;
            this.matrixGraph.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.matrixGraph);
            this.Controls.Add(this.transitClosure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createClosure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createClosure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox transitClosure;
        private System.Windows.Forms.RichTextBox matrixGraph;
    }
}

