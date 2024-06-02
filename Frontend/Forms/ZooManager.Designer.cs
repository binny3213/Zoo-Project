
namespace Csharp.project.Frontend.Forms
{
    partial class ZooManager
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
            this.label5 = new System.Windows.Forms.Label();
            this.maleRadBtn = new System.Windows.Forms.RadioButton();
            this.femaleRadBtn = new System.Windows.Forms.RadioButton();
            this.reptileRadBtn = new System.Windows.Forms.RadioButton();
            this.mammelRadBtn = new System.Windows.Forms.RadioButton();
            this.selectedAnimalCmbBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selAnimalPicBox = new System.Windows.Forms.PictureBox();
            this.saveSelAnimalBtn = new System.Windows.Forms.Button();
            this.addAnimal2ZooBtn = new System.Windows.Forms.Button();
            this.skinColorLbl = new System.Windows.Forms.Label();
            this.skinColorCmbBox = new System.Windows.Forms.ComboBox();
            this.isVenomChkBox = new System.Windows.Forms.CheckBox();
            this.speedNumUD = new System.Windows.Forms.NumericUpDown();
            this.speedLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.weightNumUD = new System.Windows.Forms.NumericUpDown();
            this.canSwimChkBox = new System.Windows.Forms.CheckBox();
            this.doesHaveTuskChkBox = new System.Windows.Forms.CheckBox();
            this.hasLegsChkBox = new System.Windows.Forms.CheckBox();
            this.isColdBloodChkBox = new System.Windows.Forms.CheckBox();
            this.roarVolLbl = new System.Windows.Forms.Label();
            this.roarVolNumUD = new System.Windows.Forms.NumericUpDown();
            this.gotMilkChkBox = new System.Windows.Forms.CheckBox();
            this.isCarnChkBox = new System.Windows.Forms.CheckBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.ageNumUD = new System.Windows.Forms.NumericUpDown();
            this.zooAnimalsLB = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.removeAnimalFromZooBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selAnimalPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roarVolNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1339, 174);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANIMAL CREATION";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 86);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-11, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 86);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 86);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Animal:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maleRadBtn
            // 
            this.maleRadBtn.AutoSize = true;
            this.maleRadBtn.Checked = true;
            this.maleRadBtn.Location = new System.Drawing.Point(331, 484);
            this.maleRadBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.maleRadBtn.Name = "maleRadBtn";
            this.maleRadBtn.Size = new System.Drawing.Size(90, 35);
            this.maleRadBtn.TabIndex = 14;
            this.maleRadBtn.TabStop = true;
            this.maleRadBtn.Text = "Male";
            this.maleRadBtn.UseVisualStyleBackColor = true;
            // 
            // femaleRadBtn
            // 
            this.femaleRadBtn.AutoSize = true;
            this.femaleRadBtn.Location = new System.Drawing.Point(480, 484);
            this.femaleRadBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.femaleRadBtn.Name = "femaleRadBtn";
            this.femaleRadBtn.Size = new System.Drawing.Size(122, 35);
            this.femaleRadBtn.TabIndex = 15;
            this.femaleRadBtn.Text = "Female";
            this.femaleRadBtn.UseVisualStyleBackColor = true;
            // 
            // reptileRadBtn
            // 
            this.reptileRadBtn.AutoSize = true;
            this.reptileRadBtn.Location = new System.Drawing.Point(267, 74);
            this.reptileRadBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.reptileRadBtn.Name = "reptileRadBtn";
            this.reptileRadBtn.Size = new System.Drawing.Size(117, 35);
            this.reptileRadBtn.TabIndex = 17;
            this.reptileRadBtn.TabStop = true;
            this.reptileRadBtn.Text = "Reptile";
            this.reptileRadBtn.UseVisualStyleBackColor = true;
            this.reptileRadBtn.CheckedChanged += new System.EventHandler(this.reptileRadBtn_CheckedChanged);
            // 
            // mammelRadBtn
            // 
            this.mammelRadBtn.AutoSize = true;
            this.mammelRadBtn.Location = new System.Drawing.Point(53, 74);
            this.mammelRadBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mammelRadBtn.Name = "mammelRadBtn";
            this.mammelRadBtn.Size = new System.Drawing.Size(134, 35);
            this.mammelRadBtn.TabIndex = 16;
            this.mammelRadBtn.TabStop = true;
            this.mammelRadBtn.Text = "Mammel";
            this.mammelRadBtn.UseVisualStyleBackColor = true;
            this.mammelRadBtn.CheckedChanged += new System.EventHandler(this.mammelRadBtn_CheckedChanged);
            // 
            // selectedAnimalCmbBox
            // 
            this.selectedAnimalCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedAnimalCmbBox.FormattingEnabled = true;
            this.selectedAnimalCmbBox.Location = new System.Drawing.Point(109, 153);
            this.selectedAnimalCmbBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.selectedAnimalCmbBox.Name = "selectedAnimalCmbBox";
            this.selectedAnimalCmbBox.Size = new System.Drawing.Size(316, 39);
            this.selectedAnimalCmbBox.TabIndex = 18;
            this.selectedAnimalCmbBox.Visible = false;
            this.selectedAnimalCmbBox.SelectedIndexChanged += new System.EventHandler(this.animalsCmbBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selAnimalPicBox);
            this.panel1.Controls.Add(this.saveSelAnimalBtn);
            this.panel1.Controls.Add(this.addAnimal2ZooBtn);
            this.panel1.Controls.Add(this.skinColorLbl);
            this.panel1.Controls.Add(this.skinColorCmbBox);
            this.panel1.Controls.Add(this.isVenomChkBox);
            this.panel1.Controls.Add(this.speedNumUD);
            this.panel1.Controls.Add(this.speedLbl);
            this.panel1.Controls.Add(this.weightLbl);
            this.panel1.Controls.Add(this.weightNumUD);
            this.panel1.Controls.Add(this.canSwimChkBox);
            this.panel1.Controls.Add(this.doesHaveTuskChkBox);
            this.panel1.Controls.Add(this.hasLegsChkBox);
            this.panel1.Controls.Add(this.isColdBloodChkBox);
            this.panel1.Controls.Add(this.roarVolLbl);
            this.panel1.Controls.Add(this.roarVolNumUD);
            this.panel1.Controls.Add(this.gotMilkChkBox);
            this.panel1.Controls.Add(this.isCarnChkBox);
            this.panel1.Controls.Add(this.mammelRadBtn);
            this.panel1.Controls.Add(this.selectedAnimalCmbBox);
            this.panel1.Controls.Add(this.reptileRadBtn);
            this.panel1.Location = new System.Drawing.Point(27, 687);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 706);
            this.panel1.TabIndex = 19;
            // 
            // selAnimalPicBox
            // 
            this.selAnimalPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selAnimalPicBox.Location = new System.Drawing.Point(459, 7);
            this.selAnimalPicBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.selAnimalPicBox.Name = "selAnimalPicBox";
            this.selAnimalPicBox.Size = new System.Drawing.Size(360, 423);
            this.selAnimalPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selAnimalPicBox.TabIndex = 37;
            this.selAnimalPicBox.TabStop = false;
            this.selAnimalPicBox.Click += new System.EventHandler(this.selAnimalPicBox_Click);
            // 
            // saveSelAnimalBtn
            // 
            this.saveSelAnimalBtn.AutoSize = true;
            this.saveSelAnimalBtn.Location = new System.Drawing.Point(304, 591);
            this.saveSelAnimalBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.saveSelAnimalBtn.Name = "saveSelAnimalBtn";
            this.saveSelAnimalBtn.Size = new System.Drawing.Size(515, 107);
            this.saveSelAnimalBtn.TabIndex = 25;
            this.saveSelAnimalBtn.Text = "save changes for selected animal ";
            this.saveSelAnimalBtn.UseVisualStyleBackColor = true;
            this.saveSelAnimalBtn.Click += new System.EventHandler(this.saveSelAnimalBtn_Click);
            // 
            // addAnimal2ZooBtn
            // 
            this.addAnimal2ZooBtn.AutoSize = true;
            this.addAnimal2ZooBtn.Location = new System.Drawing.Point(19, 591);
            this.addAnimal2ZooBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addAnimal2ZooBtn.Name = "addAnimal2ZooBtn";
            this.addAnimal2ZooBtn.Size = new System.Drawing.Size(255, 107);
            this.addAnimal2ZooBtn.TabIndex = 23;
            this.addAnimal2ZooBtn.Text = "Add animal to Zoo";
            this.addAnimal2ZooBtn.UseVisualStyleBackColor = true;
            this.addAnimal2ZooBtn.Click += new System.EventHandler(this.addAnimal2ZooBtn_Click);
            // 
            // skinColorLbl
            // 
            this.skinColorLbl.AutoSize = true;
            this.skinColorLbl.Location = new System.Drawing.Point(77, 460);
            this.skinColorLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.skinColorLbl.Name = "skinColorLbl";
            this.skinColorLbl.Size = new System.Drawing.Size(137, 31);
            this.skinColorLbl.TabIndex = 36;
            this.skinColorLbl.Text = "skin color:";
            this.skinColorLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.skinColorLbl.Visible = false;
            // 
            // skinColorCmbBox
            // 
            this.skinColorCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinColorCmbBox.FormattingEnabled = true;
            this.skinColorCmbBox.Location = new System.Drawing.Point(277, 446);
            this.skinColorCmbBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.skinColorCmbBox.Name = "skinColorCmbBox";
            this.skinColorCmbBox.Size = new System.Drawing.Size(316, 39);
            this.skinColorCmbBox.TabIndex = 35;
            this.skinColorCmbBox.Visible = false;
            // 
            // isVenomChkBox
            // 
            this.isVenomChkBox.AutoSize = true;
            this.isVenomChkBox.Location = new System.Drawing.Point(80, 537);
            this.isVenomChkBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.isVenomChkBox.Name = "isVenomChkBox";
            this.isVenomChkBox.Size = new System.Drawing.Size(200, 35);
            this.isVenomChkBox.TabIndex = 34;
            this.isVenomChkBox.Text = "is venomous?";
            this.isVenomChkBox.UseVisualStyleBackColor = true;
            this.isVenomChkBox.Visible = false;
            // 
            // speedNumUD
            // 
            this.speedNumUD.Location = new System.Drawing.Point(277, 448);
            this.speedNumUD.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.speedNumUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.speedNumUD.Name = "speedNumUD";
            this.speedNumUD.Size = new System.Drawing.Size(189, 38);
            this.speedNumUD.TabIndex = 32;
            this.speedNumUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.speedNumUD.Visible = false;
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Location = new System.Drawing.Point(8, 453);
            this.speedLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(241, 31);
            this.speedLbl.TabIndex = 33;
            this.speedLbl.Text = "speed (meter/min):";
            this.speedLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.speedLbl.Visible = false;
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(141, 453);
            this.weightLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(101, 31);
            this.weightLbl.TabIndex = 31;
            this.weightLbl.Text = "weight:";
            this.weightLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.weightLbl.Visible = false;
            // 
            // weightNumUD
            // 
            this.weightNumUD.Location = new System.Drawing.Point(267, 448);
            this.weightNumUD.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.weightNumUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weightNumUD.Name = "weightNumUD";
            this.weightNumUD.Size = new System.Drawing.Size(189, 38);
            this.weightNumUD.TabIndex = 30;
            this.weightNumUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.weightNumUD.Visible = false;
            // 
            // canSwimChkBox
            // 
            this.canSwimChkBox.AutoSize = true;
            this.canSwimChkBox.Location = new System.Drawing.Point(96, 537);
            this.canSwimChkBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.canSwimChkBox.Name = "canSwimChkBox";
            this.canSwimChkBox.Size = new System.Drawing.Size(161, 35);
            this.canSwimChkBox.TabIndex = 29;
            this.canSwimChkBox.Text = "can swim?";
            this.canSwimChkBox.UseVisualStyleBackColor = true;
            this.canSwimChkBox.Visible = false;
            // 
            // doesHaveTuskChkBox
            // 
            this.doesHaveTuskChkBox.AutoSize = true;
            this.doesHaveTuskChkBox.Location = new System.Drawing.Point(80, 537);
            this.doesHaveTuskChkBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.doesHaveTuskChkBox.Name = "doesHaveTuskChkBox";
            this.doesHaveTuskChkBox.Size = new System.Drawing.Size(231, 35);
            this.doesHaveTuskChkBox.TabIndex = 29;
            this.doesHaveTuskChkBox.Text = "does have tusk?";
            this.doesHaveTuskChkBox.UseVisualStyleBackColor = true;
            this.doesHaveTuskChkBox.Visible = false;
            // 
            // hasLegsChkBox
            // 
            this.hasLegsChkBox.AutoSize = true;
            this.hasLegsChkBox.Location = new System.Drawing.Point(109, 348);
            this.hasLegsChkBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.hasLegsChkBox.Name = "hasLegsChkBox";
            this.hasLegsChkBox.Size = new System.Drawing.Size(149, 35);
            this.hasLegsChkBox.TabIndex = 28;
            this.hasLegsChkBox.Text = "has legs?";
            this.hasLegsChkBox.UseVisualStyleBackColor = true;
            this.hasLegsChkBox.Visible = false;
            // 
            // isColdBloodChkBox
            // 
            this.isColdBloodChkBox.AutoSize = true;
            this.isColdBloodChkBox.Location = new System.Drawing.Point(85, 253);
            this.isColdBloodChkBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.isColdBloodChkBox.Name = "isColdBloodChkBox";
            this.isColdBloodChkBox.Size = new System.Drawing.Size(228, 35);
            this.isColdBloodChkBox.TabIndex = 27;
            this.isColdBloodChkBox.Text = "is cold blooded?";
            this.isColdBloodChkBox.UseVisualStyleBackColor = true;
            this.isColdBloodChkBox.Visible = false;
            // 
            // roarVolLbl
            // 
            this.roarVolLbl.AutoSize = true;
            this.roarVolLbl.Location = new System.Drawing.Point(77, 448);
            this.roarVolLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roarVolLbl.Name = "roarVolLbl";
            this.roarVolLbl.Size = new System.Drawing.Size(164, 31);
            this.roarVolLbl.TabIndex = 26;
            this.roarVolLbl.Text = "roar volume:";
            this.roarVolLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.roarVolLbl.Visible = false;
            // 
            // roarVolNumUD
            // 
            this.roarVolNumUD.Location = new System.Drawing.Point(291, 444);
            this.roarVolNumUD.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.roarVolNumUD.Name = "roarVolNumUD";
            this.roarVolNumUD.Size = new System.Drawing.Size(320, 38);
            this.roarVolNumUD.TabIndex = 23;
            this.roarVolNumUD.Visible = false;
            // 
            // gotMilkChkBox
            // 
            this.gotMilkChkBox.AutoSize = true;
            this.gotMilkChkBox.Location = new System.Drawing.Point(109, 348);
            this.gotMilkChkBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gotMilkChkBox.Name = "gotMilkChkBox";
            this.gotMilkChkBox.Size = new System.Drawing.Size(141, 35);
            this.gotMilkChkBox.TabIndex = 24;
            this.gotMilkChkBox.Text = "got milk?";
            this.gotMilkChkBox.UseVisualStyleBackColor = true;
            this.gotMilkChkBox.Visible = false;
            // 
            // isCarnChkBox
            // 
            this.isCarnChkBox.AutoSize = true;
            this.isCarnChkBox.Location = new System.Drawing.Point(109, 253);
            this.isCarnChkBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.isCarnChkBox.Name = "isCarnChkBox";
            this.isCarnChkBox.Size = new System.Drawing.Size(187, 35);
            this.isCarnChkBox.TabIndex = 23;
            this.isCarnChkBox.Text = "is carnivore?";
            this.isCarnChkBox.UseVisualStyleBackColor = true;
            this.isCarnChkBox.Visible = false;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(259, 238);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(260, 38);
            this.nameTxtBox.TabIndex = 20;
            // 
            // ageNumUD
            // 
            this.ageNumUD.Location = new System.Drawing.Point(259, 372);
            this.ageNumUD.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ageNumUD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ageNumUD.Name = "ageNumUD";
            this.ageNumUD.Size = new System.Drawing.Size(189, 38);
            this.ageNumUD.TabIndex = 21;
            this.ageNumUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // zooAnimalsLB
            // 
            this.zooAnimalsLB.FormattingEnabled = true;
            this.zooAnimalsLB.ItemHeight = 31;
            this.zooAnimalsLB.Location = new System.Drawing.Point(862, 255);
            this.zooAnimalsLB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.zooAnimalsLB.Name = "zooAnimalsLB";
            this.zooAnimalsLB.Size = new System.Drawing.Size(1685, 1027);
            this.zooAnimalsLB.TabIndex = 22;
            this.zooAnimalsLB.SelectedIndexChanged += new System.EventHandler(this.zooAnimalsLB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(856, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Zoo Animals:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeAnimalFromZooBtn
            // 
            this.removeAnimalFromZooBtn.AutoSize = true;
            this.removeAnimalFromZooBtn.Location = new System.Drawing.Point(862, 1286);
            this.removeAnimalFromZooBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.removeAnimalFromZooBtn.Name = "removeAnimalFromZooBtn";
            this.removeAnimalFromZooBtn.Size = new System.Drawing.Size(456, 107);
            this.removeAnimalFromZooBtn.TabIndex = 24;
            this.removeAnimalFromZooBtn.Text = "remove selected animal from zoo";
            this.removeAnimalFromZooBtn.UseVisualStyleBackColor = true;
            this.removeAnimalFromZooBtn.Click += new System.EventHandler(this.removeAnimalFromZooBtn_Click);
            // 
            // ZooManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zoo.Properties.Resources.wood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2564, 1421);
            this.Controls.Add(this.removeAnimalFromZooBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zooAnimalsLB);
            this.Controls.Add(this.ageNumUD);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.femaleRadBtn);
            this.Controls.Add(this.maleRadBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ZooManager";
            this.Text = "Zoo Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAnimal2Zoo_FormClosing);
            this.Load += new System.EventHandler(this.ZooManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selAnimalPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roarVolNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton maleRadBtn;
        private System.Windows.Forms.RadioButton femaleRadBtn;
        private System.Windows.Forms.RadioButton reptileRadBtn;
        private System.Windows.Forms.RadioButton mammelRadBtn;
        private System.Windows.Forms.ComboBox selectedAnimalCmbBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.NumericUpDown ageNumUD;
        private System.Windows.Forms.Label roarVolLbl;
        private System.Windows.Forms.NumericUpDown roarVolNumUD;
        private System.Windows.Forms.CheckBox gotMilkChkBox;
        private System.Windows.Forms.CheckBox isCarnChkBox;
        private System.Windows.Forms.CheckBox hasLegsChkBox;
        private System.Windows.Forms.CheckBox isColdBloodChkBox;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.NumericUpDown weightNumUD;
        private System.Windows.Forms.CheckBox doesHaveTuskChkBox;
        private System.Windows.Forms.NumericUpDown speedNumUD;
        private System.Windows.Forms.Label speedLbl;
        private System.Windows.Forms.CheckBox canSwimChkBox;
        private System.Windows.Forms.Label skinColorLbl;
        private System.Windows.Forms.ComboBox skinColorCmbBox;
        private System.Windows.Forms.CheckBox isVenomChkBox;
        private System.Windows.Forms.Button addAnimal2ZooBtn;
        private System.Windows.Forms.ListBox zooAnimalsLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button removeAnimalFromZooBtn;
        private System.Windows.Forms.Button saveSelAnimalBtn;
        private System.Windows.Forms.PictureBox selAnimalPicBox;
    }
}