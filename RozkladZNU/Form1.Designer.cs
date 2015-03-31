namespace RozkladZNU
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.departmentsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stepsElement = new System.Windows.Forms.TabControl();
            this.departmetsTab = new System.Windows.Forms.TabPage();
            this.groupsTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.groupList = new System.Windows.Forms.ListBox();
            this.rozkladTab = new System.Windows.Forms.TabPage();
            this.stepsElement.SuspendLayout();
            this.departmetsTab.SuspendLayout();
            this.groupsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentsList
            // 
            this.departmentsList.FormattingEnabled = true;
            this.departmentsList.Location = new System.Drawing.Point(6, 33);
            this.departmentsList.Name = "departmentsList";
            this.departmentsList.Size = new System.Drawing.Size(260, 212);
            this.departmentsList.TabIndex = 0;
            this.departmentsList.SelectedIndexChanged += new System.EventHandler(this.departmentsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список факультетів:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stepsElement
            // 
            this.stepsElement.Controls.Add(this.departmetsTab);
            this.stepsElement.Controls.Add(this.groupsTab);
            this.stepsElement.Controls.Add(this.rozkladTab);
            this.stepsElement.Location = new System.Drawing.Point(12, 12);
            this.stepsElement.Name = "stepsElement";
            this.stepsElement.SelectedIndex = 0;
            this.stepsElement.Size = new System.Drawing.Size(286, 277);
            this.stepsElement.TabIndex = 4;
            this.stepsElement.Selected += new System.Windows.Forms.TabControlEventHandler(this.stepsElement_Selected);
            // 
            // departmetsTab
            // 
            this.departmetsTab.Controls.Add(this.label1);
            this.departmetsTab.Controls.Add(this.departmentsList);
            this.departmetsTab.Location = new System.Drawing.Point(4, 22);
            this.departmetsTab.Name = "departmetsTab";
            this.departmetsTab.Padding = new System.Windows.Forms.Padding(3);
            this.departmetsTab.Size = new System.Drawing.Size(278, 251);
            this.departmetsTab.TabIndex = 0;
            this.departmetsTab.Text = "Вибір факультету";
            this.departmetsTab.UseVisualStyleBackColor = true;
            this.departmetsTab.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // groupsTab
            // 
            this.groupsTab.Controls.Add(this.label2);
            this.groupsTab.Controls.Add(this.groupList);
            this.groupsTab.Location = new System.Drawing.Point(4, 22);
            this.groupsTab.Name = "groupsTab";
            this.groupsTab.Padding = new System.Windows.Forms.Padding(3);
            this.groupsTab.Size = new System.Drawing.Size(278, 251);
            this.groupsTab.TabIndex = 1;
            this.groupsTab.Text = "Вибір групи";
            this.groupsTab.UseVisualStyleBackColor = true;
            this.groupsTab.Enter += new System.EventHandler(this.groupsTab_Enter);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список групи:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupList
            // 
            this.groupList.FormattingEnabled = true;
            this.groupList.Location = new System.Drawing.Point(6, 33);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(260, 212);
            this.groupList.TabIndex = 2;
            // 
            // rozkladTab
            // 
            this.rozkladTab.Location = new System.Drawing.Point(4, 22);
            this.rozkladTab.Name = "rozkladTab";
            this.rozkladTab.Size = new System.Drawing.Size(278, 251);
            this.rozkladTab.TabIndex = 2;
            this.rozkladTab.Text = "Розклад";
            this.rozkladTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(309, 292);
            this.Controls.Add(this.stepsElement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rozklad ZNU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.stepsElement.ResumeLayout(false);
            this.departmetsTab.ResumeLayout(false);
            this.groupsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox departmentsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl stepsElement;
        private System.Windows.Forms.TabPage departmetsTab;
        private System.Windows.Forms.TabPage groupsTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox groupList;
        private System.Windows.Forms.TabPage rozkladTab;
    }
}

