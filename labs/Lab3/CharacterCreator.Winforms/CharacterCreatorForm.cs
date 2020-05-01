/*Zachary Hodgson
 * ITSE 1430
 * Mr. Taylor
 * Lab 3
 * 4/21/2020
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator;
using System.IO;
using System.Xml.Serialization;

namespace CharacterCreator.Winforms
{
    public partial class CharacterCreatorForm : Form
    {

        public CharacterCreatorForm ()
        {
            InitializeComponent();
        }

        public Character Character
        { get; set; }
        
        private int GetAsInt32 ( string txtBox )
        {
            
            var temp = Int32.Parse(txtBox);
            
            return temp;
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            Close();

        }

        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;
            
            Character = new Character {
                Agility = GetAsInt32(txtAgility.Text),
                Charisma = GetAsInt32(txtCharisma.Text),
                Constitution = GetAsInt32(txtConstitution.Text),
                Strength = GetAsInt32(txtStrength.Text),
                Intelligence = GetAsInt32(txtIntelligence.Text),
                Name = txtName.Text,
                Race = comboBoxRace.Text,
                Profession = comboBoxProfession.Text,
                Description = richTextDescription.Text,
                PointsRemaining = GetAsInt32(txtPointsRemaining.Text)
            };

            IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> errors = Validation.Validate(Character);

            if (errors.Any())
            {
                MessageBox.Show("Error");
                return;
            }

            DialogResult = DialogResult.OK;
            
            Close();
        }


        private void AddStrength ( object sender, EventArgs e )
        {
            StatCounter.AddStat(txtPointsRemaining.Text, txtStrength.Text, out var temp, out var temp2);
            
            if (temp2 == null)
                return;
            else
            {
                txtStrength.Text = temp2;
                txtPointsRemaining.Text = temp;
            }

        }

        private void SubtractStrength ( object sender, EventArgs e )
        {
            StatCounter.SubtractStat(txtPointsRemaining.Text, txtStrength.Text, out var temp, out var temp2);
            if (temp2 == null)
                return;
            else
            {
                txtStrength.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void AddInteligence ( object sender, EventArgs e )
        {
            StatCounter.AddStat(txtPointsRemaining.Text, txtIntelligence.Text, out var temp, out var temp2);
            
            if (temp2 == null)
                return;
            else
            {
                txtIntelligence.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void AddAgility ( object sender, EventArgs e )
        {
            StatCounter.AddStat(txtPointsRemaining.Text, txtAgility.Text, out var temp, out var temp2);
            
            if (temp2 == null)
                return;
            else
            {
                txtAgility.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void AddConstitution ( object sender, EventArgs e )
        {
            StatCounter.AddStat(txtPointsRemaining.Text, txtConstitution.Text, out var temp, out var temp2);
            
            if (temp2 == null)
                return;
            else
            {
                txtConstitution.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void AddCharisma ( object sender, EventArgs e )
        {
            StatCounter.AddStat(txtPointsRemaining.Text, txtCharisma.Text, out var temp, out var temp2);
            
            if (temp2 == null)
                return;
            else
            {
                txtCharisma.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void SubtractIntelligence ( object sender, EventArgs e )
        {
            StatCounter.SubtractStat(txtPointsRemaining.Text, txtIntelligence.Text, out var temp, out var temp2);
            
            if (temp2 == null)
                return;
            else
            {
                txtIntelligence.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void SubtractAgility ( object sender, EventArgs e )
        {
            StatCounter.SubtractStat(txtPointsRemaining.Text, txtAgility.Text, out var temp, out var temp2);
            if (temp2 == null)
                return;
            else
            {
                txtAgility.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void SubtractConstitution ( object sender, EventArgs e )
        {
            StatCounter.SubtractStat(txtPointsRemaining.Text, txtConstitution.Text, out var temp, out var temp2);
            if (temp2 == null)
                return;
            else
            {
                txtConstitution.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }


        private void SubtractCharisma ( object sender, EventArgs e )
        {
            StatCounter.SubtractStat(txtPointsRemaining.Text, txtCharisma.Text, out var temp, out var temp2);
            if (temp2 == null)
                return;
            else
            {
                txtCharisma.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);
            if (Character != null)
            {

                txtName.Text = Character.Name.ToString();
                txtAgility.Text = Character.Agility.ToString();
                txtCharisma.Text = Character.Charisma.ToString();
                txtConstitution.Text = Character.Constitution.ToString();
                txtIntelligence.Text = Character.Intelligence.ToString();
                txtPointsRemaining.Text = "0";
                txtStrength.Text = Character.Strength.ToString();
                comboBoxProfession.Text = Character.Profession.ToString();
                comboBoxRace.Text = Character.Race.ToString();
                richTextDescription.Text = Character.Description.ToString();
            }
        }

        private void CharacterCreatorForm_Load(object sender, EventArgs e)
        {

        }

        private void OnValidateName(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "A Name is required.");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }

        private void OnValidateProfession(object sender, CancelEventArgs e)
        {
            var control = sender as ComboBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "A profession is required.");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }

        private void OnValidateRace(object sender, CancelEventArgs e)
        {
            var control = sender as ComboBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "A Race is required.");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }

        private void txtName_TextChanged ( object sender, EventArgs e )
        {

        }
    }
}
