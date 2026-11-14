using System.Reflection;

namespace ProtetorDigital.Services;

public static class Suavizar
{
    // Aplica DoubleBuffered recursivamente para reduzir cintilação durante a pintura das telas.
    public static void Aplicar(Form formulario)
    {
        AplicarControle(formulario);
    }

    private static void AplicarControle(Control controle)
    {
        // Reflection acessa a propriedade protegida e depois percorre todos os controles filhos.
        var propriedade = controle.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
        if (propriedade?.CanWrite == true) propriedade.SetValue(controle, true);
        foreach (Control filho in controle.Controls) AplicarControle(filho);
    }
}
