using OlmServer.Domain.AppEntities.Identity;

namespace OlmServer.Domain.Roles
{
    public  sealed class RoleList
    {
        public static List<AppRole> GetStaticRoles()
        {
            List<AppRole> appRoles = new List<AppRole>
            {
                new AppRole(
                    title:Ucaf,
                    code:UcafCreateCode,
                    name:UcafCreateName
                    ),

                new AppRole(
                    title:Ucaf,
                    code:UcafUpdateCode,
                    name:UcafUpdateName
                    ),

                 new AppRole(
                    title:Ucaf,
                    code:UcafRemoveCode,
                    name:UcafRemoveName
                    ),

                   new AppRole(
                    title:Ucaf,
                    code:UcafReadCode,
                    name:UcafReadName
                    )

            };

            return appRoles;
        
        }


        public static string Ucaf = "Hesap Planı";


        public static string UcafCreateCode = "Ucaf.Create";
        public static string UcafCreateName = "Hesap Planı Kayıt";


        public static string UcafUpdateCode = "Ucaf.Update";
        public static string UcafUpdateName = "Hesap Planı Güncelleme";

        public static string UcafRemoveCode = "Ucaf.Remove";
        public static string UcafRemoveName = "Hesap Planı Silme";

        public static string UcafReadCode = "Ucaf.Read";
        public static string UcafReadName = "Hesap Planı Görüntüleme";

    }
}
