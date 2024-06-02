using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static Csharp.project.Animal;

namespace Csharp.project.Frontend.Forms
{
    public partial class ZooManager : Form
    {
        public ZooManager()
        {
            InitializeComponent();
            ShowHideAnimalFieldsControls(false, false);
            selectedAnimalCmbBox.DisplayMember = "DisplayName";
            selectedAnimalCmbBox.ValueMember = "Value";
            AnimalType[] animalTypes = (AnimalType[])Enum.GetValues(typeof(AnimalType));
            animalsImages = new Image[animalTypes.Length];
            for (int i = 0; i < animalTypes.Length; i++)
            {
                var curAnimalPicPath = $"Pics\\{animalTypes[i]}.jpg";
                animalsImages[i] = Image.FromFile(curAnimalPicPath);
            }
            skinColorCmbBox.DataSource = Enum.GetValues(typeof(Snake.SkinColor));
            using (Stream stream = File.Open(zooFileFullname, FileMode.OpenOrCreate))
            {
                if (stream != null && stream.Length > 0)
                {
                    var binaryFormatter = new BinaryFormatter();
                    zooAnimals = (List<Animal>)binaryFormatter.Deserialize(stream);
                    zooAnimalsLB.Items.AddRange(zooAnimals.ToArray());
                }
            }
        }

        public enum AnimalType
        {
            Lion,
            Elephant,
            Snake,
            Turtle,
        }

        public Image[] animalsImages { get; set; }

        public class AnimalComboBoxOption
        {
            public string DisplayName { get; set; }
            public AnimalType Value { get; set; }
        }

        private void mammelRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            AnimalTypeChanged();
        }

        const string lionName = "Lion";
        const string elephantName = "Elephant";
        const string snakeName = "Snake";
        const string turtleName = "Turtle";
        AnimalComboBoxOption[] mammelsComboBoxOptions = new[]
        {
            new AnimalComboBoxOption { DisplayName = lionName, Value = AnimalType.Lion },
            new AnimalComboBoxOption { DisplayName = elephantName, Value = AnimalType.Elephant }
        };

        AnimalComboBoxOption[] reptilesComboBoxOptions = new[]
{
            new AnimalComboBoxOption { DisplayName = snakeName, Value = AnimalType.Snake },
            new AnimalComboBoxOption { DisplayName = turtleName, Value = AnimalType.Turtle }
        };

        private void AnimalTypeChanged()
        {
            selectedAnimalCmbBox.Visible = true;

            if (mammelRadBtn.Checked)
            {
                ShowHideAnimalFieldsControls(true, false);
                selectedAnimalCmbBox.DataSource = mammelsComboBoxOptions;
                selectedAnimalCmbBox.SelectedIndex = 0;
            }
            if (reptileRadBtn.Checked)
            {
                ShowHideAnimalFieldsControls(false, true);
                
                selectedAnimalCmbBox.DataSource = reptilesComboBoxOptions;
                selectedAnimalCmbBox.SelectedIndex = 0;
            }
        }

        private void ShowHideAnimalFieldsControls(bool isMammal, bool IsReptile)
        {
            isCarnChkBox.Visible = isMammal;
            gotMilkChkBox.Visible = isMammal;
            hasLegsChkBox.Visible = IsReptile;
            isColdBloodChkBox.Visible = IsReptile;
        }

        private void animalsCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedAnimalCmbBox.SelectedIndex < 0) return;

            roarVolLbl.Visible = false;
            roarVolNumUD.Visible = false;
            weightLbl.Visible = false;
            weightNumUD.Visible = false;
            doesHaveTuskChkBox.Visible = false;
            speedLbl.Visible = false;
            speedNumUD.Visible = false;
            canSwimChkBox.Visible = false;
            isVenomChkBox.Visible = false;
            skinColorLbl.Visible = false;
            skinColorCmbBox.Visible = false;

            
            var selectedAnimalItem = selectedAnimalCmbBox.SelectedItem as AnimalComboBoxOption;
            selAnimalPicBox.Image = animalsImages[(int)selectedAnimalItem.Value];

            if (selectedAnimalItem.Value == AnimalType.Lion)
            {
                roarVolLbl.Visible = true;
                roarVolNumUD.Visible = true;
            }
            else if (selectedAnimalItem.Value == AnimalType.Elephant)
            {
                weightLbl.Visible = true;
                weightNumUD.Visible = true;
                doesHaveTuskChkBox.Visible = true;
            }
            else if (selectedAnimalItem.Value == AnimalType.Turtle)
            {
                speedLbl.Visible = true;
                speedNumUD.Visible = true;
                canSwimChkBox.Visible = true;
            }
            else if (selectedAnimalItem.Value == AnimalType.Snake)
            {
                isVenomChkBox.Visible = true;
                skinColorLbl.Visible = true;
                skinColorCmbBox.Visible = true;
            }
        }

        private void reptileRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            AnimalTypeChanged();
        }

        // zooAnimals is a list of references of type Animal that points to
        // an object that is Animal or that derives from Animal and isn't abstract.
        List<Animal> zooAnimals = new List<Animal>();

        private void addAnimal2ZooBtn_Click(object sender, EventArgs e)
        {
            if (nameTxtBox.Text.Length == 0)
            {
                MessageBox.Show("Name can't be empty!", "Invalid name",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Animal newAnimal = null;
            string newAnimalName = nameTxtBox.Text;
            int newAnimalAge = (int)ageNumUD.Value;
            Gender newAnimalGender = maleRadBtn.Checked ? Gender.Male : Gender.Female;

            //if (selectedAnimalCmbBox.SelectedItem == null)
            //{
            //    MessageBox.Show("No animal selected!", "Animal Addition Failure",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            var selectedAnimalItem = selectedAnimalCmbBox.SelectedItem as AnimalComboBoxOption;
            if (selectedAnimalItem.Value == AnimalType.Lion)
            {
                newAnimal = new Lion(newAnimalName, newAnimalAge, newAnimalGender,
                    isCarnChkBox.Checked, gotMilkChkBox.Checked, (int)roarVolNumUD.Value);
            }
            else if (selectedAnimalItem.Value == AnimalType.Elephant)
            {
                newAnimal = new Elephant(newAnimalName, newAnimalAge, newAnimalGender,
                    isCarnChkBox.Checked, gotMilkChkBox.Checked,
                    (int)weightNumUD.Value, doesHaveTuskChkBox.Checked);
            }
            else if (selectedAnimalItem.Value == AnimalType.Turtle)
            {
                newAnimal = new Turtle(newAnimalName, newAnimalAge, newAnimalGender,
                    isColdBloodChkBox.Checked, hasLegsChkBox.Checked, canSwimChkBox.Checked, (int)speedNumUD.Value);
            }
            else if (selectedAnimalItem.Value == AnimalType.Snake)
            {
                newAnimal = new Snake(newAnimalName, newAnimalAge, newAnimalGender,
                    isColdBloodChkBox.Checked, hasLegsChkBox.Checked,
                    (Snake.SkinColor)skinColorCmbBox.SelectedIndex, isVenomChkBox.Checked);
            }
            zooAnimals.Add(newAnimal);
            zooAnimalsLB.Items.Add(newAnimal);
            string animalSoundFileName = $"{soundsDirName}{Path.DirectorySeparatorChar}" +
                $"{newAnimal.GetType().Name}.mp3";

            if (File.Exists(animalSoundFileName))
            {
                var reader = new Mp3FileReader(animalSoundFileName);
                var waveOut = new WaveOut(); // or WaveOutEvent()
                waveOut.Init(reader);
                waveOut.Play();
                //  waveOut.Stop();
            }
        }

        const string soundsDirName = "Sounds";

        private void removeAnimalFromZooBtn_Click(object sender, EventArgs e)
        {
            if (zooAnimalsLB.SelectedIndex < 0)
            {
                MessageBox.Show("No animal selected from the list!", "Animal Removal Failure",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            zooAnimals.RemoveAt(zooAnimalsLB.SelectedIndex);
            zooAnimalsLB.Items.RemoveAt(zooAnimalsLB.SelectedIndex);

        }

        private void saveSelAnimalBtn_Click(object sender, EventArgs e)
        {
            if (zooAnimalsLB.SelectedIndex < 0)
            {
                MessageBox.Show("No animal selected from the list!", "Animal Update Failure",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nameTxtBox.Text.Length == 0)
            {
                MessageBox.Show("Name can't be empty!", "Invalid name",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Animal selectedAnimal = zooAnimals.ElementAt(zooAnimalsLB.SelectedIndex);
            var selectedAnimalItem = selectedAnimalCmbBox.SelectedItem as AnimalComboBoxOption;
            if (selectedAnimalItem == null ||
                !selectedAnimalItem.DisplayName.Equals(selectedAnimal.GetType().Name))
            {
                MessageBox.Show("Animal's type can't be changed!", "Save Animal Failure",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedAnimal.dm_name = nameTxtBox.Text;
            selectedAnimal.dm_age = (int)ageNumUD.Value;
            selectedAnimal.dm_gender = maleRadBtn.Checked ? Gender.Male : Gender.Female;

            if (selectedAnimal is Mammel)
            {
                // create a reference of type Mammel (its compile-time type is Mammel)
                // by casting the selected animal reference to Mammel type.
                Mammel selectedMammel = selectedAnimal as Mammel;
                selectedMammel.dm_is_carnivore = isCarnChkBox.Checked;
                selectedMammel.dm_got_milk = gotMilkChkBox.Checked;
                if (selectedMammel is Lion)
                {
                    (selectedMammel as Lion).dm_roar_volume = (int)roarVolNumUD.Value;
                }
                else if (selectedMammel is Elephant)
                {
                    Elephant selectedElephant = selectedMammel as Elephant;
                    selectedElephant.dm_weight = (int)weightNumUD.Value;
                    selectedElephant.dm_has_tusk = doesHaveTuskChkBox.Checked;
                }
            }
            else if (selectedAnimal is Reptile)
            {
                Reptile selectedReptile = selectedAnimal as Reptile;
                selectedReptile.dm_is_cold_blooded = isColdBloodChkBox.Checked;
                selectedReptile.dm_has_legs = hasLegsChkBox.Checked;
                if (selectedReptile is Snake)
                {
                    Snake selectedSnake = selectedReptile as Snake;
                    selectedSnake.dm_skin_color = (Snake.SkinColor)skinColorCmbBox.SelectedIndex;
                    selectedSnake.dm_is_venomous = isVenomChkBox.Checked;
                }
                else if (selectedReptile is Turtle)
                {
                    Turtle selectedTurtle = selectedReptile as Turtle;
                    selectedTurtle.dm_can_swim = canSwimChkBox.Checked;
                    selectedTurtle.dm_speed = (int)speedNumUD.Value;
                }
            }
            int selectedAnimalInd = zooAnimalsLB.SelectedIndex;
            zooAnimalsLB.Items.RemoveAt(selectedAnimalInd);
            zooAnimalsLB.Items.Insert(selectedAnimalInd, selectedAnimal.ToString());
        }

        private void zooAnimalsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zooAnimalsLB.SelectedIndex < 0) return;
            Animal selectedAnimal = zooAnimals.ElementAt(zooAnimalsLB.SelectedIndex);
            nameTxtBox.Text = selectedAnimal.dm_name;
            ageNumUD.Value = selectedAnimal.dm_age;

            maleRadBtn.Checked = false;
            femaleRadBtn.Checked = false;
            if (selectedAnimal.dm_gender == Gender.Male)
            {
                maleRadBtn.Checked = true;
            }
            else
            {
                femaleRadBtn.Checked = true;
            }

            if (selectedAnimal is Mammel)
            {
                mammelRadBtn.Checked = true;
                // create a reference of type Mammel (its compile-time type is Mammel)
                // by casting the selected animal reference to Mammel type.
                Mammel selectedMammel = selectedAnimal as Mammel;
                isCarnChkBox.Checked = selectedMammel.dm_is_carnivore;
                gotMilkChkBox.Checked = selectedMammel.dm_got_milk;
                if (selectedMammel is Lion)
                {
                    roarVolNumUD.Value = (selectedMammel as Lion).dm_roar_volume;
                    selectedAnimalCmbBox.SelectedValue = AnimalType.Lion;
                }
                else if (selectedMammel is Elephant)
                {
                    Elephant selectedElephant = selectedMammel as Elephant;
                    weightNumUD.Value = selectedElephant.dm_weight;
                    doesHaveTuskChkBox.Checked = selectedElephant.dm_has_tusk;
                    selectedAnimalCmbBox.SelectedValue = AnimalType.Elephant;
                }
            }
            else if (selectedAnimal is Reptile)
            {
                reptileRadBtn.Checked = true;
                Reptile selectedReptile = selectedAnimal as Reptile;
                isColdBloodChkBox.Checked = selectedReptile.dm_is_cold_blooded;
                hasLegsChkBox.Checked = selectedReptile.dm_has_legs;
                if (selectedReptile is Snake)
                {
                    Snake selectedSnake = selectedReptile as Snake;
                    skinColorCmbBox.SelectedIndex = (int)selectedSnake.dm_skin_color;
                    isVenomChkBox.Checked = selectedSnake.dm_is_venomous;
                    selectedAnimalCmbBox.SelectedValue = AnimalType.Snake;
                }
                else if (selectedReptile is Turtle)
                {
                    Turtle selectedTurtle = selectedReptile as Turtle;
                    canSwimChkBox.Checked = selectedTurtle.dm_can_swim;
                    speedNumUD.Value = selectedTurtle.dm_speed;
                    selectedAnimalCmbBox.SelectedValue = AnimalType.Turtle;
                }
            }
        }

        const string zooFileFullname = "zoo.bin";

        private void AddAnimal2Zoo_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (Stream stream = File.Open(zooFileFullname, FileMode.OpenOrCreate))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, zooAnimals);
            }
        }

        private void selAnimalPicBox_Click(object sender, EventArgs e)
        {

        }

        private void ZooManager_Load(object sender, EventArgs e)
        {

        }
    }
}
