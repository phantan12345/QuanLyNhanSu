using QuanLyNhanSu;
using System.Linq;

public class DAO_BangCongUser
{
    NhanSuEntities1 dbo;
    public DAO_BangCongUser()
    {
        dbo = new NhanSuEntities1();
    }

    public dynamic getDsBangCong(string id)
    {
        
        var bangCong = dbo.BangCongs.Where(s => s.MaNV == id)
            .Select(s => new { s.MaNV, s.NgayLam, s.ThangLam, s.NamLam }).ToList();

        return bangCong;
    }

    public dynamic searchBangCong(string id, int t, int n)
    {
        var bangCong = dbo.BangCongs
            .Select(s => new { s.MaNV, s.NgayLam, s.ThangLam, s.NamLam })
            .Where(s => s.MaNV == id && s.ThangLam == t && s.NamLam == n).ToList();

        return bangCong;
    }

    public dynamic searchBangCongM(string id, int t)
    {
        var bangCong = dbo.BangCongs
             .Select(s => new { s.MaNV, s.NgayLam, s.ThangLam, s.NamLam })
             .Where(s => s.MaNV == id && s.ThangLam == t).ToList();
        return bangCong;
    }

    public dynamic searchInsuranceY(string id, int n)
    {
        var bangCong = dbo.BangCongs
             .Select(s => new { s.MaNV, s.NgayLam, s.ThangLam, s.NamLam })
             .Where(s => s.MaNV == id && s.NamLam == n).ToList();
        return bangCong;
    }

    public bool addBangCong(BangCong c)
    {
        bool isDuplicate = dbo.BangCongs
                        .Any(s => s.MaNV == c.MaNV
                               && s.NgayLam == c.NgayLam
                               && s.ThangLam == c.ThangLam
                               && s.NamLam == c.NamLam);
        if (!isDuplicate)
        {
            dbo.BangCongs.Add(c);
            dbo.SaveChanges();
            return true;
        }
        return false;


    }
}
