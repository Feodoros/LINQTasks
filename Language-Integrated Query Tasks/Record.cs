using System;

namespace Language_Integrated_Query_Tasks
{
    class Record
    {
        public User Author { get; set; }
        public String Message { get; set; }

        public Record(User author, String message)
        {
            this.Author = author;
            this.Message = message;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Author, Message);
        }

    }
}
