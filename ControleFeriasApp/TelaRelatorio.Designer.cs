using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleFeriasApp
{
    partial class TelaRelatorio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRelatorioFerias = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimeInicioRelatorio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFimRelatorio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorioFerias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewRelatorioFerias);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(733, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 444);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionários em férias no período";
            // 
            // dataGridViewRelatorioFerias
            // 
            this.dataGridViewRelatorioFerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatorioFerias.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewRelatorioFerias.Name = "dataGridViewRelatorioFerias";
            this.dataGridViewRelatorioFerias.Size = new System.Drawing.Size(491, 419);
            this.dataGridViewRelatorioFerias.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 4);
            this.monthCalendar1.Location = new System.Drawing.Point(31, 45);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // dateTimeInicioRelatorio
            // 
            this.dateTimeInicioRelatorio.CustomFormat = "dd/MM/yyyy";
            this.dateTimeInicioRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeInicioRelatorio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeInicioRelatorio.Location = new System.Drawing.Point(117, 15);
            this.dateTimeInicioRelatorio.Name = "dateTimeInicioRelatorio";
            this.dateTimeInicioRelatorio.Size = new System.Drawing.Size(119, 24);
            this.dateTimeInicioRelatorio.TabIndex = 2;
            this.dateTimeInicioRelatorio.ValueChanged += new System.EventHandler(this.dateTimeInicioRelatorio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Fm:";
            // 
            // dateTimeFimRelatorio
            // 
            this.dateTimeFimRelatorio.CustomFormat = "dd/MM/yyyy";
            this.dateTimeFimRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFimRelatorio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFimRelatorio.Location = new System.Drawing.Point(325, 15);
            this.dateTimeFimRelatorio.Name = "dateTimeFimRelatorio";
            this.dateTimeFimRelatorio.Size = new System.Drawing.Size(117, 24);
            this.dateTimeFimRelatorio.TabIndex = 4;
            this.dateTimeFimRelatorio.ValueChanged += new System.EventHandler(this.dateTimeFimRelatorio_ValueChanged);
            // 
            // TelaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeFimRelatorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeInicioRelatorio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "TelaRelatorio";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorioFerias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewRelatorioFerias;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimeInicioRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeFimRelatorio;
    }
}