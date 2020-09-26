public class Listado : ApiGitHub
{
    [HttpGet]
    public List<Usuario_Ingresado> Web()
    {
        List<Usuario_Ingresado> an = new List<Usuario_Ingresado>();
        Usuario_Ingresado u1 = new Usuario_Ingresado();
        login = "Covit_19";
        id = "1958795";
        Nombre = "Covit Perez";
        Avatar = "Avatar01";
        Public_repos = "8";
        Followers = "5";
        Following = "2";
        Created_at = "25/09/2020";
        an.Add (u1);
        Usuario_Ingresado u2 = new Usuario_Ingresado();
        login = "Conviviano";
        id = "5287951";
        Nombre = "Conviviando Paz";
        Avatar = "Avatar02";
        Public_repos = "20";
        Followers = "10";
        Following = "2";
        Created_at = "25/09/2020";
        an.Add (u2);
        return an;

    }    



}