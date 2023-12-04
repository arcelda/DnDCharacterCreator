using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
//using Microsoft.EntityFrameworkCore;

namespace DnDCharacterCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string mscaption = "DnD Character Creator";
        string name = "";
        string gender = "";
        string race = "";
        string role = "";
        string password = "";
        const int MAX_POINTS = 28;
        const int BOOST_POINTS = 15;
        static int usedPoints = 0;
        int level;

        PictureBox currentRace, currentRole;

        static int base_strength = 8, base_dexterity = 8, base_constitution = 8, base_intelligence = 8, base_wisdom = 8, base_charisma = 8;
        static int race_strength = 0, race_dexterity = 0, race_constitution = 0, race_intelligence = 0, race_wisdom = 0, race_charisma = 0;
        static int alloted_strength = 0, alloted_dexterity = 0, alloted_constitution = 0, alloted_intelligence = 0, alloted_wisdom = 0, alloted_charisma = 0;
        static int total_strength = base_strength + alloted_strength,
            total_dexterity = base_dexterity + alloted_dexterity,
            total_constitution = base_constitution + alloted_constitution,
            total_intelligence = base_intelligence + alloted_intelligence,
            total_wisdom = base_wisdom + alloted_wisdom,
            total_charisma = base_charisma + alloted_charisma;
        static int final_strength = total_strength + race_strength,
            final_dexterity = total_dexterity + race_dexterity,
            final_constitution = total_constitution + race_constitution,
            final_intelligence = total_intelligence + race_intelligence,
            final_wisdom = total_wisdom + race_wisdom, 
            final_charisma = total_charisma + race_charisma;


        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                if(i != 0)
                {
                    tabControl1.TabPages[i].Enabled = false;
                }
            }
        }

        //Race Selection
        private void pictureDragonBorn_Click(object sender, EventArgs e)
        {
            clearRaceStats();
            if(currentRace == null)
            {
                currentRace = pictureDragonBorn;
                currentRace.BackColor = Color.White;
            }
            else
            {
                currentRace.BackColor = Color.Transparent;
                currentRace = pictureDragonBorn;
                currentRace.BackColor = Color.White;

            }
                race = "DragonBorn";

                race_strength = 2;
                race_charisma = 1;
                updateStats();
        }

        private void pictureDwarf_Click(object sender, EventArgs e)
        {
            clearRaceStats();
            if (currentRace == null)
            {
                currentRace = pictureDwarf;
                currentRace.BackColor = Color.White;
            }
            else
            {
                currentRace.BackColor = Color.Transparent;
                currentRace = pictureDwarf;
                currentRace.BackColor = Color.White;

            }
            race = "Dwarf";

            race_constitution = 2;
            updateStats();
        }

        private void pictureElf_Click(object sender, EventArgs e)
        {
            clearRaceStats();
            if (currentRace == null)
            {
                currentRace = pictureElf;
                currentRace.BackColor = Color.White;
            }
            else
            {
                currentRace.BackColor = Color.Transparent;
                currentRace = pictureElf;
                currentRace.BackColor = Color.White;

            }
            race = "Elf";

            race_dexterity = 2;
            updateStats();
        }

        private void pictureHalfElf_Click(object sender, EventArgs e)
        {
            clearRaceStats();

            if (currentRace == null)
            {
                currentRace = pictureHalfElf;
                currentRace.BackColor = Color.White;
            }
            else
            {
                currentRace.BackColor = Color.Transparent;
                currentRace = pictureHalfElf;
                currentRace.BackColor = Color.White;

            }
            race = "Half-Elf";

            race_charisma = 2;

            updateStats();
        }

        private void pictureHalfOrc_Click(object sender, EventArgs e)
        {
            clearRaceStats();
            if (currentRace == null)
            {
                currentRace = pictureHalfOrc;
                currentRace.BackColor = Color.White;
            }
            else
            {
                currentRace.BackColor = Color.Transparent;
                currentRace = pictureHalfOrc;
                currentRace.BackColor = Color.White;

            }
            race = "Half-Orc";

            race_strength = 2;
            race_constitution = 1;
            updateStats();
        }

        private void pictureGnome_Click(object sender, EventArgs e)
        {
            clearRaceStats();
            if (currentRace == null)
            {
                currentRace = pictureGnome;
                currentRace.BackColor = Color.White;
            }
            else
            {
                currentRace.BackColor = Color.Transparent;
                currentRace = pictureGnome;
                currentRace.BackColor = Color.White;

            }
            race = "Gnome";

            race_intelligence = 2;
            updateStats();
        }

        private void pictureTiefling_Click(object sender, EventArgs e)
        {
            clearRaceStats();
            if (currentRace == null)
            {
                currentRace = pictureTiefling;
                currentRace.BackColor = Color.White;
            }
            else
            {
                currentRace.BackColor = Color.Transparent;
                currentRace = pictureTiefling;
                currentRace.BackColor = Color.White;

            }
            race = "Tiefling";

            race_charisma = 2;
            race_intelligence = 1;
            updateStats();
        }

        private void pictureHalfling_Click(object sender, EventArgs e)
        {
            clearRaceStats();
            if (currentRace == null)
            {
                currentRace = pictureHalfling;
                currentRace.BackColor = Color.White;
            }
            else
            {
                currentRace.BackColor = Color.Transparent;
                currentRace = pictureHalfling;
                currentRace.BackColor = Color.White;

            }

            race = "Halfling";

            race_dexterity = 2;
            updateStats();
        }

        private void pictureHuman_Click(object sender, EventArgs e)
        {
            clearRaceStats();
            if (currentRace == null)
            {
                currentRace = pictureHuman;
                currentRace.BackColor = Color.White;
            }
            else
            {
                currentRace.BackColor = Color.Transparent;
                currentRace = pictureHuman;
                currentRace.BackColor = Color.White;
                
            }
            race = "Human";

            race_charisma = 1;
            race_intelligence = 1;
            race_constitution = 1;
            race_dexterity = 1;
            race_strength = 1;
            race_wisdom = 1;
            updateStats();
        }

        //Confirming the race that the player picked
        private void buttonDone_Click(object sender, EventArgs e)
        {
            if(currentRace == null)
            {
                MessageBox.Show("You have not selected a race.\n" +
                    "Please pick one to continue.", mscaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult choiceYN = MessageBox.Show("You have selected " + race + "\nIs this your final selection?",
                    mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(choiceYN == DialogResult.Yes)
                {
                    buttonNextPage.Enabled = true;
                    labelRaceString.Text = "Race: " + race;
                    labelRaceString.Visible = true;

                    labelStrength.Visible= true;
                    labelConstitution.Visible= true;
                    labelDexterity.Visible= true;
                    labelCharisma.Visible= true;
                    labelWisdom.Visible= true;
                    labelIntelligence.Visible= true;
                    nextPage();
                }
            }
        }

        //Letting the player pick their role
        private void pictureBoxBarbarian_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                currentRole = pictureBoxBarbarian;
                currentRole.BackColor = Color.White;
            }
            else
            {
                currentRole.BackColor = Color.Transparent;
                currentRole = pictureBoxBarbarian;
                currentRole.BackColor = Color.White;
            }

            role = "Barbarian";
        }

        private void pictureBoxRogue_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                currentRole = pictureBoxRogue;
                currentRole.BackColor = Color.White;
            }
            else
            {
                currentRole.BackColor = Color.Transparent;
                currentRole = pictureBoxRogue;
                currentRole.BackColor = Color.White;
            }

            role = "Rogue";
        }

        private void pictureBoxCleric_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                currentRole = pictureBoxCleric;
                currentRole.BackColor = Color.White;
            }
            else
            {
                currentRole.BackColor = Color.Transparent;
                currentRole = pictureBoxCleric;
                currentRole.BackColor = Color.White;
            }

            role = "Cleric";
        }

        private void pictureBoxFighter_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                currentRole = pictureBoxFighter;
                currentRole.BackColor = Color.White;
            }
            else
            {
                currentRole.BackColor = Color.Transparent;
                currentRole = pictureBoxFighter;
                currentRole.BackColor = Color.White;
            }

            role = "Fighter";
        }

        private void pictureBoxMonk_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                currentRole = pictureBoxMonk;
                currentRole.BackColor = Color.White;
            }
            else
            {
                currentRole.BackColor = Color.Transparent;
                currentRole = pictureBoxMonk;
                currentRole.BackColor = Color.White;
            }

            role = "Monk";
        }

        private void pictureBoxPaladin_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                currentRole = pictureBoxPaladin;
                currentRole.BackColor = Color.White;
            }
            else
            {
                currentRole.BackColor = Color.Transparent;
                currentRole = pictureBoxPaladin;
                currentRole.BackColor = Color.White;
            }

            role = "Paladin";
        }

        private void pictureBoxDruid_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                currentRole = pictureBoxDruid;
                currentRole.BackColor = Color.White;
            }
            else
            {
                currentRole.BackColor = Color.Transparent;
                currentRole = pictureBoxDruid;
                currentRole.BackColor = Color.White;
            }

            role = "Druid";
        }

        private void pictureBoxBard_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                currentRole = pictureBoxBard;
                currentRole.BackColor = Color.White;
            }
            else
            {
                currentRole.BackColor = Color.Transparent;
                currentRole = pictureBoxBard;
                currentRole.BackColor = Color.White;
            }

            role = "Bard";
        }

        private void pictureBoxRanger_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                currentRole = pictureBoxRanger;
                currentRole.BackColor = Color.White;
            }
            else
            {
                currentRole.BackColor = Color.Transparent;
                currentRole = pictureBoxRanger;
                currentRole.BackColor = Color.White;
            }

            role = "Ranger";
        }

        //Logic for the increase/decrease buttons
        private void buttonAddStrength_Click(object sender, EventArgs e)
        {
            if (usedPoints < MAX_POINTS)
            {
                alloted_strength = alloted_strength + 1;
                total_strength = 1 + total_strength;
                labelAllocatedStr.Text = alloted_strength.ToString();

                if (total_strength < BOOST_POINTS)
                {
                    usedPoints = usedPoints + 1;
                }
                else
                {
                    if (usedPoints + 2 > MAX_POINTS)
                    {
                        MessageBox.Show("You cannot put anymore points into this\n" +
                            "because you will go over the alloted amount.", mscaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        total_strength = total_strength - 1;
                        alloted_strength = alloted_strength - 1;
                        labelAllocatedStr.Text = alloted_strength.ToString();
                    }
                    else
                    {
                        usedPoints = usedPoints + 2;
                    }
                }

                labelUsedPoints.Text = usedPoints.ToString();
                updateStats();
            }
            else
            {
                DialogResult capYN = MessageBox.Show("You have reached the maximum alloted points." +
                    "\nIs this the final build you wish to go with?", mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (capYN == DialogResult.Yes)
                {
                    buttonNextPage.Visible = true;
                    finalPoints();
                    nextPage();
                }
            }
        }
        private void buttonAddDexterity_Click(object sender, EventArgs e)
        {
            if (usedPoints < MAX_POINTS)
            {
                alloted_dexterity = alloted_dexterity + 1;
                total_dexterity = 1 + total_dexterity;
                labelAllocatedDex.Text = alloted_dexterity.ToString();

                if (total_dexterity < BOOST_POINTS)
                {
                    usedPoints = usedPoints + 1;
                }
                else
                {
                    if (usedPoints + 2 > MAX_POINTS)
                    {
                        MessageBox.Show("You cannot put anymore points into this\n" +
                            "because you will go over the alloted amount.", mscaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        total_dexterity = total_dexterity - 1;
                        alloted_dexterity = alloted_dexterity - 1;
                        labelAllocatedDex.Text = alloted_dexterity.ToString();
                    }
                    else
                    {
                        usedPoints = usedPoints + 2;
                    }
                }

                labelUsedPoints.Text = usedPoints.ToString();
                updateStats();
            }
            else
            {
                DialogResult capYN = MessageBox.Show("You have reached the maximum alloted points." +
                    "\nIs this the final build you wish to go with?", mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (capYN == DialogResult.Yes)
                {
                    buttonNextPage.Visible = true;
                    finalPoints();
                    nextPage();
                }
            }
        }

        private void buttonAddConstitution_Click(object sender, EventArgs e)
        {
            if (usedPoints < MAX_POINTS)
            {
                alloted_constitution = alloted_constitution + 1;
                total_constitution = 1 + total_constitution;
                labelAllocatedCon.Text = alloted_constitution.ToString();

                if (total_constitution < BOOST_POINTS)
                {
                    usedPoints = usedPoints + 1;
                }
                else
                {
                    if (usedPoints + 2 > MAX_POINTS)
                    {
                        MessageBox.Show("You cannot put anymore points into this\n" +
                            "because you will go over the alloted amount.", mscaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        total_constitution = total_constitution - 1;
                        alloted_constitution = alloted_constitution - 1;
                        labelAllocatedCon.Text = alloted_constitution.ToString();
                    }
                    else
                    {
                        usedPoints = usedPoints + 2;
                    }
                }

                labelUsedPoints.Text = usedPoints.ToString();
                updateStats();
            }
            else
            {
                DialogResult capYN = MessageBox.Show("You have reached the maximum alloted points." +
                    "\nIs this the final build you wish to go with?", mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (capYN == DialogResult.Yes)
                {
                    buttonNextPage.Visible = true;
                    finalPoints();
                    nextPage();
                }
            }
        }

        private void buttonAddWisdom_Click(object sender, EventArgs e)
        {
            if (usedPoints < MAX_POINTS)
            {
                alloted_wisdom = alloted_wisdom + 1;
                total_wisdom = 1 + total_wisdom;
                labelAllocatedWis.Text = alloted_wisdom.ToString();

                if (total_wisdom < BOOST_POINTS)
                {
                    usedPoints = usedPoints + 1;
                }
                else
                {
                    if (usedPoints + 2 > MAX_POINTS)
                    {
                        MessageBox.Show("You cannot put anymore points into this\n" +
                            "because you will go over the alloted amount.", mscaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        total_wisdom = total_wisdom - 1;
                        alloted_wisdom = alloted_wisdom - 1;
                        labelAllocatedWis.Text = alloted_wisdom.ToString();
                    }
                    else
                    {
                        usedPoints = usedPoints + 2;
                    }
                }

                labelUsedPoints.Text = usedPoints.ToString();
                updateStats();
            }
            else
            {
                DialogResult capYN = MessageBox.Show("You have reached the maximum alloted points." +
                    "\nIs this the final build you wish to go with?", mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (capYN == DialogResult.Yes)
                {
                    buttonNextPage.Visible = true;
                    finalPoints();
                    nextPage();
                }
            }
        }

        private void buttonAddIntelligence_Click(object sender, EventArgs e)
        {
            if (usedPoints < MAX_POINTS)
            {
                alloted_intelligence = alloted_intelligence + 1;
                total_intelligence = 1 + total_intelligence;
                labelAllocatedInt.Text = alloted_intelligence.ToString();

                if (total_intelligence < BOOST_POINTS)
                {
                    usedPoints = usedPoints + 1;
                }
                else
                {
                    if (usedPoints + 2 > MAX_POINTS)
                    {
                        MessageBox.Show("You cannot put anymore points into this\n" +
                            "because you will go over the alloted amount.", mscaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        total_intelligence = total_intelligence - 1;
                        alloted_intelligence = alloted_intelligence - 1;
                        labelAllocatedInt.Text = alloted_intelligence.ToString();
                    }
                    else
                    {
                        usedPoints = usedPoints + 2;
                    }
                }

                labelUsedPoints.Text = usedPoints.ToString();
                updateStats();
            }
            else
            {
                DialogResult capYN = MessageBox.Show("You have reached the maximum alloted points." +
                    "\nIs this the final build you wish to go with?", mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (capYN == DialogResult.Yes)
                {
                    buttonNextPage.Visible = true;
                    finalPoints();
                    nextPage();
                }
            }
        }
        private void buttonAddCharisma_Click(object sender, EventArgs e)
        {
            if (usedPoints < MAX_POINTS)
            {
                alloted_charisma = alloted_charisma + 1;
                total_charisma = 1 + total_charisma;
                labelAllocatedCha.Text = alloted_charisma.ToString();

                if (total_charisma < BOOST_POINTS)
                {
                    usedPoints = usedPoints + 1;
                }
                else
                {
                    if(usedPoints + 2 > MAX_POINTS)
                    {
                        MessageBox.Show("You cannot put anymore points into this\n" +
                            "because you will go over the alloted amount.", mscaption, 
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        total_charisma = total_charisma - 1;
                        alloted_charisma = alloted_charisma - 1;
                        labelAllocatedCha.Text = alloted_charisma.ToString();
                    }
                    else
                    {
                        usedPoints = usedPoints + 2;
                    }
                }

                labelUsedPoints.Text = usedPoints.ToString();
                updateStats();
            }
            else
            {
                DialogResult capYN = MessageBox.Show("You have reached the maximum alloted points." +
                    "\nIs this the final build you wish to go with?", mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (capYN == DialogResult.Yes)
                {
                    buttonNextPage.Visible = true;
                    finalPoints();
                    nextPage();
                }
            }
        }

        //Start of the logic for decrementing allocated points
        private void buttonMinusStrength_Click(object sender, EventArgs e)
        {
            if (usedPoints > 0 && alloted_strength - 1 != -1)
            {
                alloted_strength = alloted_strength - 1;
                total_strength = total_strength - 1;
                labelAllocatedStr.Text = alloted_strength.ToString();

                if (total_strength < BOOST_POINTS - 1)
                {
                    usedPoints = usedPoints - 1;
                }
                else
                {
                    usedPoints = usedPoints - 2;
                }

                labelUsedPoints.Text = usedPoints.ToString();
                updateStats();
            }
            else
            {
                DialogResult capYN = MessageBox.Show("You cannot reduce this stat any further.",
                    mscaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonMinusDexterity_Click(object sender, EventArgs e)
        {
            if (usedPoints > 0 && alloted_dexterity - 1 != -1)
            {
                alloted_dexterity = alloted_dexterity - 1;
                total_dexterity = total_dexterity - 1;
                labelAllocatedDex.Text = alloted_dexterity.ToString();

                if (total_dexterity < BOOST_POINTS - 1)
                {
                    usedPoints = usedPoints - 1;
                }
                else
                {
                    usedPoints = usedPoints - 2;
                }

                labelUsedPoints.Text = usedPoints.ToString();
                updateStats();
            }
            else
            {
                DialogResult capYN = MessageBox.Show("You cannot reduce this stat any further.",
                    mscaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonMinusConstitution_Click(object sender, EventArgs e)
        {
            if (usedPoints > 0 && alloted_constitution - 1 != -1)
            {
                alloted_constitution = alloted_constitution - 1;
                total_constitution = total_constitution - 1;
                labelAllocatedCon.Text = alloted_constitution.ToString();

                if (total_constitution < BOOST_POINTS - 1)
                {
                    usedPoints = usedPoints - 1;
                }
                else
                {
                    usedPoints = usedPoints - 2;
                }

                labelUsedPoints.Text = usedPoints.ToString();
                updateStats();
            }
            else
            {
                DialogResult capYN = MessageBox.Show("You cannot reduce this stat any further.",
                    mscaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonMinusCharisma_Click(object sender, EventArgs e)
        {
            if (usedPoints > 0 && alloted_charisma - 1 != -1)
            {
                alloted_charisma = alloted_charisma - 1;
                total_charisma = total_charisma - 1;
                labelAllocatedCha.Text = alloted_charisma.ToString();

                if (total_charisma < BOOST_POINTS - 1)
                {
                    usedPoints = usedPoints - 1;
                }
                else
                {
                    usedPoints = usedPoints - 2;
                }

                labelUsedPoints.Text = usedPoints.ToString();
                updateStats();
            }
            else
            {
                DialogResult capYN = MessageBox.Show("You cannot reduce this stat any further.",
                    mscaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            // create an object streamwriter variable
            StreamWriter writeToFile;
            // create a string variable for the file name
            string filename = "DnDCharacter.txt";
            // check if file exists
            // if no, create text, if yes, append text
            if (System.IO.File.Exists(filename))
            {
                writeToFile = System.IO.File.AppendText(filename);
            }
            else
            {
                writeToFile = System.IO.File.CreateText(filename);
            }

            // Write items to the file
            writeToFile.WriteLine("\nDone on " + DateTime.Today.ToShortDateString() +
                " " + DateTime.Now.ToShortTimeString());


            // Use looping to get each item and write to the file
            string item = "\nName:\t\t" + name +
                        "\nLevel:\t\t" + level + 
                        "\nGender:\t\t" + gender +
                        "\nRace:\t\t" + race +
                        "\nRole:\t\t" + role +
                        "\nStrength:\t\t" + final_strength +
                        "\nDexterity:\t\t" + final_dexterity +
                        "\nConstitution:\t\t" + final_constitution +
                        "\nCharisma:\t\t" + final_charisma +
                        "\nWisdom:\t\t\t" + final_wisdom +
                        "\nIntelligence:\t\t" + final_intelligence +
                        "\nAbout me:\t\t" + textBoxSelfIntro.Text +
                        "\nPassword:\t" + password;

            // Write to the file
            writeToFile.WriteLine(item);

            //Inform the user
            MessageBox.Show("You have completed writing to the file: " + filename,
                mscaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            writeToFile.Close();

            // append name and password to Logins.txt
            StreamWriter stream;

            stream = System.IO.File.AppendText("Logins.txt");

            stream.WriteLine(password + ","  + name);

            MessageBox.Show("You have completed writing to Logins: " + "Logins",
            mscaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            stream.Close();

            //string connectionString = "Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\erick\\Downloads\\Dnd_Database.mdf; Integrated Security = True; Connect Timeout = 30; Context Connection = False";

            //SqlConnection connection = new SqlConnection(connectionString: "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\erick\\Downloads\\Dnd_Database.mdf; Integrated Security = True; Connect Timeout = 30; Context Connection = False");

            //connection.Open();

            System.Data.SqlClient.SqlConnection sqlConnection1 =
            new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\erick\\source\\repos\\arcelda\\DnDCharacterCreator\\12-2-23\\DnDCharacterCreator\\Dnd_Database.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO CharacterTable (character_ID, Name, Gender, Race, Role, Level, Strength, Dexterity, Constitution, Charisma, Wisdom, Intelligence, Password) " +
                  "VALUES ((SELECT ISNULL(MAX(character_ID), 0) + 1 FROM CharacterTable), @Name, @Gender, @Race, @Role, @Level, @Strength, @Dexterity, @Constitution, @Charisma, @Wisdom, @Intelligence, @Password)";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            cmd.Parameters.AddWithValue("@character_ID", 1);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Race", race);
            cmd.Parameters.AddWithValue("@Role", role);
            cmd.Parameters.AddWithValue("@Level", level);
            cmd.Parameters.AddWithValue("@Strength", final_strength);
            cmd.Parameters.AddWithValue("@Dexterity", final_dexterity);
            cmd.Parameters.AddWithValue("@Constitution", final_constitution);
            cmd.Parameters.AddWithValue("@Charisma", final_charisma);
            cmd.Parameters.AddWithValue("@Wisdom", final_wisdom);
            cmd.Parameters.AddWithValue("@Intelligence", final_intelligence);
            cmd.Parameters.AddWithValue("@Password", password);

            cmd.ExecuteNonQuery();

            // Retrieve the character_ID that was just inserted
            cmd.CommandText = "SELECT COALESCE(SCOPE_IDENTITY(), 0)";
            int characterID = Convert.ToInt32(cmd.ExecuteScalar());

            sqlConnection1.Close();

            


            // for session table
            System.Data.SqlClient.SqlConnection sqlConnection2 =
            new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\erick\\source\\repos\\arcelda\\DnDCharacterCreator\\12-2-23\\DnDCharacterCreator\\Dnd_Database.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd2 = new System.Data.SqlClient.SqlCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "INSERT INTO SessionTable (session_ID, Name, Notes) " +
                   "VALUES ((SELECT ISNULL(MAX(session_ID), 0) + 1 FROM SessionTable), @Name, @Notes)";
            cmd2.Connection = sqlConnection2;

            sqlConnection2.Open();

            cmd2.Parameters.AddWithValue("@Name", name);  
            cmd2.Parameters.AddWithValue("@Notes", aboutMe);
            //cmd2.Parameters.AddWithValue("@CharacterID", characterID);

            cmd2.ExecuteNonQuery();
            sqlConnection2.Close();




            /*try
            {
                // add ability to send to database table:
                
                    

                    string insertQuery = "INSERT INTO CharacterTable (name, level, gender, race, role, strength, dexterity, constitution, charisma, wisdom, intelligence) " +
                                 "VALUES (@Name, @Level, @Gender, @Race, @Role, @Strength, @Dexterity, @Constitution, @Charisma, @Wisdom, @Intelligence, @Password)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Race", race);
                        command.Parameters.AddWithValue("@Role", role);
                        command.Parameters.AddWithValue("@Level", level);
                        command.Parameters.AddWithValue("@Strength", final_strength);
                        command.Parameters.AddWithValue("@Dexterity", final_dexterity);
                        command.Parameters.AddWithValue("@Constitution", final_constitution);
                        command.Parameters.AddWithValue("@Charisma", final_charisma);
                        command.Parameters.AddWithValue("@Wisdom", final_wisdom);
                        command.Parameters.AddWithValue("@Intelligence", final_intelligence);
                        command.Parameters.AddWithValue("@Password", password);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Character was added to the database!", mscaption,
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the database connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            } */





            nextPage();


           
        }

        private void linkLabelRaces_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.dndbeyond.com/races");
        }

        private void linkLabelRoles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.dndbeyond.com/classes");
        }

        private void buttonReturningPlayer_Click(object sender, EventArgs e)
        {
            //FormReturningPlayer formReturningPlayer = new FormReturningPlayer();
            LoginPage loginPage = new LoginPage();
            this.Hide();
            //formReturningPlayer.ShowDialog();
            loginPage.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Is this the password you want to save?", mscaption,
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                password = textBox_EnterPassword.Text;
                nextPage();
            }
            else
            {
                textBox_EnterPassword.SelectAll();
                textBox_EnterPassword.Focus();
                return;
            }
            
            

        }

        private void buttonMinusWisdom_Click(object sender, EventArgs e)
        {
            if (usedPoints > 0 && alloted_wisdom - 1 != -1)
            {
                alloted_wisdom = alloted_wisdom - 1;
                total_wisdom = total_wisdom - 1;
                labelAllocatedWis.Text = alloted_wisdom.ToString();

                if (total_wisdom < BOOST_POINTS - 1)
                {
                    usedPoints = usedPoints - 1;
                }
                else
                {
                    usedPoints = usedPoints - 2;
                }

                labelUsedPoints.Text = usedPoints.ToString();
                updateStats();
            }
            else
            {
                DialogResult capYN = MessageBox.Show("You cannot reduce this stat any further.",
                    mscaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonFinalize_Click(object sender, EventArgs e)
        {

            int input = int.Parse(textBox_Level.Text);

            if (input >= 1 &&  input <= 3)
            {
                level = input;
            }

            if(usedPoints < MAX_POINTS)
            {
                DialogResult continueYN = MessageBox.Show("You still have points to allocate." +
                    "\nDo you wish to go to the finalize your stats anyway?", mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(continueYN == DialogResult.Yes)
                {
                    finalPoints();
                }
            }
            else
            {
                finalPoints();
            }

            nextPage();
        }

        //Getting input from user to enter information about themselves
        string aboutMe = "";
        private void buttonSubmitBackground_Click(object sender, EventArgs e)
        {
            DialogResult continueYN = MessageBox.Show("Is this how your legendary tale begins?",
                mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (continueYN == DialogResult.Yes)
            {
                aboutMe = textBoxSelfIntro.Text;
                nextPage();
                labelRecap.Visible = true;
                labelRecap.Text = "Welcome, " + name + " to the start of you new adventure!" +
                    "\nIt is pleasant to see a new " + gender + " " + race + " take up the mantle of a " + role + "!"+
                    "\n\nHere are the stats you'll be starting off with." +
                    "\nStrength:      " + final_strength +
                    "\nDexterity:     " + final_dexterity +
                    "\nConstitution:  " + final_constitution +
                    "\nCharisma:      " + final_charisma +
                    "\nWisdom:        " + final_wisdom +
                    "\nIntelligence:  " + final_intelligence;


            }
        }

        public void finalPoints()
        {
            MessageBox.Show("All of your points will now be calculated.");
            finalCha.Visible = true;
            finalCon.Visible = true;
            finalDex.Visible = true;
            finalInt.Visible = true;
            finalStr.Visible = true;
            finalWis.Visible = true;
            labelCompleteStat.Visible = true;

            final_strength = total_strength + race_strength;
            final_dexterity = total_dexterity + race_dexterity;
            final_constitution = total_constitution + race_constitution;
            final_intelligence = total_intelligence + race_intelligence;
            final_wisdom = total_wisdom + race_wisdom;
            final_charisma = total_charisma + race_charisma;

            finalStr.Text = final_strength.ToString();
            finalDex.Text = final_dexterity.ToString();
            finalCon.Text = final_constitution.ToString();
            finalInt.Text = final_intelligence.ToString();
            finalWis.Text = final_wisdom.ToString();
            finalCha.Text = final_charisma.ToString();

            updateStats();
        }

        private void buttonMinusIntelligence_Click(object sender, EventArgs e)
        {
            if (usedPoints > 0 && alloted_intelligence - 1 != -1)
            {
                alloted_intelligence = alloted_intelligence - 1;
                total_intelligence = total_intelligence - 1;
                labelAllocatedInt.Text = alloted_intelligence.ToString();

                if (total_intelligence < BOOST_POINTS - 1)
                {
                    usedPoints = usedPoints - 1;
                }
                else
                {
                    usedPoints = usedPoints - 2;
                }

                labelUsedPoints.Text = usedPoints.ToString();
                updateStats();
            }
            else
            {
                DialogResult capYN = MessageBox.Show("You cannot reduce this stat any further.",
                    mscaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void pictureBoxSorcerer_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                currentRole = pictureBoxSorcerer;
                currentRole.BackColor = Color.White;
            }
            else
            {
                currentRole.BackColor = Color.Transparent;
                currentRole = pictureBoxSorcerer;
                currentRole.BackColor = Color.White;
            }

            role = "Sorcerer";
        }

        private void pictureBoxWarlock_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                currentRole = pictureBoxWarlock;
                currentRole.BackColor = Color.White;
            }
            else
            {
                currentRole.BackColor = Color.Transparent;
                currentRole = pictureBoxWarlock;
                currentRole.BackColor = Color.White;
            }

            role = "Warlock";
        }

        private void pictureBoxWizard_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                currentRole = pictureBoxWizard;
                currentRole.BackColor = Color.White;
            }
            else
            {
                currentRole.BackColor = Color.Transparent;
                currentRole = pictureBoxWizard;
                currentRole.BackColor = Color.White;
            }

            role = "Wizard";
        }

        private void buttonRoleSelect_Click(object sender, EventArgs e)
        {
            if (currentRole == null)
            {
                MessageBox.Show("You have not selected a race.\n" +
                    "Please pick one to continue.", mscaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult choiceYN = MessageBox.Show("You have selected " + role + "\nIs this your final selection?",
                    mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choiceYN == DialogResult.Yes)
                {
                    buttonNextPage.Enabled = true;
                    labelRoleString.Text = "Role: " + role;
                    labelRoleString.Visible = true;
                    nextPage();
                }
            }

        }

        //Letting the players decide on their gender
        private void pictureBoxNonBinary_Click(object sender, EventArgs e)
        {
            gender = "Non-Binary";
            DialogResult ResetYN = MessageBox.Show("Is " + gender + " what you identify as?",
                mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ResetYN == DialogResult.Yes)
            {
                buttonNextPage.Visible = true;
                labelGenderString.Text = "Gender: " + gender;
                labelGenderString.Visible = true;
                nextPage();

            }
            else
            {
                gender = "";
            }

        }

        private void pictureBoxTransgender_Click(object sender, EventArgs e)
        {

            DialogResult transMF = MessageBox.Show("Transgender male or transgender female?" +
                "\nClick Retry for Transgender Male." +
                "\nClick Cancel for Transgender Female.", 
                mscaption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            if(transMF == DialogResult.Retry)
            {
                gender = "Transgender Male";
            }
            else
            {
                gender = "Transgender Female";
            }

            DialogResult ResetYN = MessageBox.Show("Is " + gender + " what you identify as?",
                mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ResetYN == DialogResult.Yes)
            {
                buttonNextPage.Visible = true;
                labelGenderString.Text = "Gender: " + gender;
                labelGenderString.Visible = true;
                nextPage();

            }
            else
            {
                gender = "";
            }

        }

        private void pictureBoxFemale_Click(object sender, EventArgs e)
        {
            gender = "Female";
            DialogResult ResetYN = MessageBox.Show("Is " + gender + " what you identify as?",
                mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ResetYN == DialogResult.Yes)
            { 
                buttonNextPage.Visible = true;
                labelGenderString.Text = "Gender: " + gender;
                labelGenderString.Visible = true;
                nextPage();

            }
            else
            {
                gender = "";
            }

        }

        private void pictureBoxMale_Click(object sender, EventArgs e)
        {
            gender = "Male";
            DialogResult ResetYN = MessageBox.Show("Is " + gender + " what you identify as?",
                mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ResetYN == DialogResult.Yes)
            {
                buttonNextPage.Visible = true;
                labelGenderString.Text = "Gender: " + gender;
                labelGenderString.Visible = true;
                nextPage();
            }
            else
            {
                gender = "";
            }

        }
        //Asking if the name user input is correct
        private void buttonNameConfirm_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            if (name != "")
            {
                DialogResult ResetYN = MessageBox.Show("Is this the name you'll go by? ",
                mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResetYN == DialogResult.Yes)
                {
                    labelGender.Visible = true;
                    pictureBoxFemale.Visible = true;
                    pictureBoxMale.Visible = true;
                    pictureBoxNonBinary.Visible = true;
                    pictureBoxTransgender.Visible = true;
                    labelNameString.Text = "Name: " + name;
                    labelNameString.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please choose a name. ", mscaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void nextPage()
        {
            DialogResult nextPageYN = MessageBox.Show("Do you wish to go to the next page?",
                        mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (nextPageYN == DialogResult.Yes)
            {
                tabControl1.SelectedIndex += 1;
                tabControl1.SelectedTab.Enabled = true;
            }
        }

        public void updateStats()
        {
            labelStrength.Text = "Strength: " + total_strength.ToString();
            labelDexterity.Text = "Dexterity: " + total_dexterity.ToString();
            labelConstitution.Text = "Constitution: " + total_constitution.ToString();
            labelIntelligence.Text = "Intelligence: " + total_intelligence.ToString();
            labelWisdom.Text = "Wisdom: " + total_wisdom.ToString();
            labelCharisma.Text = "Charisma: " + total_charisma.ToString();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tabControl1.TabPages[1].Enabled = true;

            labelNameString.Text = "Name: " + name;
            labelGenderString.Text = "Gender: " + gender;
            labelRaceString.Text = "Race: " + race;
            labelStrength.Text = "Strength: " + total_strength.ToString();
            labelDexterity.Text = "Dexterity: " + total_dexterity.ToString();
            labelConstitution.Text = "Constitution: " + total_constitution.ToString();
            labelIntelligence.Text = "Intelligence: " + total_intelligence.ToString();
            labelWisdom.Text = "Wisdom: " + total_wisdom.ToString();
            labelCharisma.Text = "Charisma: " + total_charisma.ToString();
        }

        private void clearRaceStats()
        {
            race_strength = 0;
            race_dexterity = 0;
            race_constitution = 0;
            race_intelligence = 0;
            race_wisdom = 0;
            race_charisma = 0;
        }

        private void clearAllotedStats()
        {
            alloted_strength = 0;
            alloted_dexterity = 0;
            alloted_constitution = 0;
            alloted_intelligence = 0;
            alloted_wisdom = 0;
            alloted_charisma = 0;
        }

        // The buttons to take player from one page to the next
        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            if(tabControl1.SelectedIndex + 1 == tabControl1.TabPages.Count )
            {
                buttonNextPage.Enabled = true;
                buttonLastPage.Enabled = true;
            }
            else
            {
                buttonNextPage.Enabled = false;

            }
        }

        private void buttonFirstPage_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex - 1 > 0)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
                buttonNextPage.Enabled = true;
            }
            else if(tabControl1.SelectedIndex - 1 < 0)
            {
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                DialogResult ResetYN = MessageBox.Show("By continuing back you will reach the homepage, \nthus resetting your progress. \nDo you wish to continue? ",
                mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ResetYN == DialogResult.Yes)
                {
                    clearAll();
                }
            }
        }

        public void clearAll()
        {
            tabControl1.SelectedIndex = 0;
            clearRaceStats();
            clearAllotedStats();
            buttonNextPage.Visible = false;
            buttonLastPage.Visible = false;
            labelNameString.Visible = false;
            labelGender.Visible = false;
            labelGenderString.Visible = false;
            labelRaceString.Visible = false;
            labelRoleString.Visible = false;
            labelStrength.Visible = false;
            labelConstitution.Visible = false;
            labelDexterity.Visible = false;
            labelCharisma.Visible = false;
            labelWisdom.Visible = false;
            labelIntelligence.Visible = false;
            labelRecap.Visible = false;
            labelCompleteStat.Visible = false;
            labelAllocatedStr.Text= "0";
            labelAllocatedDex.Text= "0";
            labelAllocatedCon.Text= "0";
            labelAllocatedCha.Text= "0";
            labelAllocatedInt.Text= "0";
            labelAllocatedWis.Text= "0";
            labelUsedPoints.Text= "0";
            finalCha.Visible = false;
            finalCon.Visible = false;
            finalDex.Visible = false;
            finalInt.Visible = false;
            finalStr.Visible = false;
            finalWis.Visible = false;
            name = "";
            gender = "";
            race = "";
            role = "";
            aboutMe = "";
            textBoxName.Text = "";
            textBoxSelfIntro.Text = "";
            labelRecap.Text = "";
            pictureBoxFemale.Visible = false;
            pictureBoxMale.Visible = false;
            pictureBoxNonBinary.Visible = false;
            pictureBoxTransgender.Visible = false;
            currentRole.BackColor = Color.Transparent;
            currentRace.BackColor = Color.Transparent;

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                if (i != 0)
                {
                    tabControl1.TabPages[i].Enabled = false;
                }
            }
        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.TabCount - 1;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            DialogResult ResetYN = MessageBox.Show("By clicking home, you will be resetting your progress. \nDo you wish to continue? ",
                mscaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ResetYN == DialogResult.Yes)
            {
                clearAll();
            }
        }
    }
}
