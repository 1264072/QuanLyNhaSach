
namespace DTO
{
    public class NhoMatKhauDTO
    {
        string uSERNAME;
        string pASSWORD;
        bool tRANGTHAI;

        public bool TRANGTHAI
        {
            get { return tRANGTHAI; }
            set { tRANGTHAI = value; }
        }

        public string PASSWORD
        {
            get { return pASSWORD; }
            set { pASSWORD = value; }
        }

        public string USERNAME
        {
            get { return uSERNAME; }
            set { uSERNAME = value; }
        }

        public NhoMatKhauDTO() { }
        public NhoMatKhauDTO(string username, string password, bool status)
        {
            USERNAME = username;
            PASSWORD = password;
            TRANGTHAI = status;
        }
    }
}
