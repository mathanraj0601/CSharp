using RecursiveWebApi.Interfaces;
using RecursiveWebApi.Models.Entity;
using RecursiveWebApi.Models.ViewModel;

namespace RecursiveWebApi.Repositories
{
    public class StandardRepo : IRepo
    {
        public static List<Standard> Standards = new List<Standard>() {
            new Standard{ Id=1, Name="a",ParentId=0 },
            new Standard{ Id=2, Name="b",ParentId=1 },
            new Standard{ Id=3, Name="c",ParentId=2 },
            new Standard{ Id=4, Name="d",ParentId=1 },
            new Standard{ Id=5, Name="e",ParentId=4 },
            new Standard{ Id=6, Name="f",ParentId=5 },
            new Standard{ Id=7, Name="c",ParentId=6 },
            new Standard{ Id=8, Name="d",ParentId=0 },
            new Standard{ Id=9, Name="e",ParentId=8 },

        };

        public List<Standard> GetALLStandard()
        {
            return Standards;
        }
    }
}
