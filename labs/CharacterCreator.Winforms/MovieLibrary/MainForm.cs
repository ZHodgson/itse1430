using CharacterCreator.Business;
using CharacterCreator.Winforms;
using System;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm ()
        {
            InitializeComponent();

            
            #endregion
        }
        


        private bool DisplayConfirmation ( string message, string title )
        {
            //Display a confirmation dialog
            var result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //Return true if user selected OK
            return result == DialogResult.OK;
        }

        /// <summary>Displays an error message.</summary>
        /// <param name="message">Error to display.</param>
        private void DisplayError ( string message )
        {
            #region Playing with this

            //this represents the current instance
            //var that = this;

            //var Text = "";

            //These are equal
            //var newTitle = this.Text;
            //var newTitle = Text;
            #endregion

            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region Playing with methods

        void DisplayMovie ( Character movie )
        {
            if (movie == null)
                return;

            var title = movie.Name;
            movie.Description = "Test";

            movie = new Character();
        }
        #endregion

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            UpdateUI();
        }


        private void OnCharacterAdd ( object sender, EventArgs e )
        {
            CharacterForm child = new CharacterForm();

            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            AddCharacter(child.Character);
            UpdateUI();
        }

        private void UpdateUI ()
        {
            lstCharacters.Items.Clear();
            var characters = GetCharacters();
            foreach (var character in characters)
            {
                if (character != null)
                    lstCharacters.Items.Add(character);
            };
        }


        private void AddCharacter ( Character character )
        {
            for (var index = 0; index < _characters.Length; ++index)
            {
                if (_characters[index] == null)
                {
                    _characters[index] = character;
                    break;
                };
            };
        }

        private Character[] GetCharacters ()
        {
            return _characters;
        }


        private Character GetSelectedCharacter ()
        {
            return lstCharacters.SelectedItem as Character;
        }

        private void UpdateCharacter ( Character oldCharacter, Character newCharacter )
        {
            for (var index = 0; index < _characters.Length; ++index)
            {
                if (_characters[index] == oldCharacter)
                {
                    _characters[index] = newCharacter;
                    break;
                };
            };
        }

        private void DeleteCharacter ( Character character )
        {
            for (var index = 0; index < _characters.Length; ++index)
            {
                if (_characters[index] == character)
                {
                    _characters[index] = null;
                    break;
                };
            };
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            //Verify

            var character = GetSelectedCharacter();
            if (character == null)
                return;

            var child = new CharacterForm();
            child.Character = character;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            UpdateCharacter(character, child.Character);
            UpdateUI();
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            //Verify
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            //Confirm
            if (!DisplayConfirmation($"Are you sure you want to delete {character.Name}?", "Delete"))
                return;

            //TODO: Delete
            DeleteCharacter(character);
            UpdateUI();
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox();

            about.ShowDialog(this);
        }

        private Character[] _characters = new Character[100];
    }
}
