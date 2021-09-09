
namespace Scheduler
{
    partial class CaseWorkerVisualSchedule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)<DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 @2)" Visibility="Hidden" />
    <Node Id="(@3 Namespace=Scheduler Type=CaseWorkerVisualSchedule)" Category="CodeSchema_Class" CodeSchemaProperty_IsPublic="True" CommonLabel="CaseWorkerVisualSchedule" Icon="Microsoft.VisualStudio.Class.Public" IsDragSource="True" Label="CaseWorkerVisualSchedule" SourceLocation="(Assembly=&quot;file:///C:/Users/46720/Documents/Sania/EC_Webutvecklare/VS_code/katas 36/Kata_v36/CaseWorkerVisualSchedule.Designer.cs&quot; StartLineNumber=3 StartCharacterOffset=18 EndLineNumber=3 EndCharacterOffset=42)" />
  </Nodes>
  <Links>
    <Link Source="(@1 @2)" Target="(@3 Namespace=Scheduler Type=CaseWorkerVisualSchedule)" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Class" Label="Class" BasedOn="CodeSchema_Type" Icon="CodeSchema_Class" />
    <Category Id="CodeSchema_Type" Label="Type" Icon="CodeSchema_Class" />
    <Category Id="Contains" Label="Contains" Description="Whether the source of the link contains the target object" IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsPublic" Label="Is Public" Description="Flag to indicate the scope is Public" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Icon" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Label" Description="Displayable label of an Annotatable object" DataType="System.String" />
    <Property Id="SourceLocation" Label="Start Line Number" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibility" Description="Defines whether a node in the graph is visible or not" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="File" Label="File" ValueType="Uri" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="Type" Label="Type" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(VsSolutionUri)/Kata_v36/Scheduler.csproj" />
    <Alias n="2" Uri="File=$(VsSolutionUri)/Kata_v36/CaseWorkerVisualSchedule.Designer.cs" />
    <Alias n="3" Uri="Assembly=$(f3bbde4c-7794-4ea4-970e-e649548626cc.OutputPathUri)" />
  </IdentifierAliases>
  <Paths>
    <Path Id="f3bbde4c-7794-4ea4-970e-e649548626cc.OutputPathUri" Value="file:///C:/Users/46720/Documents/Sania/EC_Webutvecklare/VS_code/katas 36/Kata_v36/bin/Debug/net5.0-windows/Scheduler.dll" />
    <Path Id="VsSolutionUri" Value="file:///C:/Users/46720/Documents/Sania/EC_Webutvecklare/VS_code/katas 36" />
  </Paths>
</DirectedGraph>
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_CaseWorkerName = new System.Windows.Forms.Label();
            this.listBox_Meetings = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_ChangeDate = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CaseWorkerName
            // 
            this.label_CaseWorkerName.AutoSize = true;
            this.label_CaseWorkerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_CaseWorkerName.Location = new System.Drawing.Point(0, 0);
            this.label_CaseWorkerName.Name = "label_CaseWorkerName";
            this.label_CaseWorkerName.Size = new System.Drawing.Size(74, 32);
            this.label_CaseWorkerName.TabIndex = 0;
            this.label_CaseWorkerName.Text = "name";
            // 
            // listBox_Meetings
            // 
            this.listBox_Meetings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Meetings.FormattingEnabled = true;
            this.listBox_Meetings.ItemHeight = 32;
            this.listBox_Meetings.Location = new System.Drawing.Point(0, 32);
            this.listBox_Meetings.Name = "listBox_Meetings";
            this.listBox_Meetings.Size = new System.Drawing.Size(576, 388);
            this.listBox_Meetings.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_ChangeDate);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 80);
            this.panel1.TabIndex = 2;
            // 
            // button_ChangeDate
            // 
            this.button_ChangeDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ChangeDate.Location = new System.Drawing.Point(0, 39);
            this.button_ChangeDate.Name = "button_ChangeDate";
            this.button_ChangeDate.Size = new System.Drawing.Size(284, 41);
            this.button_ChangeDate.TabIndex = 2;
            this.button_ChangeDate.Text = "Change";
            this.button_ChangeDate.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Add.Location = new System.Drawing.Point(284, 39);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(292, 41);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy.MM.dd HH:mm";
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(576, 39);
            this.dateTimePicker.TabIndex = 1;
            // 
            // CaseWorkerVisualSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox_Meetings);
            this.Controls.Add(this.label_CaseWorkerName);
            this.Name = "CaseWorkerVisualSchedule";
            this.Size = new System.Drawing.Size(576, 420);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CaseWorkerName;
        private System.Windows.Forms.ListBox listBox_Meetings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button_ChangeDate;
    }
}
