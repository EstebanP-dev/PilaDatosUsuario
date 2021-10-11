
namespace PilaDatosUsuario
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblValidate = new System.Windows.Forms.Label();
            this.tbArray = new System.Windows.Forms.TextBox();
            this.lblArray = new System.Windows.Forms.Label();
            this.tbTop = new System.Windows.Forms.TextBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.tbArray2 = new System.Windows.Forms.TextBox();
            this.lblArray2 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tbNeatArray = new System.Windows.Forms.TextBox();
            this.lblNeatArray = new System.Windows.Forms.Label();
            this.btnNeatArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(70, 112);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(58, 17);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Entrada";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(70, 227);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(47, 17);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Salida";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(70, 304);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(64, 17);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Cantidad";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(134, 112);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(230, 22);
            this.tbInput.TabIndex = 3;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(134, 227);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(230, 22);
            this.tbOutput.TabIndex = 4;
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(134, 304);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(88, 22);
            this.tbCount.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 391);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(117, 47);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Crear Pila";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(157, 391);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(117, 47);
            this.btnPush.TabIndex = 7;
            this.btnPush.Text = "Apilar Registro";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(301, 391);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(117, 47);
            this.btnPop.TabIndex = 8;
            this.btnPop.Text = "Desapilar Registro";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(446, 391);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(117, 47);
            this.btnCount.TabIndex = 9;
            this.btnCount.Text = "Cantidad";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(579, 391);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(117, 47);
            this.btnTop.TabIndex = 10;
            this.btnTop.Text = "Cima";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(714, 391);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 47);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Vaciar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.Location = new System.Drawing.Point(84, 32);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(0, 17);
            this.lblValidate.TabIndex = 12;
            // 
            // tbArray
            // 
            this.tbArray.Location = new System.Drawing.Point(134, 151);
            this.tbArray.Name = "tbArray";
            this.tbArray.Size = new System.Drawing.Size(230, 22);
            this.tbArray.TabIndex = 14;
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(70, 151);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(43, 17);
            this.lblArray.TabIndex = 13;
            this.lblArray.Text = "Pila 1";
            // 
            // tbTop
            // 
            this.tbTop.Location = new System.Drawing.Point(134, 267);
            this.tbTop.Name = "tbTop";
            this.tbTop.Size = new System.Drawing.Size(88, 22);
            this.tbTop.TabIndex = 16;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(70, 267);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(39, 17);
            this.lblTop.TabIndex = 15;
            this.lblTop.Text = "Cima";
            // 
            // tbArray2
            // 
            this.tbArray2.Location = new System.Drawing.Point(524, 112);
            this.tbArray2.Name = "tbArray2";
            this.tbArray2.Size = new System.Drawing.Size(230, 22);
            this.tbArray2.TabIndex = 18;
            // 
            // lblArray2
            // 
            this.lblArray2.AutoSize = true;
            this.lblArray2.Location = new System.Drawing.Point(460, 112);
            this.lblArray2.Name = "lblArray2";
            this.lblArray2.Size = new System.Drawing.Size(43, 17);
            this.lblArray2.TabIndex = 17;
            this.lblArray2.Text = "Pila 2";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(157, 468);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(117, 47);
            this.btnCopy.TabIndex = 19;
            this.btnCopy.Text = "Copiar Pila";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tbNeatArray
            // 
            this.tbNeatArray.Location = new System.Drawing.Point(134, 187);
            this.tbNeatArray.Name = "tbNeatArray";
            this.tbNeatArray.Size = new System.Drawing.Size(230, 22);
            this.tbNeatArray.TabIndex = 21;
            // 
            // lblNeatArray
            // 
            this.lblNeatArray.AutoSize = true;
            this.lblNeatArray.Location = new System.Drawing.Point(6, 187);
            this.lblNeatArray.Name = "lblNeatArray";
            this.lblNeatArray.Size = new System.Drawing.Size(111, 17);
            this.lblNeatArray.TabIndex = 20;
            this.lblNeatArray.Text = "Pila 1 Ordenada";
            // 
            // btnNeatArray
            // 
            this.btnNeatArray.Location = new System.Drawing.Point(12, 468);
            this.btnNeatArray.Name = "btnNeatArray";
            this.btnNeatArray.Size = new System.Drawing.Size(117, 47);
            this.btnNeatArray.TabIndex = 22;
            this.btnNeatArray.Text = "Ordenar Pila 1";
            this.btnNeatArray.UseVisualStyleBackColor = true;
            this.btnNeatArray.Click += new System.EventHandler(this.btnNeatArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 527);
            this.Controls.Add(this.btnNeatArray);
            this.Controls.Add(this.tbNeatArray);
            this.Controls.Add(this.lblNeatArray);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tbArray2);
            this.Controls.Add(this.lblArray2);
            this.Controls.Add(this.tbTop);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.tbArray);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.lblValidate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.TextBox tbArray;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.TextBox tbTop;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.TextBox tbArray2;
        private System.Windows.Forms.Label lblArray2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox tbNeatArray;
        private System.Windows.Forms.Label lblNeatArray;
        private System.Windows.Forms.Button btnNeatArray;
    }
}

