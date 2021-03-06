namespace ObcyProtoRev.Protocol.Client
{
    public sealed class DisconnectInfo
    {
        public bool IsReminder { get; private set; }
        public int ClientID { get; private set; }

        public DisconnectInfo(bool isReminder, int clientId)
        {
            IsReminder = isReminder;
            ClientID = clientId;
        }
    }
}
