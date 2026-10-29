using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Windows.Forms;

namespace ProtetorDigital.Services;

public static class JanelaPadrao
{
    public static readonly Size TamanhoPadrao = new(1201, 700);

    private static Rectangle? _bounds;
    private static FormWindowState _windowState = FormWindowState.Normal;
    private static bool _temEstado;
    private static readonly ConditionalWeakTable<Form, object> FormulariosRegistrados = new();
    private static bool _aplicando;

    public static void Registrar(Form f)
    {
        if (FormulariosRegistrados.TryGetValue(f, out _)) return;

        FormulariosRegistrados.Add(f, new object());
        f.StartPosition = FormStartPosition.Manual;
        f.Load += (_, _) => Aplicar(f);
        f.VisibleChanged += (_, _) =>
        {
            if (f.Visible) Aplicar(f);
        };
        f.ResizeEnd += (_, _) => Salvar(f);
        f.FormClosing += (_, _) => Salvar(f);
        f.SizeChanged += (_, _) =>
        {
            if (f.WindowState is FormWindowState.Normal or FormWindowState.Maximized)
                Salvar(f);
        };
    }

    public static void Aplicar(Form f)
    {
        if (_aplicando) return;
        _aplicando = true;
        try
        {
            var tela = Screen.FromControl(f);
            var area = tela.WorkingArea;
            var minimo = f.MinimumSize;

            if (!_temEstado)
            {
                if (!CabeNaArea(TamanhoPadrao, area, minimo))
                {
                    f.WindowState = FormWindowState.Maximized;
                    _windowState = FormWindowState.Maximized;
                    return;
                }

                f.WindowState = FormWindowState.Normal;
                f.ClientSize = TamanhoPadrao;
                f.Location = Centralizar(f.ClientSize, area).Location;
                return;
            }

            var bounds = _bounds!.Value;
            if (!CruzaAlgumaTela(bounds) || !CabeNaArea(bounds.Size, area, minimo))
            {
                if (!CabeNaArea(TamanhoPadrao, area, minimo))
                {
                    f.WindowState = FormWindowState.Maximized;
                    _windowState = FormWindowState.Maximized;
                    return;
                }

                f.WindowState = FormWindowState.Normal;
                f.ClientSize = TamanhoPadrao;
                f.Location = Centralizar(f.ClientSize, area).Location;
                _bounds = f.Bounds;
                _windowState = FormWindowState.Normal;
                return;
            }

            f.WindowState = FormWindowState.Normal;
            f.Bounds = bounds;
            f.WindowState = _windowState;
        }
        finally
        {
            _aplicando = false;
        }
    }

    private static void Salvar(Form f)
    {
        if (_aplicando || f.WindowState == FormWindowState.Minimized) return;

        if (f.WindowState == FormWindowState.Maximized)
        {
            _bounds = f.RestoreBounds;
            _windowState = FormWindowState.Maximized;
        }
        else
        {
            _bounds = f.Bounds;
            _windowState = FormWindowState.Normal;
        }

        _temEstado = true;
    }

    private static bool CruzaAlgumaTela(Rectangle bounds)
    {
        return Screen.AllScreens.Any(tela => tela.WorkingArea.IntersectsWith(bounds));
    }

    private static bool CabeNaArea(Size tamanho, Rectangle area, Size minimo)
    {
        return tamanho.Width >= minimo.Width && tamanho.Height >= minimo.Height &&
               tamanho.Width <= area.Width && tamanho.Height <= area.Height;
    }

    private static Rectangle Centralizar(Size tamanho, Rectangle area)
    {
        var x = area.Left + Math.Max(0, (area.Width - tamanho.Width) / 2);
        var y = area.Top + Math.Max(0, (area.Height - tamanho.Height) / 2);
        return new Rectangle(new Point(x, y), tamanho);
    }
}
