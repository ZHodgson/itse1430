using System;
using System.Windows.Forms;

using CharacterCreator.Business;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        #region Constructors

        //If no constructor specified then base default constructor is called automatically
        public CharacterForm () //: base()
        {
            InitializeComponent();
        }

        public CharacterForm ( string title, Character character ) : this()
        {
            Text = title;
            Character = character;
        }
        #endregion

        public Character Character { get; set; }

        #region Event Handlers

        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnOK ( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            // Validation and error reporting
            var character = GetCharacter();
            if (!character.Validate(out var error))
            {
                DisplayError(error);
                return;
            };

            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            //Populate combo
            var professions = Professions.GetAll();
            ddlProfession.Items.AddRange(professions);
            var race = Races.GetAll();
            ddlRace.Items.AddRange(race);

            if (Character != null)
            {
                txtTitle.Text = Character.Name;
                txtDescription.Text = Character.Description;
                txtIntelligence.Text = Character.Intelligence.ToString();
                txtStrength.Text = Character.Strength.ToString();
                txtAgility.Text = Character.Agility.ToString();
                txtCharisma.Text = Character.Charisma.ToString();
                txtConstitution.Text = Character.Constitution.ToString();

                if (Character.CharacterProfession != null)
                    ddlProfession.SelectedText = Character.CharacterProfession.Description;
               
                if (Character.CharacterRace != null)
                    ddlRace.SelectedText = Character.CharacterRace.Description;

                ValidateChildren();
            };
        }

        private Character GetCharacter ()
        {
            var character = new Character();

            //Null conditional
            character.Name = txtTitle.Text?.Trim();
            character.Strength = GetAsInt32(txtStrength);
            character.Intelligence = GetAsInt32(txtIntelligence);
            character.Agility = GetAsInt32(txtAgility);
            character.Constitution = GetAsInt32(txtConstitution);
            character.Charisma = GetAsInt32(txtCharisma);
            character.Description = txtDescription.Text.Trim();
            //Pattern match
            if (ddlProfession.SelectedItem is Profession profession)
                character.CharacterProfession = profession;
            if (ddlRace.SelectedItem is Race race)
                character.CharacterRace = race;
            return character;
        }

        /// <summary>Displays an error message.</summary>
        /// <param name="message">Error to display.</param>
        private void DisplayError ( string message )
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int GetAsInt32 ( Control control )
        {
            //DateTime result;

            return GetAsInt32(control, 0);
        }

        private int GetAsInt32 ( Control control, int emptyValue )
        {
            if (String.IsNullOrEmpty(control.Text))
                return emptyValue;

            if (Int32.TryParse(control.Text, out var result))
                return result;

            return -1;
        }

        private void OnValidateName ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                //DisplayError("Name is required");
                _errors.SetError(control, "Name is required");
                e.Cancel = true;
            } else
                _errors.SetError(control, "");
        }

        private void OnValidateAttributes ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var control = sender as Control;
            var value = GetAsInt32(control, 0);
            if (value < 0)
            {
                _errors.SetError(control, "Value must be between 0 and 100.");
                e.Cancel = true;
            }
            else
                if (value > 100)
            {
                _errors.SetError(control, "Value must be between 0 and 100.");
                e.Cancel = true;
            } else
                _errors.SetError(control, "");
        }
        private void OnValidateProfession(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ddlProfession.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("Please select a Profession", "Error");
            }
            else
            {
                return;   
            }
        }
        private void OnValidateRace(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ddlRace.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("Please select a Race", "Error");
            }
            else
            {
                return;
            }
        }
    }
}
