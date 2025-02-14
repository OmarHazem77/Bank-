namespace Bank
{
    partial class Form1
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
            account_id = new TextBox();
            label1 = new Label();
            first_name = new TextBox();
            second_name = new TextBox();
            balance = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            clear_form = new Button();
            startof_file = new Button();
            endof_file = new Button();
            close_file = new Button();
            open_file = new Button();
            insert_file = new Button();
            read_file = new Button();
            searchbyaccount_id = new Button();
            exit = new Button();
            delete_record = new Button();
            squeeze_file = new Button();
            SuspendLayout();
            // 
            // account_id
            // 
            account_id.Location = new Point(140, 74);
            account_id.Name = "account_id";
            account_id.Size = new Size(462, 27);
            account_id.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 77);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "Account_ID";
            // 
            // first_name
            // 
            first_name.Location = new Point(140, 133);
            first_name.Name = "first_name";
            first_name.Size = new Size(462, 27);
            first_name.TabIndex = 0;
            // 
            // second_name
            // 
            second_name.Location = new Point(140, 189);
            second_name.Name = "second_name";
            second_name.Size = new Size(462, 27);
            second_name.TabIndex = 0;
            // 
            // balance
            // 
            balance.Location = new Point(140, 257);
            balance.Name = "balance";
            balance.Size = new Size(462, 27);
            balance.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 136);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 196);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 1;
            label3.Text = "Second Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 264);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 1;
            label4.Text = "Balance";
            // 
            // clear_form
            // 
            clear_form.Enabled = false;
            clear_form.Location = new Point(644, 52);
            clear_form.Name = "clear_form";
            clear_form.Size = new Size(94, 45);
            clear_form.TabIndex = 2;
            clear_form.Text = "Clear Form";
            clear_form.UseVisualStyleBackColor = true;
            // 
            // startof_file
            // 
            startof_file.Enabled = false;
            startof_file.Location = new Point(644, 120);
            startof_file.Name = "startof_file";
            startof_file.Size = new Size(94, 45);
            startof_file.TabIndex = 2;
            startof_file.Text = "Start of file";
            startof_file.UseVisualStyleBackColor = true;
            // 
            // endof_file
            // 
            endof_file.Enabled = false;
            endof_file.Location = new Point(644, 176);
            endof_file.Name = "endof_file";
            endof_file.Size = new Size(94, 45);
            endof_file.TabIndex = 2;
            endof_file.Text = "End of file";
            endof_file.UseVisualStyleBackColor = true;
            // 
            // close_file
            // 
            close_file.Enabled = false;
            close_file.Location = new Point(644, 239);
            close_file.Name = "close_file";
            close_file.Size = new Size(94, 45);
            close_file.TabIndex = 2;
            close_file.Text = "Close File";
            close_file.UseVisualStyleBackColor = true;
            close_file.Click += button4_Click;
            // 
            // open_file
            // 
            open_file.Location = new Point(44, 333);
            open_file.Name = "open_file";
            open_file.Size = new Size(94, 45);
            open_file.TabIndex = 2;
            open_file.Text = "Open File";
            open_file.UseVisualStyleBackColor = true;
            // 
            // insert_file
            // 
            insert_file.Enabled = false;
            insert_file.Location = new Point(165, 333);
            insert_file.Name = "insert_file";
            insert_file.Size = new Size(94, 45);
            insert_file.TabIndex = 2;
            insert_file.Text = "Insert";
            insert_file.UseVisualStyleBackColor = true;
            insert_file.Click += button6_Click;
            // 
            // read_file
            // 
            read_file.Enabled = false;
            read_file.Location = new Point(299, 333);
            read_file.Name = "read_file";
            read_file.Size = new Size(94, 45);
            read_file.TabIndex = 2;
            read_file.Text = "Read";
            read_file.UseVisualStyleBackColor = true;
            read_file.Click += button7_Click;
            // 
            // searchbyaccount_id
            // 
            searchbyaccount_id.Enabled = false;
            searchbyaccount_id.Location = new Point(432, 333);
            searchbyaccount_id.Name = "searchbyaccount_id";
            searchbyaccount_id.Size = new Size(191, 45);
            searchbyaccount_id.TabIndex = 2;
            searchbyaccount_id.Text = "Search by account_id ";
            searchbyaccount_id.UseVisualStyleBackColor = true;
            searchbyaccount_id.Click += button8_Click;
            // 
            // exit
            // 
            exit.Location = new Point(668, 409);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 2;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            // 
            // delete_record
            // 
            delete_record.Enabled = false;
            delete_record.Location = new Point(88, 399);
            delete_record.Name = "delete_record";
            delete_record.Size = new Size(139, 39);
            delete_record.TabIndex = 2;
            delete_record.Text = "Delete Record";
            delete_record.UseVisualStyleBackColor = true;
            // 
            // squeeze_file
            // 
            squeeze_file.Enabled = false;
            squeeze_file.Location = new Point(357, 399);
            squeeze_file.Name = "squeeze_file";
            squeeze_file.Size = new Size(132, 39);
            squeeze_file.TabIndex = 2;
            squeeze_file.Text = "Squeeze File";
            squeeze_file.UseVisualStyleBackColor = true;
            squeeze_file.Click += button11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(squeeze_file);
            Controls.Add(delete_record);
            Controls.Add(exit);
            Controls.Add(searchbyaccount_id);
            Controls.Add(read_file);
            Controls.Add(insert_file);
            Controls.Add(open_file);
            Controls.Add(close_file);
            Controls.Add(endof_file);
            Controls.Add(startof_file);
            Controls.Add(clear_form);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(balance);
            Controls.Add(second_name);
            Controls.Add(first_name);
            Controls.Add(account_id);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox account_id;
        private Label label1;
        private TextBox first_name;
        private TextBox second_name;
        private TextBox balance;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button clear_form;
        private Button startof_file;
        private Button endof_file;
        private Button close_file;
        private Button open_file;
        private Button insert_file;
        private Button read_file;
        private Button searchbyaccount_id;
        private Button exit;
        private Button delete_record;
        private Button squeeze_file;
    }
}
