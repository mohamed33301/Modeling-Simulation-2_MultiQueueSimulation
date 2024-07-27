namespace MultiQueueSimulation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.number_of_servers_txt = new System.Windows.Forms.TextBox();
            this.stopping_number_txt = new System.Windows.Forms.TextBox();
            this.stopping_criteria_cmb = new System.Windows.Forms.ComboBox();
            this.selection_method_cmb = new System.Windows.Forms.ComboBox();
            this.interarrival_dits_grid_view = new System.Windows.Forms.DataGridView();
            this.interarrivaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.server_dits_grid_view = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generate_sim_table_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.interarrival_dits_grid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.server_dits_grid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Servers :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stopping Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selection Method :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stopping Criteria :";
            // 
            // number_of_servers_txt
            // 
            this.number_of_servers_txt.Location = new System.Drawing.Point(181, 9);
            this.number_of_servers_txt.Name = "number_of_servers_txt";
            this.number_of_servers_txt.Size = new System.Drawing.Size(100, 20);
            this.number_of_servers_txt.TabIndex = 4;
            // 
            // stopping_number_txt
            // 
            this.stopping_number_txt.Location = new System.Drawing.Point(181, 39);
            this.stopping_number_txt.Name = "stopping_number_txt";
            this.stopping_number_txt.Size = new System.Drawing.Size(100, 20);
            this.stopping_number_txt.TabIndex = 5;
            // 
            // stopping_criteria_cmb
            // 
            this.stopping_criteria_cmb.FormattingEnabled = true;
            this.stopping_criteria_cmb.Location = new System.Drawing.Point(181, 75);
            this.stopping_criteria_cmb.Name = "stopping_criteria_cmb";
            this.stopping_criteria_cmb.Size = new System.Drawing.Size(121, 21);
            this.stopping_criteria_cmb.TabIndex = 6;
            // 
            // selection_method_cmb
            // 
            this.selection_method_cmb.FormattingEnabled = true;
            this.selection_method_cmb.Location = new System.Drawing.Point(181, 105);
            this.selection_method_cmb.Name = "selection_method_cmb";
            this.selection_method_cmb.Size = new System.Drawing.Size(121, 21);
            this.selection_method_cmb.TabIndex = 7;
            // 
            // interarrival_dits_grid_view
            // 
            this.interarrival_dits_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interarrival_dits_grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.interarrivaltime,
            this.probabilty});
            this.interarrival_dits_grid_view.Location = new System.Drawing.Point(357, 39);
            this.interarrival_dits_grid_view.Name = "interarrival_dits_grid_view";
            this.interarrival_dits_grid_view.Size = new System.Drawing.Size(243, 150);
            this.interarrival_dits_grid_view.TabIndex = 8;
            // 
            // interarrivaltime
            // 
            this.interarrivaltime.HeaderText = "Interarrival Time";
            this.interarrivaltime.Name = "interarrivaltime";
            // 
            // probabilty
            // 
            this.probabilty.HeaderText = "Probabiltity";
            this.probabilty.Name = "probabilty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Interarrival Distribution :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(626, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Server Distribution :";
            // 
            // server_dits_grid_view
            // 
            this.server_dits_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.server_dits_grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.server_dits_grid_view.Location = new System.Drawing.Point(613, 39);
            this.server_dits_grid_view.Name = "server_dits_grid_view";
            this.server_dits_grid_view.Size = new System.Drawing.Size(243, 150);
            this.server_dits_grid_view.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Server Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Probabiltity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // generate_sim_table_btn
            // 
            this.generate_sim_table_btn.Location = new System.Drawing.Point(27, 188);
            this.generate_sim_table_btn.Name = "generate_sim_table_btn";
            this.generate_sim_table_btn.Size = new System.Drawing.Size(218, 23);
            this.generate_sim_table_btn.TabIndex = 12;
            this.generate_sim_table_btn.Text = "Generate Simulation Table";
            this.generate_sim_table_btn.UseVisualStyleBackColor = true;
            this.generate_sim_table_btn.Click += new System.EventHandler(this.generate_sim_table_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(626, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Server Distribution :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(613, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Server Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Probabiltity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 384);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.generate_sim_table_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.server_dits_grid_view);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.interarrival_dits_grid_view);
            this.Controls.Add(this.selection_method_cmb);
            this.Controls.Add(this.stopping_criteria_cmb);
            this.Controls.Add(this.stopping_number_txt);
            this.Controls.Add(this.number_of_servers_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.interarrival_dits_grid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.server_dits_grid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox number_of_servers_txt;
        private System.Windows.Forms.TextBox stopping_number_txt;
        private System.Windows.Forms.ComboBox stopping_criteria_cmb;
        private System.Windows.Forms.ComboBox selection_method_cmb;
        private System.Windows.Forms.DataGridView interarrival_dits_grid_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn interarrivaltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView server_dits_grid_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button generate_sim_table_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

