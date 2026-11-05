using System.Reflection;

namespace ProtetorDigital.Services;

public static class Suavizar
{
    public static void Aplicar(Form formulario)
    {
        AplicarControle(formulario);
    }

    private static void AplicarControle(Control controle)
    {
        var propriedade = controle.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
        if (propriedade?.CanWrite == true) propriedade.SetValue(controle, true);
        foreach (Control filho in controle.Controls) AplicarControle(filho);
    }
}
