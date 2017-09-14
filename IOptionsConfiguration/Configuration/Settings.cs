namespace IOptionsConfiguration.Configuration
{
    public class CbnSettings
    {
        public MessagesOptions Messages { get; set; }
        public string MainMessage { get; set; }
    }

    public class MessagesOptions
    {
        public string AlertMessage { get; set; }
        public string RegularMessage { get; set; }
        public bool ShouldShowAlert { get; set; }
    }
}