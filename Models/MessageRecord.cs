namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
         // Changes for Sprint 1 -- User Story -- Cosmas Mandikonza
         // Changes Sprint 1b -- As a message reading user, I want to view a list of rooms that represent conversations
        public MessageRecord(int roomID, string authorName, string text)
        {
            // Changes Sprint 2 -- User Story 2A -- Sydney Schaefer
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            get;
            private set;
        }

        // Changes Sprint 2 -- User Story 2A -- Sydney Schaefer
        public string Text
        {
            get;
            private set;
        }
         // Changes for Sprint 1 -- User Story -- Cosmas Mandikonza
         // Changes Sprint 1b -- As a message reading user, I want to view a list of rooms that represent conversations
        public string AuthorName
        {
            get;
            private set;
        }
    }
}
