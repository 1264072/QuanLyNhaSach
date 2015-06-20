
namespace DTO
{
    public class TaiKhoanDTO
    {
        string uSERNAME;
        string pASSWORD;
        string mANV;
        string tENNV;

        public string TENNV
        {
            get { return tENNV; }
            set { tENNV = value; }
        }

        public string USERNAME
        {
            get { return uSERNAME; }
            set { uSERNAME = value; }
        }

        public string PASSWORD
        {
            get { return pASSWORD; }
            set { pASSWORD = value; }
        }

        public string MANV
        {
            get { return mANV; }
            set { mANV = value; }
        }

        public TaiKhoanDTO() { }
        public TaiKhoanDTO(string username, string password, string manv)
        {
            USERNAME = username;
            PASSWORD = password;
            MANV = manv;
        }
    }
}
