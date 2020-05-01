/*Zachary Hodgson
 * ITSE 1430
 * Mr. Taylor
 * Lab 3
 * 4/21/2020
 */


namespace CharacterCreator
{
    public interface ICharacterRoster
    {
        void Delete ( int id );
        Character[] GetAll ();

        void LoadCharacter ();

        void SaveList ();

        Character SaveCharacter ( Character character );

        string Update ( int id, Character character );
    }
}